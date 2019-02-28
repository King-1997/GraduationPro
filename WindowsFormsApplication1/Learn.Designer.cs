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
            this.L_lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.L_lblClassesName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_timecount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fLP_filesPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_learningState = new System.Windows.Forms.Label();
            this.lbl_learnTime = new System.Windows.Forms.Label();
            this.btn_preview = new CCWin.SkinControl.SkinButton();
            this.L_btnExam = new CCWin.SkinControl.SkinButton();
            this.L_btnReturn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // L_lblTime
            // 
            this.L_lblTime.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.L_lblTime.Location = new System.Drawing.Point(764, 31);
            this.L_lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblTime.Name = "L_lblTime";
            this.L_lblTime.Size = new System.Drawing.Size(229, 32);
            this.L_lblTime.TabIndex = 1;
            this.L_lblTime.Text = "yyyy/MM/dd HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // L_lblClassesName
            // 
            this.L_lblClassesName.AutoSize = true;
            this.L_lblClassesName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.L_lblClassesName.Location = new System.Drawing.Point(59, 81);
            this.L_lblClassesName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_lblClassesName.Name = "L_lblClassesName";
            this.L_lblClassesName.Size = new System.Drawing.Size(56, 17);
            this.L_lblClassesName.TabIndex = 2;
            this.L_lblClassesName.Text = "课程名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(194, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "课程学分：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "课程附件：";
            // 
            // lbl_timecount
            // 
            this.lbl_timecount.AutoSize = true;
            this.lbl_timecount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl_timecount.Location = new System.Drawing.Point(891, 63);
            this.lbl_timecount.Name = "lbl_timecount";
            this.lbl_timecount.Size = new System.Drawing.Size(44, 17);
            this.lbl_timecount.TabIndex = 7;
            this.lbl_timecount.Text = "计时器";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fLP_filesPreview
            // 
            this.fLP_filesPreview.AutoScroll = true;
            this.fLP_filesPreview.Location = new System.Drawing.Point(77, 194);
            this.fLP_filesPreview.Margin = new System.Windows.Forms.Padding(5);
            this.fLP_filesPreview.Name = "fLP_filesPreview";
            this.fLP_filesPreview.Size = new System.Drawing.Size(853, 351);
            this.fLP_filesPreview.TabIndex = 10;
            // 
            // lbl_learningState
            // 
            this.lbl_learningState.AutoSize = true;
            this.lbl_learningState.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl_learningState.Location = new System.Drawing.Point(877, 89);
            this.lbl_learningState.Name = "lbl_learningState";
            this.lbl_learningState.Size = new System.Drawing.Size(56, 17);
            this.lbl_learningState.TabIndex = 12;
            this.lbl_learningState.Text = "正在学习";
            // 
            // lbl_learnTime
            // 
            this.lbl_learnTime.AutoSize = true;
            this.lbl_learnTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl_learnTime.Location = new System.Drawing.Point(894, 108);
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
            this.btn_preview.Location = new System.Drawing.Point(197, 117);
            this.btn_preview.MouseBack = null;
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.NormlBack = null;
            this.btn_preview.Size = new System.Drawing.Size(75, 31);
            this.btn_preview.TabIndex = 14;
            this.btn_preview.Text = "浏览";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // L_btnExam
            // 
            this.L_btnExam.BackColor = System.Drawing.Color.Transparent;
            this.L_btnExam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.L_btnExam.DownBack = null;
            this.L_btnExam.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.L_btnExam.Location = new System.Drawing.Point(715, 633);
            this.L_btnExam.MouseBack = null;
            this.L_btnExam.Name = "L_btnExam";
            this.L_btnExam.NormlBack = null;
            this.L_btnExam.Size = new System.Drawing.Size(103, 49);
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
            this.L_btnReturn.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.L_btnReturn.Location = new System.Drawing.Point(845, 633);
            this.L_btnReturn.MouseBack = null;
            this.L_btnReturn.Name = "L_btnReturn";
            this.L_btnReturn.NormlBack = null;
            this.L_btnReturn.Size = new System.Drawing.Size(103, 49);
            this.L_btnReturn.TabIndex = 16;
            this.L_btnReturn.Text = "返回";
            this.L_btnReturn.UseVisualStyleBackColor = false;
            this.L_btnReturn.Click += new System.EventHandler(this.L_btnReturn_Click);
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.L_btnReturn);
            this.Controls.Add(this.L_btnExam);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.lbl_learnTime);
            this.Controls.Add(this.lbl_learningState);
            this.Controls.Add(this.fLP_filesPreview);
            this.Controls.Add(this.lbl_timecount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_lblClassesName);
            this.Controls.Add(this.L_lblTime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Learn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学习中心";
            this.Load += new System.EventHandler(this.Learn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label L_lblClassesName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_timecount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel fLP_filesPreview;
        private System.Windows.Forms.Label lbl_learningState;
        private System.Windows.Forms.Label lbl_learnTime;
        private CCWin.SkinControl.SkinButton btn_preview;
        private CCWin.SkinControl.SkinButton L_btnExam;
        private CCWin.SkinControl.SkinButton L_btnReturn;
    }
}