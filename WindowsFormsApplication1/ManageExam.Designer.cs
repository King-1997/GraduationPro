namespace WindowsFormsApplication1
{
    partial class ManageExam
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
            this.me_btn_back = new CCWin.SkinControl.SkinButton();
            this.me_lbl_End_Time = new System.Windows.Forms.Label();
            this.me_lbl_Start_Time = new System.Windows.Forms.Label();
            this.me_lbl_Exam_Name = new System.Windows.Forms.Label();
            this.ep_btn_All_Peroid = new CCWin.SkinControl.SkinButton();
            this.me_flp_q_info = new System.Windows.Forms.FlowLayoutPanel();
            this.me_btn_addQues = new CCWin.SkinControl.SkinButton();
            this.ep_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.me_lbl_EndTime = new System.Windows.Forms.Label();
            this.me_lbl_StartTime = new System.Windows.Forms.Label();
            this.me_lbl_ExamName = new System.Windows.Forms.Label();
            this.me_tbx_Pass_Goal = new System.Windows.Forms.TextBox();
            this.me_lbl_Pass_Goal = new System.Windows.Forms.Label();
            this.me_lbl_totalGoal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // me_btn_back
            // 
            this.me_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.me_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.me_btn_back.DownBack = null;
            this.me_btn_back.Location = new System.Drawing.Point(628, 464);
            this.me_btn_back.MouseBack = null;
            this.me_btn_back.Name = "me_btn_back";
            this.me_btn_back.NormlBack = null;
            this.me_btn_back.Size = new System.Drawing.Size(70, 34);
            this.me_btn_back.TabIndex = 22;
            this.me_btn_back.Text = "返回";
            this.me_btn_back.UseVisualStyleBackColor = false;
            this.me_btn_back.Click += new System.EventHandler(this.me_btn_back_Click);
            // 
            // me_lbl_End_Time
            // 
            this.me_lbl_End_Time.AutoSize = true;
            this.me_lbl_End_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_End_Time.Location = new System.Drawing.Point(56, 154);
            this.me_lbl_End_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_End_Time.Name = "me_lbl_End_Time";
            this.me_lbl_End_Time.Size = new System.Drawing.Size(68, 17);
            this.me_lbl_End_Time.TabIndex = 53;
            this.me_lbl_End_Time.Text = "截止时间：";
            // 
            // me_lbl_Start_Time
            // 
            this.me_lbl_Start_Time.AutoSize = true;
            this.me_lbl_Start_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_Start_Time.Location = new System.Drawing.Point(57, 110);
            this.me_lbl_Start_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_Start_Time.Name = "me_lbl_Start_Time";
            this.me_lbl_Start_Time.Size = new System.Drawing.Size(68, 17);
            this.me_lbl_Start_Time.TabIndex = 51;
            this.me_lbl_Start_Time.Text = "开始时间：";
            // 
            // me_lbl_Exam_Name
            // 
            this.me_lbl_Exam_Name.AutoSize = true;
            this.me_lbl_Exam_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_Exam_Name.Location = new System.Drawing.Point(67, 62);
            this.me_lbl_Exam_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_Exam_Name.Name = "me_lbl_Exam_Name";
            this.me_lbl_Exam_Name.Size = new System.Drawing.Size(56, 17);
            this.me_lbl_Exam_Name.TabIndex = 49;
            this.me_lbl_Exam_Name.Text = "测试名：";
            // 
            // ep_btn_All_Peroid
            // 
            this.ep_btn_All_Peroid.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_All_Peroid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_All_Peroid.DownBack = null;
            this.ep_btn_All_Peroid.Location = new System.Drawing.Point(511, 147);
            this.ep_btn_All_Peroid.MouseBack = null;
            this.ep_btn_All_Peroid.Name = "ep_btn_All_Peroid";
            this.ep_btn_All_Peroid.NormlBack = null;
            this.ep_btn_All_Peroid.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_All_Peroid.TabIndex = 57;
            this.ep_btn_All_Peroid.Text = "所有试题";
            this.ep_btn_All_Peroid.UseVisualStyleBackColor = false;
            this.ep_btn_All_Peroid.Click += new System.EventHandler(this.ep_btn_All_Peroid_Click);
            // 
            // me_flp_q_info
            // 
            this.me_flp_q_info.AutoScroll = true;
            this.me_flp_q_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.me_flp_q_info.Location = new System.Drawing.Point(58, 191);
            this.me_flp_q_info.Name = "me_flp_q_info";
            this.me_flp_q_info.Size = new System.Drawing.Size(612, 220);
            this.me_flp_q_info.TabIndex = 56;
            // 
            // me_btn_addQues
            // 
            this.me_btn_addQues.BackColor = System.Drawing.Color.Transparent;
            this.me_btn_addQues.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.me_btn_addQues.DownBack = null;
            this.me_btn_addQues.Location = new System.Drawing.Point(417, 147);
            this.me_btn_addQues.MouseBack = null;
            this.me_btn_addQues.Name = "me_btn_addQues";
            this.me_btn_addQues.NormlBack = null;
            this.me_btn_addQues.Size = new System.Drawing.Size(70, 30);
            this.me_btn_addQues.TabIndex = 55;
            this.me_btn_addQues.Text = "添加试题";
            this.me_btn_addQues.UseVisualStyleBackColor = false;
            this.me_btn_addQues.Click += new System.EventHandler(this.me_btn_addQues_Click);
            // 
            // ep_btn_confirm
            // 
            this.ep_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_confirm.DownBack = null;
            this.ep_btn_confirm.Location = new System.Drawing.Point(540, 464);
            this.ep_btn_confirm.MouseBack = null;
            this.ep_btn_confirm.Name = "ep_btn_confirm";
            this.ep_btn_confirm.NormlBack = null;
            this.ep_btn_confirm.Size = new System.Drawing.Size(70, 34);
            this.ep_btn_confirm.TabIndex = 58;
            this.ep_btn_confirm.Text = "确定";
            this.ep_btn_confirm.UseVisualStyleBackColor = false;
            this.ep_btn_confirm.Click += new System.EventHandler(this.ep_btn_confirm_Click);
            // 
            // me_lbl_EndTime
            // 
            this.me_lbl_EndTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.me_lbl_EndTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_EndTime.Location = new System.Drawing.Point(148, 147);
            this.me_lbl_EndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_EndTime.Name = "me_lbl_EndTime";
            this.me_lbl_EndTime.Size = new System.Drawing.Size(212, 30);
            this.me_lbl_EndTime.TabIndex = 61;
            this.me_lbl_EndTime.Text = "结束时间";
            // 
            // me_lbl_StartTime
            // 
            this.me_lbl_StartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.me_lbl_StartTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_StartTime.Location = new System.Drawing.Point(148, 102);
            this.me_lbl_StartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_StartTime.Name = "me_lbl_StartTime";
            this.me_lbl_StartTime.Size = new System.Drawing.Size(212, 30);
            this.me_lbl_StartTime.TabIndex = 60;
            this.me_lbl_StartTime.Text = "开始时间";
            // 
            // me_lbl_ExamName
            // 
            this.me_lbl_ExamName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.me_lbl_ExamName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_ExamName.Location = new System.Drawing.Point(148, 56);
            this.me_lbl_ExamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_ExamName.Name = "me_lbl_ExamName";
            this.me_lbl_ExamName.Size = new System.Drawing.Size(212, 30);
            this.me_lbl_ExamName.TabIndex = 59;
            this.me_lbl_ExamName.Text = "考试名";
            // 
            // me_tbx_Pass_Goal
            // 
            this.me_tbx_Pass_Goal.BackColor = System.Drawing.Color.SkyBlue;
            this.me_tbx_Pass_Goal.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.me_tbx_Pass_Goal.Location = new System.Drawing.Point(144, 434);
            this.me_tbx_Pass_Goal.Margin = new System.Windows.Forms.Padding(2);
            this.me_tbx_Pass_Goal.Name = "me_tbx_Pass_Goal";
            this.me_tbx_Pass_Goal.Size = new System.Drawing.Size(165, 29);
            this.me_tbx_Pass_Goal.TabIndex = 63;
            // 
            // me_lbl_Pass_Goal
            // 
            this.me_lbl_Pass_Goal.AutoSize = true;
            this.me_lbl_Pass_Goal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_Pass_Goal.Location = new System.Drawing.Point(70, 441);
            this.me_lbl_Pass_Goal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_Pass_Goal.Name = "me_lbl_Pass_Goal";
            this.me_lbl_Pass_Goal.Size = new System.Drawing.Size(68, 17);
            this.me_lbl_Pass_Goal.TabIndex = 62;
            this.me_lbl_Pass_Goal.Text = "通过分数：";
            // 
            // me_lbl_totalGoal
            // 
            this.me_lbl_totalGoal.AutoSize = true;
            this.me_lbl_totalGoal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.me_lbl_totalGoal.ForeColor = System.Drawing.Color.IndianRed;
            this.me_lbl_totalGoal.Location = new System.Drawing.Point(316, 440);
            this.me_lbl_totalGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.me_lbl_totalGoal.Name = "me_lbl_totalGoal";
            this.me_lbl_totalGoal.Size = new System.Drawing.Size(80, 17);
            this.me_lbl_totalGoal.TabIndex = 64;
            this.me_lbl_totalGoal.Text = "当前总分为：";
            // 
            // ManageExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 519);
            this.Controls.Add(this.me_lbl_totalGoal);
            this.Controls.Add(this.me_tbx_Pass_Goal);
            this.Controls.Add(this.me_lbl_Pass_Goal);
            this.Controls.Add(this.me_lbl_EndTime);
            this.Controls.Add(this.me_lbl_StartTime);
            this.Controls.Add(this.me_lbl_ExamName);
            this.Controls.Add(this.ep_btn_confirm);
            this.Controls.Add(this.ep_btn_All_Peroid);
            this.Controls.Add(this.me_flp_q_info);
            this.Controls.Add(this.me_btn_addQues);
            this.Controls.Add(this.me_lbl_End_Time);
            this.Controls.Add(this.me_lbl_Start_Time);
            this.Controls.Add(this.me_lbl_Exam_Name);
            this.Controls.Add(this.me_btn_back);
            this.Name = "ManageExam";
            this.Text = "测试详细信息";
            this.Load += new System.EventHandler(this.ManageExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton me_btn_back;
        private System.Windows.Forms.Label me_lbl_End_Time;
        private System.Windows.Forms.Label me_lbl_Start_Time;
        private System.Windows.Forms.Label me_lbl_Exam_Name;
        private CCWin.SkinControl.SkinButton ep_btn_All_Peroid;
        private System.Windows.Forms.FlowLayoutPanel me_flp_q_info;
        private CCWin.SkinControl.SkinButton me_btn_addQues;
        private CCWin.SkinControl.SkinButton ep_btn_confirm;
        private System.Windows.Forms.Label me_lbl_EndTime;
        private System.Windows.Forms.Label me_lbl_StartTime;
        private System.Windows.Forms.Label me_lbl_ExamName;
        private System.Windows.Forms.TextBox me_tbx_Pass_Goal;
        private System.Windows.Forms.Label me_lbl_Pass_Goal;
        private System.Windows.Forms.Label me_lbl_totalGoal;
    }
}