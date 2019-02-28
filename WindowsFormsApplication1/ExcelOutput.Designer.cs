namespace WindowsFormsApplication1
{
    partial class ExcelOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tBx_fileadd = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tBx_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_preview = new CCWin.SkinControl.SkinButton();
            this.btn_Y = new CCWin.SkinControl.SkinButton();
            this.EO_btnRetnru = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // tBx_fileadd
            // 
            this.tBx_fileadd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tBx_fileadd.Location = new System.Drawing.Point(217, 106);
            this.tBx_fileadd.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_fileadd.Name = "tBx_fileadd";
            this.tBx_fileadd.ReadOnly = true;
            this.tBx_fileadd.Size = new System.Drawing.Size(380, 23);
            this.tBx_fileadd.TabIndex = 0;
            // 
            // tBx_fileName
            // 
            this.tBx_fileName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tBx_fileName.Location = new System.Drawing.Point(217, 174);
            this.tBx_fileName.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_fileName.Name = "tBx_fileName";
            this.tBx_fileName.Size = new System.Drawing.Size(380, 23);
            this.tBx_fileName.TabIndex = 3;
            this.tBx_fileName.Text = "请输入文件名：";
            this.tBx_fileName.Click += new System.EventHandler(this.tBx_fileName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(128, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件名：";
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_preview.DownBack = null;
            this.btn_preview.Location = new System.Drawing.Point(125, 97);
            this.btn_preview.MouseBack = null;
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.NormlBack = null;
            this.btn_preview.Size = new System.Drawing.Size(69, 38);
            this.btn_preview.TabIndex = 6;
            this.btn_preview.Text = "浏览";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_Y
            // 
            this.btn_Y.BackColor = System.Drawing.Color.Transparent;
            this.btn_Y.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Y.DownBack = null;
            this.btn_Y.Location = new System.Drawing.Point(547, 482);
            this.btn_Y.MouseBack = null;
            this.btn_Y.Name = "btn_Y";
            this.btn_Y.NormlBack = null;
            this.btn_Y.Size = new System.Drawing.Size(69, 38);
            this.btn_Y.TabIndex = 7;
            this.btn_Y.Text = "导出";
            this.btn_Y.UseVisualStyleBackColor = false;
            this.btn_Y.Click += new System.EventHandler(this.btn_Y_Click);
            // 
            // EO_btnRetnru
            // 
            this.EO_btnRetnru.BackColor = System.Drawing.Color.Transparent;
            this.EO_btnRetnru.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.EO_btnRetnru.DownBack = null;
            this.EO_btnRetnru.Location = new System.Drawing.Point(637, 482);
            this.EO_btnRetnru.MouseBack = null;
            this.EO_btnRetnru.Name = "EO_btnRetnru";
            this.EO_btnRetnru.NormlBack = null;
            this.EO_btnRetnru.Size = new System.Drawing.Size(69, 38);
            this.EO_btnRetnru.TabIndex = 8;
            this.EO_btnRetnru.Text = "返回";
            this.EO_btnRetnru.UseVisualStyleBackColor = false;
            this.EO_btnRetnru.Click += new System.EventHandler(this.EO_btnRetnru_Click);
            // 
            // ExcelOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.EO_btnRetnru);
            this.Controls.Add(this.btn_Y);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBx_fileName);
            this.Controls.Add(this.tBx_fileadd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExcelOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelOutput";
            this.Load += new System.EventHandler(this.ExcelOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBx_fileadd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tBx_fileName;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton btn_preview;
        private CCWin.SkinControl.SkinButton btn_Y;
        private CCWin.SkinControl.SkinButton EO_btnRetnru;
    }
}