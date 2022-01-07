
namespace FileDiff
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_folder_ref1 = new System.Windows.Forms.Button();
            this.btn_folder_ref2 = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_path2 = new System.Windows.Forms.Label();
            this.label_path1 = new System.Windows.Forms.Label();
            this.label_expranation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 19);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(469, 19);
            this.textBox2.TabIndex = 1;
            // 
            // btn_folder_ref1
            // 
            this.btn_folder_ref1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_folder_ref1.Location = new System.Drawing.Point(600, 59);
            this.btn_folder_ref1.Name = "btn_folder_ref1";
            this.btn_folder_ref1.Size = new System.Drawing.Size(75, 23);
            this.btn_folder_ref1.TabIndex = 2;
            this.btn_folder_ref1.Text = "参照";
            this.btn_folder_ref1.UseVisualStyleBackColor = true;
            this.btn_folder_ref1.Click += new System.EventHandler(this.Btn_Folder_Ref1_Click);
            // 
            // btn_folder_ref2
            // 
            this.btn_folder_ref2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_folder_ref2.Location = new System.Drawing.Point(600, 105);
            this.btn_folder_ref2.Name = "btn_folder_ref2";
            this.btn_folder_ref2.Size = new System.Drawing.Size(75, 23);
            this.btn_folder_ref2.TabIndex = 3;
            this.btn_folder_ref2.Text = "参照";
            this.btn_folder_ref2.UseVisualStyleBackColor = true;
            this.btn_folder_ref2.Click += new System.EventHandler(this.Btn_Folder_Ref2_Click);
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_run.Location = new System.Drawing.Point(374, 164);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "実行";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_cancel.Location = new System.Drawing.Point(501, 164);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "キャンセル";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label_path2
            // 
            this.label_path2.AutoSize = true;
            this.label_path2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_path2.Location = new System.Drawing.Point(16, 113);
            this.label_path2.Name = "label_path2";
            this.label_path2.Size = new System.Drawing.Size(85, 15);
            this.label_path2.TabIndex = 6;
            this.label_path2.Text = "フォルダパス②：";
            this.label_path2.Click += new System.EventHandler(this.label_path2_Click);
            // 
            // label_path1
            // 
            this.label_path1.AutoSize = true;
            this.label_path1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_path1.Location = new System.Drawing.Point(16, 67);
            this.label_path1.Name = "label_path1";
            this.label_path1.Size = new System.Drawing.Size(85, 15);
            this.label_path1.TabIndex = 7;
            this.label_path1.Text = "フォルダパス①：";
            this.label_path1.Click += new System.EventHandler(this.label_path1_Click);
            // 
            // label_expranation
            // 
            this.label_expranation.AutoSize = true;
            this.label_expranation.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_expranation.Location = new System.Drawing.Point(103, 20);
            this.label_expranation.Name = "label_expranation";
            this.label_expranation.Size = new System.Drawing.Size(309, 19);
            this.label_expranation.TabIndex = 8;
            this.label_expranation.Text = "フォルダを選択し、 [実行] をクリックしてください。";
            this.label_expranation.Click += new System.EventHandler(this.label_expranation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 199);
            this.Controls.Add(this.label_expranation);
            this.Controls.Add(this.label_path1);
            this.Controls.Add(this.label_path2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_folder_ref2);
            this.Controls.Add(this.btn_folder_ref1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "FileDiff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_folder_ref1;
        private System.Windows.Forms.Button btn_folder_ref2;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label_path2;
        private System.Windows.Forms.Label label_path1;
        private System.Windows.Forms.Label label_expranation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

