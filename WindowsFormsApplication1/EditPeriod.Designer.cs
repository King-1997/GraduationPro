namespace WindowsFormsApplication1
{
    partial class EditPeriod
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
            this.ep_lbl_Plan_Name = new System.Windows.Forms.Label();
            this.ep_lbl_Plan_Summary = new System.Windows.Forms.Label();
            this.ep_tBx_Head_Summary = new System.Windows.Forms.TextBox();
            this.ep_btn_addPeroid = new CCWin.SkinControl.SkinButton();
            this.ep_flp_Lines_Info = new System.Windows.Forms.FlowLayoutPanel();
            this.ep_btn_back = new CCWin.SkinControl.SkinButton();
            this.ep_lbl_Emp_Type = new System.Windows.Forms.Label();
            this.ep_tBx_Emp_type = new System.Windows.Forms.TextBox();
            this.ep_tBx_Plan_Name = new System.Windows.Forms.TextBox();
            this.ep_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.ep_lbl_Period_Name = new System.Windows.Forms.Label();
            this.ep_dtp_Start_Time = new System.Windows.Forms.DateTimePicker();
            this.ep_lbl_Start_Time = new System.Windows.Forms.Label();
            this.ep_lbl_End_Time = new System.Windows.Forms.Label();
            this.ep_dtp_End_Time = new System.Windows.Forms.DateTimePicker();
            this.ep_btn_addClass = new CCWin.SkinControl.SkinButton();
            this.ep_tBx_Period_Name = new System.Windows.Forms.TextBox();
            this.ep_btn_addExam = new CCWin.SkinControl.SkinButton();
            this.ep_lbl_Class_Name = new System.Windows.Forms.Label();
            this.ep_lbl_Exam_Name = new System.Windows.Forms.Label();
            this.ep_btn_All_Peroid = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // ep_lbl_Plan_Name
            // 
            this.ep_lbl_Plan_Name.AutoSize = true;
            this.ep_lbl_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Plan_Name.Location = new System.Drawing.Point(43, 52);
            this.ep_lbl_Plan_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Plan_Name.Name = "ep_lbl_Plan_Name";
            this.ep_lbl_Plan_Name.Size = new System.Drawing.Size(80, 17);
            this.ep_lbl_Plan_Name.TabIndex = 3;
            this.ep_lbl_Plan_Name.Text = "学习计划名：";
            // 
            // ep_lbl_Plan_Summary
            // 
            this.ep_lbl_Plan_Summary.AutoSize = true;
            this.ep_lbl_Plan_Summary.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Plan_Summary.Location = new System.Drawing.Point(43, 123);
            this.ep_lbl_Plan_Summary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Plan_Summary.Name = "ep_lbl_Plan_Summary";
            this.ep_lbl_Plan_Summary.Size = new System.Drawing.Size(92, 17);
            this.ep_lbl_Plan_Summary.TabIndex = 5;
            this.ep_lbl_Plan_Summary.Text = "学习计划简介：";
            // 
            // ep_tBx_Head_Summary
            // 
            this.ep_tBx_Head_Summary.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Head_Summary.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Head_Summary.Location = new System.Drawing.Point(141, 93);
            this.ep_tBx_Head_Summary.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Head_Summary.Multiline = true;
            this.ep_tBx_Head_Summary.Name = "ep_tBx_Head_Summary";
            this.ep_tBx_Head_Summary.ReadOnly = true;
            this.ep_tBx_Head_Summary.Size = new System.Drawing.Size(350, 78);
            this.ep_tBx_Head_Summary.TabIndex = 11;
            // 
            // ep_btn_addPeroid
            // 
            this.ep_btn_addPeroid.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_addPeroid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_addPeroid.DownBack = null;
            this.ep_btn_addPeroid.Location = new System.Drawing.Point(461, 194);
            this.ep_btn_addPeroid.MouseBack = null;
            this.ep_btn_addPeroid.Name = "ep_btn_addPeroid";
            this.ep_btn_addPeroid.NormlBack = null;
            this.ep_btn_addPeroid.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_addPeroid.TabIndex = 25;
            this.ep_btn_addPeroid.Text = "添加阶段";
            this.ep_btn_addPeroid.UseVisualStyleBackColor = false;
            this.ep_btn_addPeroid.Click += new System.EventHandler(this.ep_btn_addPeroid_Click);
            // 
            // ep_flp_Lines_Info
            // 
            this.ep_flp_Lines_Info.AutoScroll = true;
            this.ep_flp_Lines_Info.Location = new System.Drawing.Point(46, 238);
            this.ep_flp_Lines_Info.Name = "ep_flp_Lines_Info";
            this.ep_flp_Lines_Info.Size = new System.Drawing.Size(773, 160);
            this.ep_flp_Lines_Info.TabIndex = 26;
            // 
            // ep_btn_back
            // 
            this.ep_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_back.DownBack = null;
            this.ep_btn_back.Location = new System.Drawing.Point(749, 538);
            this.ep_btn_back.MouseBack = null;
            this.ep_btn_back.Name = "ep_btn_back";
            this.ep_btn_back.NormlBack = null;
            this.ep_btn_back.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_back.TabIndex = 27;
            this.ep_btn_back.Text = "返回";
            this.ep_btn_back.UseVisualStyleBackColor = false;
            this.ep_btn_back.Click += new System.EventHandler(this.ep_btn_back_Click);
            // 
            // ep_lbl_Emp_Type
            // 
            this.ep_lbl_Emp_Type.AutoSize = true;
            this.ep_lbl_Emp_Type.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Emp_Type.Location = new System.Drawing.Point(43, 200);
            this.ep_lbl_Emp_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Emp_Type.Name = "ep_lbl_Emp_Type";
            this.ep_lbl_Emp_Type.Size = new System.Drawing.Size(92, 17);
            this.ep_lbl_Emp_Type.TabIndex = 28;
            this.ep_lbl_Emp_Type.Text = "针对员工类型：";
            // 
            // ep_tBx_Emp_type
            // 
            this.ep_tBx_Emp_type.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Emp_type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Emp_type.Location = new System.Drawing.Point(141, 193);
            this.ep_tBx_Emp_type.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Emp_type.Name = "ep_tBx_Emp_type";
            this.ep_tBx_Emp_type.ReadOnly = true;
            this.ep_tBx_Emp_type.Size = new System.Drawing.Size(219, 29);
            this.ep_tBx_Emp_type.TabIndex = 29;
            // 
            // ep_tBx_Plan_Name
            // 
            this.ep_tBx_Plan_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Plan_Name.Location = new System.Drawing.Point(141, 45);
            this.ep_tBx_Plan_Name.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Plan_Name.Name = "ep_tBx_Plan_Name";
            this.ep_tBx_Plan_Name.ReadOnly = true;
            this.ep_tBx_Plan_Name.Size = new System.Drawing.Size(219, 29);
            this.ep_tBx_Plan_Name.TabIndex = 30;
            // 
            // ep_btn_confirm
            // 
            this.ep_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_confirm.DownBack = null;
            this.ep_btn_confirm.Location = new System.Drawing.Point(664, 538);
            this.ep_btn_confirm.MouseBack = null;
            this.ep_btn_confirm.Name = "ep_btn_confirm";
            this.ep_btn_confirm.NormlBack = null;
            this.ep_btn_confirm.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_confirm.TabIndex = 31;
            this.ep_btn_confirm.Text = "确定";
            this.ep_btn_confirm.UseVisualStyleBackColor = false;
            this.ep_btn_confirm.Click += new System.EventHandler(this.ep_btn_confirm_Click);
            // 
            // ep_lbl_Period_Name
            // 
            this.ep_lbl_Period_Name.AutoSize = true;
            this.ep_lbl_Period_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Period_Name.Location = new System.Drawing.Point(65, 425);
            this.ep_lbl_Period_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Period_Name.Name = "ep_lbl_Period_Name";
            this.ep_lbl_Period_Name.Size = new System.Drawing.Size(56, 17);
            this.ep_lbl_Period_Name.TabIndex = 32;
            this.ep_lbl_Period_Name.Text = "阶段名：";
            // 
            // ep_dtp_Start_Time
            // 
            this.ep_dtp_Start_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_dtp_Start_Time.Location = new System.Drawing.Point(130, 465);
            this.ep_dtp_Start_Time.Name = "ep_dtp_Start_Time";
            this.ep_dtp_Start_Time.Size = new System.Drawing.Size(144, 23);
            this.ep_dtp_Start_Time.TabIndex = 33;
            // 
            // ep_lbl_Start_Time
            // 
            this.ep_lbl_Start_Time.AutoSize = true;
            this.ep_lbl_Start_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Start_Time.Location = new System.Drawing.Point(55, 468);
            this.ep_lbl_Start_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Start_Time.Name = "ep_lbl_Start_Time";
            this.ep_lbl_Start_Time.Size = new System.Drawing.Size(68, 17);
            this.ep_lbl_Start_Time.TabIndex = 34;
            this.ep_lbl_Start_Time.Text = "开始时间：";
            // 
            // ep_lbl_End_Time
            // 
            this.ep_lbl_End_Time.AutoSize = true;
            this.ep_lbl_End_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_End_Time.Location = new System.Drawing.Point(285, 468);
            this.ep_lbl_End_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_End_Time.Name = "ep_lbl_End_Time";
            this.ep_lbl_End_Time.Size = new System.Drawing.Size(68, 17);
            this.ep_lbl_End_Time.TabIndex = 36;
            this.ep_lbl_End_Time.Text = "截止时间：";
            // 
            // ep_dtp_End_Time
            // 
            this.ep_dtp_End_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_dtp_End_Time.Location = new System.Drawing.Point(360, 465);
            this.ep_dtp_End_Time.Name = "ep_dtp_End_Time";
            this.ep_dtp_End_Time.Size = new System.Drawing.Size(144, 23);
            this.ep_dtp_End_Time.TabIndex = 35;
            // 
            // ep_btn_addClass
            // 
            this.ep_btn_addClass.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_addClass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_addClass.DownBack = null;
            this.ep_btn_addClass.Location = new System.Drawing.Point(308, 420);
            this.ep_btn_addClass.MouseBack = null;
            this.ep_btn_addClass.Name = "ep_btn_addClass";
            this.ep_btn_addClass.NormlBack = null;
            this.ep_btn_addClass.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_addClass.TabIndex = 37;
            this.ep_btn_addClass.Text = "添加课程";
            this.ep_btn_addClass.UseVisualStyleBackColor = false;
            this.ep_btn_addClass.Click += new System.EventHandler(this.ep_btn_addClass_Click);
            // 
            // ep_tBx_Period_Name
            // 
            this.ep_tBx_Period_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Period_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Period_Name.Location = new System.Drawing.Point(127, 421);
            this.ep_tBx_Period_Name.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Period_Name.Name = "ep_tBx_Period_Name";
            this.ep_tBx_Period_Name.Size = new System.Drawing.Size(155, 29);
            this.ep_tBx_Period_Name.TabIndex = 38;
            // 
            // ep_btn_addExam
            // 
            this.ep_btn_addExam.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_addExam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_addExam.DownBack = null;
            this.ep_btn_addExam.Location = new System.Drawing.Point(506, 421);
            this.ep_btn_addExam.MouseBack = null;
            this.ep_btn_addExam.Name = "ep_btn_addExam";
            this.ep_btn_addExam.NormlBack = null;
            this.ep_btn_addExam.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_addExam.TabIndex = 39;
            this.ep_btn_addExam.Text = "添加考试";
            this.ep_btn_addExam.UseVisualStyleBackColor = false;
            this.ep_btn_addExam.Click += new System.EventHandler(this.ep_btn_addExam_Click);
            // 
            // ep_lbl_Class_Name
            // 
            this.ep_lbl_Class_Name.AutoSize = true;
            this.ep_lbl_Class_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Class_Name.Location = new System.Drawing.Point(403, 426);
            this.ep_lbl_Class_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Class_Name.Name = "ep_lbl_Class_Name";
            this.ep_lbl_Class_Name.Size = new System.Drawing.Size(44, 17);
            this.ep_lbl_Class_Name.TabIndex = 40;
            this.ep_lbl_Class_Name.Text = "课程名";
            // 
            // ep_lbl_Exam_Name
            // 
            this.ep_lbl_Exam_Name.AutoSize = true;
            this.ep_lbl_Exam_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Exam_Name.Location = new System.Drawing.Point(602, 427);
            this.ep_lbl_Exam_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Exam_Name.Name = "ep_lbl_Exam_Name";
            this.ep_lbl_Exam_Name.Size = new System.Drawing.Size(44, 17);
            this.ep_lbl_Exam_Name.TabIndex = 41;
            this.ep_lbl_Exam_Name.Text = "试卷名";
            // 
            // ep_btn_All_Peroid
            // 
            this.ep_btn_All_Peroid.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_All_Peroid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_All_Peroid.DownBack = null;
            this.ep_btn_All_Peroid.Location = new System.Drawing.Point(555, 194);
            this.ep_btn_All_Peroid.MouseBack = null;
            this.ep_btn_All_Peroid.Name = "ep_btn_All_Peroid";
            this.ep_btn_All_Peroid.NormlBack = null;
            this.ep_btn_All_Peroid.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_All_Peroid.TabIndex = 42;
            this.ep_btn_All_Peroid.Text = "所有阶段";
            this.ep_btn_All_Peroid.UseVisualStyleBackColor = false;
            this.ep_btn_All_Peroid.Click += new System.EventHandler(this.ep_btn_All_Peroid_Click);
            // 
            // EditPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 598);
            this.Controls.Add(this.ep_btn_All_Peroid);
            this.Controls.Add(this.ep_lbl_Exam_Name);
            this.Controls.Add(this.ep_lbl_Class_Name);
            this.Controls.Add(this.ep_btn_addExam);
            this.Controls.Add(this.ep_tBx_Period_Name);
            this.Controls.Add(this.ep_btn_addClass);
            this.Controls.Add(this.ep_lbl_End_Time);
            this.Controls.Add(this.ep_dtp_End_Time);
            this.Controls.Add(this.ep_lbl_Start_Time);
            this.Controls.Add(this.ep_dtp_Start_Time);
            this.Controls.Add(this.ep_lbl_Period_Name);
            this.Controls.Add(this.ep_btn_confirm);
            this.Controls.Add(this.ep_tBx_Plan_Name);
            this.Controls.Add(this.ep_tBx_Emp_type);
            this.Controls.Add(this.ep_lbl_Emp_Type);
            this.Controls.Add(this.ep_btn_back);
            this.Controls.Add(this.ep_flp_Lines_Info);
            this.Controls.Add(this.ep_btn_addPeroid);
            this.Controls.Add(this.ep_tBx_Head_Summary);
            this.Controls.Add(this.ep_lbl_Plan_Summary);
            this.Controls.Add(this.ep_lbl_Plan_Name);
            this.Name = "EditPeriod";
            this.Text = "学习计划阶段管理";
            this.Load += new System.EventHandler(this.EditPeriod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ep_lbl_Plan_Name;
        private System.Windows.Forms.Label ep_lbl_Plan_Summary;
        private System.Windows.Forms.TextBox ep_tBx_Head_Summary;
        private CCWin.SkinControl.SkinButton ep_btn_addPeroid;
        private System.Windows.Forms.FlowLayoutPanel ep_flp_Lines_Info;
        private CCWin.SkinControl.SkinButton ep_btn_back;
        private System.Windows.Forms.Label ep_lbl_Emp_Type;
        private System.Windows.Forms.TextBox ep_tBx_Emp_type;
        private System.Windows.Forms.TextBox ep_tBx_Plan_Name;
        private CCWin.SkinControl.SkinButton ep_btn_confirm;
        private System.Windows.Forms.Label ep_lbl_Period_Name;
        private System.Windows.Forms.DateTimePicker ep_dtp_Start_Time;
        private System.Windows.Forms.Label ep_lbl_Start_Time;
        private System.Windows.Forms.Label ep_lbl_End_Time;
        private System.Windows.Forms.DateTimePicker ep_dtp_End_Time;
        private CCWin.SkinControl.SkinButton ep_btn_addClass;
        private System.Windows.Forms.TextBox ep_tBx_Period_Name;
        private CCWin.SkinControl.SkinButton ep_btn_addExam;
        private System.Windows.Forms.Label ep_lbl_Class_Name;
        private System.Windows.Forms.Label ep_lbl_Exam_Name;
        private CCWin.SkinControl.SkinButton ep_btn_All_Peroid;
    }
}