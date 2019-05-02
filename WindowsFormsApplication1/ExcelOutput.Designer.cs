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
            this.eo_tBx_fileadd = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.eo_tBx_fileName = new System.Windows.Forms.TextBox();
            this.eo_lbl_fileName = new System.Windows.Forms.Label();
            this.eo_btn_preview = new CCWin.SkinControl.SkinButton();
            this.btn_Y = new CCWin.SkinControl.SkinButton();
            this.EO_btnRetnru = new CCWin.SkinControl.SkinButton();
            this.eo_lbl_group = new System.Windows.Forms.Label();
            this.eo_ccb_group = new CCWin.SkinControl.SkinComboBox();
            this.eo_lbl_tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eo_tBx_fileadd
            // 
            this.eo_tBx_fileadd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.eo_tBx_fileadd.Location = new System.Drawing.Point(255, 273);
            this.eo_tBx_fileadd.Margin = new System.Windows.Forms.Padding(2);
            this.eo_tBx_fileadd.Name = "eo_tBx_fileadd";
            this.eo_tBx_fileadd.ReadOnly = true;
            this.eo_tBx_fileadd.Size = new System.Drawing.Size(293, 23);
            this.eo_tBx_fileadd.TabIndex = 0;
            // 
            // eo_tBx_fileName
            // 
            this.eo_tBx_fileName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.eo_tBx_fileName.Location = new System.Drawing.Point(255, 346);
            this.eo_tBx_fileName.Margin = new System.Windows.Forms.Padding(2);
            this.eo_tBx_fileName.Name = "eo_tBx_fileName";
            this.eo_tBx_fileName.Size = new System.Drawing.Size(293, 23);
            this.eo_tBx_fileName.TabIndex = 3;
            this.eo_tBx_fileName.Text = "请输入文件名：";
            this.eo_tBx_fileName.Click += new System.EventHandler(this.tBx_fileName_Click);
            // 
            // eo_lbl_fileName
            // 
            this.eo_lbl_fileName.AutoSize = true;
            this.eo_lbl_fileName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.eo_lbl_fileName.Location = new System.Drawing.Point(166, 348);
            this.eo_lbl_fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eo_lbl_fileName.Name = "eo_lbl_fileName";
            this.eo_lbl_fileName.Size = new System.Drawing.Size(74, 21);
            this.eo_lbl_fileName.TabIndex = 4;
            this.eo_lbl_fileName.Text = "文件名：";
            // 
            // eo_btn_preview
            // 
            this.eo_btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.eo_btn_preview.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.eo_btn_preview.DownBack = null;
            this.eo_btn_preview.Location = new System.Drawing.Point(163, 264);
            this.eo_btn_preview.MouseBack = null;
            this.eo_btn_preview.Name = "eo_btn_preview";
            this.eo_btn_preview.NormlBack = null;
            this.eo_btn_preview.Size = new System.Drawing.Size(69, 38);
            this.eo_btn_preview.TabIndex = 6;
            this.eo_btn_preview.Text = "浏览";
            this.eo_btn_preview.UseVisualStyleBackColor = false;
            this.eo_btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
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
            // eo_lbl_group
            // 
            this.eo_lbl_group.AutoSize = true;
            this.eo_lbl_group.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.eo_lbl_group.Location = new System.Drawing.Point(95, 82);
            this.eo_lbl_group.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eo_lbl_group.Name = "eo_lbl_group";
            this.eo_lbl_group.Size = new System.Drawing.Size(74, 21);
            this.eo_lbl_group.TabIndex = 9;
            this.eo_lbl_group.Text = "按部门：";
            // 
            // eo_ccb_group
            // 
            this.eo_ccb_group.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eo_ccb_group.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eo_ccb_group.FormattingEnabled = true;
            this.eo_ccb_group.Location = new System.Drawing.Point(174, 80);
            this.eo_ccb_group.Name = "eo_ccb_group";
            this.eo_ccb_group.Size = new System.Drawing.Size(138, 27);
            this.eo_ccb_group.TabIndex = 12;
            this.eo_ccb_group.WaterText = "";
            // 
            // eo_lbl_tip
            // 
            this.eo_lbl_tip.AutoSize = true;
            this.eo_lbl_tip.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.eo_lbl_tip.ForeColor = System.Drawing.Color.IndianRed;
            this.eo_lbl_tip.Location = new System.Drawing.Point(252, 310);
            this.eo_lbl_tip.Name = "eo_lbl_tip";
            this.eo_lbl_tip.Size = new System.Drawing.Size(417, 17);
            this.eo_lbl_tip.TabIndex = 13;
            this.eo_lbl_tip.Text = "温馨提示：最好选择C盘以外的路径，因为有些电脑C盘没有更改数据的权限~";
            // 
            // ExcelOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.eo_lbl_tip);
            this.Controls.Add(this.eo_ccb_group);
            this.Controls.Add(this.eo_lbl_group);
            this.Controls.Add(this.EO_btnRetnru);
            this.Controls.Add(this.btn_Y);
            this.Controls.Add(this.eo_btn_preview);
            this.Controls.Add(this.eo_lbl_fileName);
            this.Controls.Add(this.eo_tBx_fileName);
            this.Controls.Add(this.eo_tBx_fileadd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExcelOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelOutput";
            this.Load += new System.EventHandler(this.ExcelOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eo_tBx_fileadd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox eo_tBx_fileName;
        private System.Windows.Forms.Label eo_lbl_fileName;
        private CCWin.SkinControl.SkinButton eo_btn_preview;
        private CCWin.SkinControl.SkinButton btn_Y;
        private CCWin.SkinControl.SkinButton EO_btnRetnru;
        private System.Windows.Forms.Label eo_lbl_group;
        private CCWin.SkinControl.SkinComboBox eo_ccb_group;
        private System.Windows.Forms.Label eo_lbl_tip;
    }
}