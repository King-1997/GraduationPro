namespace WindowsFormsApplication1
{
    partial class Learn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learn));
            this.L_lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.L_lblClasses_Name = new System.Windows.Forms.Label();
            this.L_lblClasses_Credit = new System.Windows.Forms.Label();
            this.L_lblClasses_File = new System.Windows.Forms.Label();
            this.lbl_timecount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_learningState = new System.Windows.Forms.Label();
            this.lbl_learnTime = new System.Windows.Forms.Label();
            this.btn_preview = new CCWin.SkinControl.SkinButton();
            this.L_btnExam = new CCWin.SkinControl.SkinButton();
            this.L_btnReturn = new CCWin.SkinControl.SkinButton();
            this.L_lblClassesCredit = new System.Windows.Forms.Label();
            this.L_lblClassesName = new System.Windows.Forms.Label();
            this.L_lblClassesFile = new System.Windows.Forms.Label();
            this.L_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.L_lblClasses_Annex = new System.Windows.Forms.Label();
            this.L_lblClassesAnnex = new System.Windows.Forms.Label();
            this.btn_download = new CCWin.SkinControl.SkinButton();
            this.L_progressBar = new System.Windows.Forms.ProgressBar();
            this.L_lbl_pcb = new System.Windows.Forms.Label();
            this.L_btn_discuss = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.L_player)).BeginInit();
            this.SuspendLayout();
            // 
            // L_lblTime
            // 
            this.L_lblTime.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.L_lblTime.Location = new System.Drawing.Point(764, 31);
            this.L_lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblTime.Name = "L_lblTime";
            this.L_lblTime.Size = new System.Drawing.Size(174, 32);
            this.L_lblTime.TabIndex = 1;
            this.L_lblTime.Text = "YYYY/MM/dd HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // L_lblClasses_Name
            // 
            this.L_lblClasses_Name.AutoSize = true;
            this.L_lblClasses_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClasses_Name.Location = new System.Drawing.Point(59, 81);
            this.L_lblClasses_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClasses_Name.Name = "L_lblClasses_Name";
            this.L_lblClasses_Name.Size = new System.Drawing.Size(56, 17);
            this.L_lblClasses_Name.TabIndex = 2;
            this.L_lblClasses_Name.Text = "课程名：";
            // 
            // L_lblClasses_Credit
            // 
            this.L_lblClasses_Credit.AutoSize = true;
            this.L_lblClasses_Credit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClasses_Credit.Location = new System.Drawing.Point(263, 81);
            this.L_lblClasses_Credit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClasses_Credit.Name = "L_lblClasses_Credit";
            this.L_lblClasses_Credit.Size = new System.Drawing.Size(68, 17);
            this.L_lblClasses_Credit.TabIndex = 4;
            this.L_lblClasses_Credit.Text = "课程学分：";
            // 
            // L_lblClasses_File
            // 
            this.L_lblClasses_File.AutoSize = true;
            this.L_lblClasses_File.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClasses_File.Location = new System.Drawing.Point(58, 123);
            this.L_lblClasses_File.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClasses_File.Name = "L_lblClasses_File";
            this.L_lblClasses_File.Size = new System.Drawing.Size(68, 17);
            this.L_lblClasses_File.TabIndex = 5;
            this.L_lblClasses_File.Text = "课程文件：";
            // 
            // lbl_timecount
            // 
            this.lbl_timecount.AutoSize = true;
            this.lbl_timecount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl_timecount.Location = new System.Drawing.Point(829, 63);
            this.lbl_timecount.Name = "lbl_timecount";
            this.lbl_timecount.Size = new System.Drawing.Size(44, 17);
            this.lbl_timecount.TabIndex = 7;
            this.lbl_timecount.Text = "计时器";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_learningState
            // 
            this.lbl_learningState.AutoSize = true;
            this.lbl_learningState.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl_learningState.Location = new System.Drawing.Point(824, 89);
            this.lbl_learningState.Name = "lbl_learningState";
            this.lbl_learningState.Size = new System.Drawing.Size(56, 17);
            this.lbl_learningState.TabIndex = 12;
            this.lbl_learningState.Text = "正在学习";
            // 
            // lbl_learnTime
            // 
            this.lbl_learnTime.AutoSize = true;
            this.lbl_learnTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl_learnTime.Location = new System.Drawing.Point(829, 113);
            this.lbl_learnTime.Name = "lbl_learnTime";
            this.lbl_learnTime.Size = new System.Drawing.Size(44, 17);
            this.lbl_learnTime.TabIndex = 13;
            this.lbl_learnTime.Text = "计时器";
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_preview.DownBack = null;
            this.btn_preview.Location = new System.Drawing.Point(584, 123);
            this.btn_preview.MouseBack = null;
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.NormlBack = null;
            this.btn_preview.Size = new System.Drawing.Size(64, 31);
            this.btn_preview.TabIndex = 14;
            this.btn_preview.Text = "开始学习";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // L_btnExam
            // 
            this.L_btnExam.BackColor = System.Drawing.Color.Transparent;
            this.L_btnExam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.L_btnExam.DownBack = null;
            this.L_btnExam.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_btnExam.Location = new System.Drawing.Point(858, 670);
            this.L_btnExam.MouseBack = null;
            this.L_btnExam.Name = "L_btnExam";
            this.L_btnExam.NormlBack = null;
            this.L_btnExam.Size = new System.Drawing.Size(73, 37);
            this.L_btnExam.TabIndex = 15;
            this.L_btnExam.Text = "考试";
            this.L_btnExam.UseVisualStyleBackColor = false;
            this.L_btnExam.Click += new System.EventHandler(this.L_btnExam_Click);
            // 
            // L_btnReturn
            // 
            this.L_btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.L_btnReturn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.L_btnReturn.DownBack = null;
            this.L_btnReturn.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_btnReturn.Location = new System.Drawing.Point(937, 670);
            this.L_btnReturn.MouseBack = null;
            this.L_btnReturn.Name = "L_btnReturn";
            this.L_btnReturn.NormlBack = null;
            this.L_btnReturn.Size = new System.Drawing.Size(73, 37);
            this.L_btnReturn.TabIndex = 16;
            this.L_btnReturn.Text = "返回";
            this.L_btnReturn.UseVisualStyleBackColor = false;
            this.L_btnReturn.Click += new System.EventHandler(this.L_btnReturn_Click);
            // 
            // L_lblClassesCredit
            // 
            this.L_lblClassesCredit.AutoSize = true;
            this.L_lblClassesCredit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClassesCredit.Location = new System.Drawing.Point(356, 81);
            this.L_lblClassesCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClassesCredit.Name = "L_lblClassesCredit";
            this.L_lblClassesCredit.Size = new System.Drawing.Size(56, 17);
            this.L_lblClassesCredit.TabIndex = 17;
            this.L_lblClassesCredit.Text = "课程学分";
            // 
            // L_lblClassesName
            // 
            this.L_lblClassesName.AutoSize = true;
            this.L_lblClassesName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClassesName.Location = new System.Drawing.Point(148, 81);
            this.L_lblClassesName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClassesName.Name = "L_lblClassesName";
            this.L_lblClassesName.Size = new System.Drawing.Size(56, 17);
            this.L_lblClassesName.TabIndex = 18;
            this.L_lblClassesName.Text = "课程名：";
            // 
            // L_lblClassesFile
            // 
            this.L_lblClassesFile.AutoSize = true;
            this.L_lblClassesFile.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClassesFile.Location = new System.Drawing.Point(148, 123);
            this.L_lblClassesFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClassesFile.Name = "L_lblClassesFile";
            this.L_lblClassesFile.Size = new System.Drawing.Size(80, 17);
            this.L_lblClassesFile.TabIndex = 19;
            this.L_lblClassesFile.Text = "课程文件路径";
            // 
            // L_player
            // 
            this.L_player.Enabled = true;
            this.L_player.Location = new System.Drawing.Point(180, 224);
            this.L_player.Margin = new System.Windows.Forms.Padding(2);
            this.L_player.Name = "L_player";
            this.L_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("L_player.OcxState")));
            this.L_player.Size = new System.Drawing.Size(645, 439);
            this.L_player.TabIndex = 20;
            // 
            // L_lblClasses_Annex
            // 
            this.L_lblClasses_Annex.AutoSize = true;
            this.L_lblClasses_Annex.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClasses_Annex.Location = new System.Drawing.Point(59, 178);
            this.L_lblClasses_Annex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClasses_Annex.Name = "L_lblClasses_Annex";
            this.L_lblClasses_Annex.Size = new System.Drawing.Size(68, 17);
            this.L_lblClasses_Annex.TabIndex = 21;
            this.L_lblClasses_Annex.Text = "课程附件：";
            // 
            // L_lblClassesAnnex
            // 
            this.L_lblClassesAnnex.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClassesAnnex.Location = new System.Drawing.Point(148, 178);
            this.L_lblClassesAnnex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClassesAnnex.Name = "L_lblClassesAnnex";
            this.L_lblClassesAnnex.Size = new System.Drawing.Size(193, 17);
            this.L_lblClassesAnnex.TabIndex = 22;
            this.L_lblClassesAnnex.Text = "课程附件名";
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.Transparent;
            this.btn_download.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_download.DownBack = null;
            this.btn_download.Location = new System.Drawing.Point(359, 172);
            this.btn_download.MouseBack = null;
            this.btn_download.Name = "btn_download";
            this.btn_download.NormlBack = null;
            this.btn_download.Size = new System.Drawing.Size(53, 31);
            this.btn_download.TabIndex = 23;
            this.btn_download.Text = "下载";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // L_progressBar
            // 
            this.L_progressBar.Location = new System.Drawing.Point(445, 175);
            this.L_progressBar.Name = "L_progressBar";
            this.L_progressBar.Size = new System.Drawing.Size(114, 23);
            this.L_progressBar.TabIndex = 24;
            this.L_progressBar.Visible = false;
            // 
            // L_lbl_pcb
            // 
            this.L_lbl_pcb.AutoSize = true;
            this.L_lbl_pcb.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lbl_pcb.Location = new System.Drawing.Point(581, 179);
            this.L_lbl_pcb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lbl_pcb.Name = "L_lbl_pcb";
            this.L_lbl_pcb.Size = new System.Drawing.Size(68, 17);
            this.L_lbl_pcb.TabIndex = 25;
            this.L_lbl_pcb.Text = "进度条显示";
            this.L_lbl_pcb.Visible = false;
            // 
            // L_btn_discuss
            // 
            this.L_btn_discuss.BackColor = System.Drawing.Color.Transparent;
            this.L_btn_discuss.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.L_btn_discuss.DownBack = null;
            this.L_btn_discuss.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_btn_discuss.Location = new System.Drawing.Point(921, 442);
            this.L_btn_discuss.MouseBack = null;
            this.L_btn_discuss.Name = "L_btn_discuss";
            this.L_btn_discuss.NormlBack = null;
            this.L_btn_discuss.Size = new System.Drawing.Size(73, 37);
            this.L_btn_discuss.TabIndex = 26;
            this.L_btn_discuss.Text = "讨论";
            this.L_btn_discuss.UseVisualStyleBackColor = false;
            this.L_btn_discuss.Click += new System.EventHandler(this.L_btn_discuss_Click);
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 727);
            this.Controls.Add(this.L_btn_discuss);
            this.Controls.Add(this.L_lbl_pcb);
            this.Controls.Add(this.L_progressBar);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.L_lblClassesAnnex);
            this.Controls.Add(this.L_lblClasses_Annex);
            this.Controls.Add(this.L_player);
            this.Controls.Add(this.L_lblClassesFile);
            this.Controls.Add(this.L_lblClassesName);
            this.Controls.Add(this.L_lblClassesCredit);
            this.Controls.Add(this.L_btnReturn);
            this.Controls.Add(this.L_btnExam);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.lbl_learnTime);
            this.Controls.Add(this.lbl_learningState);
            this.Controls.Add(this.lbl_timecount);
            this.Controls.Add(this.L_lblClasses_File);
            this.Controls.Add(this.L_lblClasses_Credit);
            this.Controls.Add(this.L_lblClasses_Name);
            this.Controls.Add(this.L_lblTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Learn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学习中心";
            this.Load += new System.EventHandler(this.Learn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label L_lblClasses_Name;
        private System.Windows.Forms.Label L_lblClasses_Credit;
        private System.Windows.Forms.Label L_lblClasses_File;
        private System.Windows.Forms.Label lbl_timecount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_learningState;
        private System.Windows.Forms.Label lbl_learnTime;
        private CCWin.SkinControl.SkinButton btn_preview;
        private CCWin.SkinControl.SkinButton L_btnExam;
        private CCWin.SkinControl.SkinButton L_btnReturn;
        private System.Windows.Forms.Label L_lblClassesCredit;
        private System.Windows.Forms.Label L_lblClassesName;
        private System.Windows.Forms.Label L_lblClassesFile;
        private AxWMPLib.AxWindowsMediaPlayer L_player;
        private System.Windows.Forms.Label L_lblClasses_Annex;
        private System.Windows.Forms.Label L_lblClassesAnnex;
        private CCWin.SkinControl.SkinButton btn_download;
        private System.Windows.Forms.ProgressBar L_progressBar;
        private System.Windows.Forms.Label L_lbl_pcb;
        private CCWin.SkinControl.SkinButton L_btn_discuss;
    }
}