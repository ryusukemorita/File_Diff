using System;
using System.Windows.Forms;

namespace FileDiff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public delegate void EventHandler(EventArgs args);
        //public event EventHandler BtnClickHandler;

        public void Btn_Folder_Ref1_Click(object sender, EventArgs e)
        {          
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public void Btn_Folder_Ref2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog2.SelectedPath;
            }
                
        }

        public void Btn_Run_Click(object sender, EventArgs e)
        {
            
            var args = new ClickEventArgs(textBox1.Text, textBox2.Text);
                
            if (textBox1.Text != null && textBox2.Text != null)
            {
                Program.OnClick(args);
                MessageBox.Show("実行が完了しました。");
            }
            else if (textBox1.Text == null || textBox2.Text == null)
            {
                MessageBox.Show("フォルダを選択してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("問題が発生しました。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_path1_Click(object sender, EventArgs e)
        {

        }

        private void label_path2_Click(object sender, EventArgs e)
        {

        }

        private void label_expranation_Click(object sender, EventArgs e)
        {

        }
    }

    public class ClickEventArgs : EventArgs
    {
        public string textValue1 { get; set; }
        public string textValue2 { get; set; }

        public ClickEventArgs(string textValue1, string textValue2)
        {
            this.textValue1 = textValue1;
            this.textValue2 = textValue2;
        }
    }
}
