using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;


namespace FileDiff
{
    public class Program
    {
        ///public static Form1 ApplicationMainForm { get; private set; }
        
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1());
        }

        public static void OnClick(EventArgs args)
        {
            var clickEventArgs = (ClickEventArgs)args;
            
            // Excel出力ファイルを作成する。
            string exportFileName = @"FileDiff_" + DateTime.Now.ToString($"{DateTime.Now:yyyyMMddHHmmss}") + ".xlsx";
            File.Copy(@".\tmp\template.xlsx", exportFileName);

            // 書き込むデータを設定する。 
            string folder_path1 = clickEventArgs.textValue1;
            string folder_path2 = clickEventArgs.textValue2;

            DirectoryInfo directory_info1 = new DirectoryInfo(folder_path1);
            FileInfo[] get_files_info1 = directory_info1.GetFiles("*", SearchOption.AllDirectories);
            List<string> file_paths1 = new List<string>();
            foreach (FileInfo fi in get_files_info1)
            {
                file_paths1.Add(fi.FullName.ToString());
            }

            
            var files_info1 = new Dictionary<string, string> { };
            foreach (string fpath in file_paths1)
            {
                string fname = fpath.Replace(folder_path1, "");
                string timestamp = File.GetLastWriteTime(fpath).ToString();
                files_info1[fname] = timestamp;
            }


            DirectoryInfo directory_info2 = new DirectoryInfo(folder_path2);
            FileInfo[] get_files_info2 = directory_info2.GetFiles("*", SearchOption.AllDirectories);
            List<string> file_paths2 = new List<string>();
            foreach (FileInfo fi in get_files_info2)
            {
                file_paths2.Add(fi.FullName.ToString());
            }


            var files_info2 = new Dictionary<string, string> { };
            foreach (string fpath in file_paths2)
            {
                string fname = fpath.Replace(folder_path2, "");
                string timestamp = File.GetLastWriteTime(fpath).ToString();
                files_info2[fname] = timestamp;
            }

            // シートを開く。
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Visible = false;

            Workbooks ExcelWBs = ExcelApp.Workbooks;
            
            var exportFilePath = Path.Combine(new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName, exportFileName);

            Workbook ExcelWB = ExcelWBs.Open(exportFilePath);
            Worksheet ExcelWorksheet = ExcelWB.Sheets[1];
            ExcelWorksheet.Select();

            // シートへ書き込みする。
            try
            {
                int num = 1;
                var input_list = new List<string[]>();

                foreach (KeyValuePair<string, string> finfo1 in files_info1)
                {
                    bool flag1 = false;

                    foreach (KeyValuePair<string, string> finfo2 in files_info2)
                    {
                        if (finfo1.Key == finfo2.Key)
                        {
                            string[] input = new string[] { num.ToString(), finfo1.Key, finfo1.Value, finfo2.Key, finfo2.Value };
                            input_list.Add(input);
                            num++;
                            flag1 = true;
                        }                      
                    }
                    if (flag1 == false)
                    {
                        string[] input = new string[] { num.ToString(), finfo1.Key, finfo1.Value, "-", "-" };
                        input_list.Add(input);
                        num++;
                    }
                    continue;
                }

                foreach (KeyValuePair<string, string> finfo2 in files_info2)
                {
                    bool flag2 = false;

                    foreach (KeyValuePair<string, string> finfo1 in files_info1)
                    {
                        if (finfo2.Key == finfo1.Key)
                        {
                            flag2 = true;
                        }
                    }
                    if (flag2 == false)
                    {
                        string[] input = new string[] { num.ToString(), "-", "-", finfo2.Key, finfo2.Value };
                        input_list.Add(input);
                        num++;
                    }
                    continue;
                }


                Range OutputRange = ExcelWorksheet.Range[ExcelWorksheet.Cells[2, 1], ExcelWorksheet.Cells[num + 1, 5]];
                for (int r = 1; r < num; r++)
                {
                    for (int c = 1; c < 6; c++)
                    {
                        OutputRange[r, c].Value2 = input_list[r-1][c-1];
                        Console.WriteLine(OutputRange[r, c].Value2);
                    }
                }
                

                // ファイルへ書き込みする。
                ExcelWB.SaveAs(exportFilePath);
                ExcelWB.Close();

                // オブジェクトを破棄する。
                Marshal.ReleaseComObject(OutputRange);
                OutputRange = null;
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            // オブジェクトを破棄する。
            Marshal.ReleaseComObject(ExcelWorksheet);
            ExcelWorksheet = null;
            Marshal.ReleaseComObject(ExcelWB);
            ExcelWB = null;
            Marshal.ReleaseComObject(ExcelWBs);
            ExcelWBs = null;

            // ガベージコレクションを実行する。
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // アプリケーションを終了する。
            ExcelApp.Quit();

            // Appricationオブジェクトを破棄する。
            Marshal.ReleaseComObject(ExcelApp);
            ExcelApp = null;

            // Appricationオブジェクトのガベージコレクションを実行する。
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
