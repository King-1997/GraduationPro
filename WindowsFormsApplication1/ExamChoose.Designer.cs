namespace WindowsFormsApplication1
{
    partial class ExamChoose
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
            this.ec_btn_back = new CCWin.SkinControl.SkinButton();
            this.ec_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.ec_btn_All_Exam = new CCWin.SkinControl.SkinButton();
            this.ec_btn_find = new CCWin.SkinControl.SkinButton();
            this.ec_fLP_Exam_Info = new System.Windows.Forms.FlowLayoutPanel();
            this.ec_lbl_keyword = new System.Windows.Forms.Label();
            this.ec_tBx_findkeywords = new System.Windows.Forms.TextBox();
            this.ec_btn_Add_Exam = new CCWin.SkinControl.SkinButton();
            this.ec_tBx_Exam_Name = new System.Windows.Forms.TextBox();
            this.ec_lbl_End_Time = new System.Windows.Forms.Label();
            this.ec_dtp_End_Time = new System.Windows.Forms.DateTimePicker();
            this.ec_lbl_Start_Time = new System.Windows.Forms.Label();
            this.ec_dtp_Start_Time = new System.Windows.Forms.DateTimePicker();
            this.ec_lbl_Exam_Name = new System.Windows.Forms.Label();
            this.ec_lbl_Type = new System.Windows.Forms.Label();
            this.ec_ccb_Type = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // ec_btn_back
            // 
            this.ec_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_back.DownBack = null;
            this.ec_btn_back.Location = new System.Drawing.Point(729, 594);
            this.ec_btn_back.MouseBack = null;
            this.ec_btn_back.Name = "ec_btn_back";
            this.ec_btn_back.NormlBack = null;
            this.ec_btn_back.Size = new System.Drawing.Size(91, 37);
            this.ec_btn_back.TabIndex = 21;
            this.ec_btn_back.Text = "返回";
            this.ec_btn_back.UseVisualStyleBackColor = false;
            this.ec_btn_back.Click += new System.EventHandler(this.ec_btn_back_Click);
            // 
            // ec_btn_confirm
            // 
            this.ec_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_confirm.DownBack = null;
            this.ec_btn_confirm.Location = new System.Drawing.Point(612, 594);
            this.ec_btn_confirm.MouseBack = null;
            this.ec_btn_confirm.Name = "ec_btn_confirm";
            this.ec_btn_confirm.NormlBack = null;
            this.ec_btn_confirm.Size = new System.Drawing.Size(91, 37);
            this.ec_btn_confirm.TabIndex = 20;
            this.ec_btn_confirm.Text = "确定";
            this.ec_btn_confirm.UseVisualStyleBackColor = false;
            this.ec_btn_confirm.Click += new System.EventHandler(this.ec_btn_confirm_Click);
            // 
            // ec_btn_All_Exam
            // 
            this.ec_btn_All_Exam.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_All_Exam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_All_Exam.DownBack = null;
            this.ec_btn_All_Exam.Location = new System.Drawing.Point(654, 48);
            this.ec_btn_All_Exam.MouseBack = null;
            this.ec_btn_All_Exam.Name = "ec_btn_All_Exam";
            this.ec_btn_All_Exam.NormlBack = null;
            this.ec_btn_All_Exam.Size = new System.Drawing.Size(70, 30);
            this.ec_btn_All_Exam.TabIndex = 19;
            this.ec_btn_All_Exam.Text = "所有测试";
            this.ec_btn_All_Exam.UseVisualStyleBackColor = false;
            this.ec_btn_All_Exam.Click += new System.EventHandler(this.ec_btn_All_Exam_Click);
            // 
            // ec_btn_find
            // 
            this.ec_btn_find.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_find.DownBack = null;
            this.ec_btn_find.Location = new System.Drawing.Point(555, 48);
            this.ec_btn_find.MouseBack = null;
            this.ec_btn_find.Name = "ec_btn_find";
            this.ec_btn_find.NormlBack = null;
            this.ec_btn_find.Size = new System.Drawing.Size(56, 30);
            this.ec_btn_find.TabIndex = 18;
            this.ec_btn_find.Text = "查询";
            this.ec_btn_find.UseVisualStyleBackColor = false;
            this.ec_btn_find.Click += new System.EventHandler(this.ec_btn_find_Click);
            // 
            // ec_fLP_Exam_Info
            // 
            this.ec_fLP_Exam_Info.AutoScroll = true;
            this.ec_fLP_Exam_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ec_fLP_Exam_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ec_fLP_Exam_Info.Location = new System.Drawing.Point(61, 99);
            this.ec_fLP_Exam_Info.Margin = new System.Windows.Forms.Padding(4);
            this.ec_fLP_Exam_Info.Name = "ec_fLP_Exam_Info";
            this.ec_fLP_Exam_Info.Size = new System.Drawing.Size(815, 290);
            this.ec_fLP_Exam_Info.TabIndex = 17;
            // 
            // ec_lbl_keyword
            // 
            this.ec_lbl_keyword.AutoSize = true;
            this.ec_lbl_keyword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ec_lbl_keyword.Location = new System.Drawing.Point(130, 53);
            this.ec_lbl_keyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ec_lbl_keyword.Name = "ec_lbl_keyword";
            this.ec_lbl_keyword.Size = new System.Drawing.Size(138, 21);
            this.ec_lbl_keyword.TabIndex = 16;
            this.ec_lbl_keyword.Text = "请您输入关键字：";
            // 
            // ec_tBx_findkeywords
            // 
            this.ec_tBx_findkeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ec_tBx_findkeywords.Location = new System.Drawing.Point(300, 48);
            this.ec_tBx_findkeywords.Margin = new System.Windows.Forms.Padding(2);
            this.ec_tBx_findkeywords.Name = "ec_tBx_findkeywords";
            this.ec_tBx_findkeywords.Size = new System.Drawing.Size(219, 29);
            this.ec_tBx_findkeywords.TabIndex = 14;
            // 
            // ec_btn_Add_Exam
            // 
            this.ec_btn_Add_Exam.BackColor = System.Drawing.Color.Transparent;
            this.ec_btn_Add_Exam.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ec_btn_Add_Exam.DownBack = null;
            this.ec_btn_Add_Exam.Location = new System.Drawing.Point(761, 48);
            this.ec_btn_Add_Exam.MouseBack = null;
            this.ec_btn_Add_Exam.Name = "ec_btn_Add_Exam";
            this.ec_btn_Add_Exam.NormlBack = null;
            this.ec_btn_Add_Exam.Size = new System.Drawing.Size(70, 30);
            this.ec_btn_Add_Exam.TabIndex = 22;
            this.ec_btn_Add_Exam.Text = "新增测试";
            this.ec_btn_Add_Exam.UseVisualStyleBackColor = false;
            this.ec_btn_Add_Exam.Click += new System.EventHandler(this.ec_btn_Add_Exam_Click);
            // 
            // ec_tBx_Exam_Name
            // 
            this.ec_tBx_Exam_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.ec_tBx_Exam_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ec_tBx_Exam_Name.Location = new System.Drawing.Point(196, 438);
            this.ec_tBx_Exam_Name.Margin = new System.Windows.Forms.Padding(2);
            this.ec_tBx_Exam_Name.Name = "ec_tBx_Exam_Name";
            this.ec_tBx_Exam_Name.Size = new System.Drawing.Size(165, 29);
            this.ec_tBx_Exam_Name.TabIndex = 48;
            // 
            // ec_lbl_End_Time
            // 
            this.ec_lbl_End_Time.AutoSize = true;
            this.ec_lbl_End_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_End_Time.Location = new System.Drawing.Point(415, 491);
            this.ec_lbl_End_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_End_Time.Name = "ec_lbl_End_Time";
            this.ec_lbl_End_Time.Size = new System.Drawing.Size(68, 17);
            this.ec_lbl_End_Time.TabIndex = 46;
            this.ec_lbl_End_Time.Text = "截止时间：";
            // 
            // ec_dtp_End_Time
            // 
            this.ec_dtp_End_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_dtp_End_Time.Location = new System.Drawing.Point(492, 488);
            this.ec_dtp_End_Time.Name = "ec_dtp_End_Time";
            this.ec_dtp_End_Time.Size = new System.Drawing.Size(165, 23);
            this.ec_dtp_End_Time.TabIndex = 45;
            // 
            // ec_lbl_Start_Time
            // 
            this.ec_lbl_Start_Time.AutoSize = true;
            this.ec_lbl_Start_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_Start_Time.Location = new System.Drawing.Point(417, 444);
            this.ec_lbl_Start_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_Start_Time.Name = "ec_lbl_Start_Time";
            this.ec_lbl_Start_Time.Size = new System.Drawing.Size(68, 17);
            this.ec_lbl_Start_Time.TabIndex = 44;
            this.ec_lbl_Start_Time.Text = "开始时间：";
            // 
            // ec_dtp_Start_Time
            // 
            this.ec_dtp_Start_Time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_dtp_Start_Time.Location = new System.Drawing.Point(492, 440);
            this.ec_dtp_Start_Time.Name = "ec_dtp_Start_Time";
            this.ec_dtp_Start_Time.Size = new System.Drawing.Size(165, 23);
            this.ec_dtp_Start_Time.TabIndex = 43;
            // 
            // ec_lbl_Exam_Name
            // 
            this.ec_lbl_Exam_Name.AutoSize = true;
            this.ec_lbl_Exam_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_Exam_Name.Location = new System.Drawing.Point(131, 445);
            this.ec_lbl_Exam_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_Exam_Name.Name = "ec_lbl_Exam_Name";
            this.ec_lbl_Exam_Name.Size = new System.Drawing.Size(56, 17);
            this.ec_lbl_Exam_Name.TabIndex = 42;
            this.ec_lbl_Exam_Name.Text = "测试名：";
            // 
            // ec_lbl_Type
            // 
            this.ec_lbl_Type.AutoSize = true;
            this.ec_lbl_Type.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ec_lbl_Type.Location = new System.Drawing.Point(118, 490);
            this.ec_lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ec_lbl_Type.Name = "ec_lbl_Type";
            this.ec_lbl_Type.Size = new System.Drawing.Size(68, 17);
            this.ec_lbl_Type.TabIndex = 49;
            this.ec_lbl_Type.Text = "测试类型：";
            // 
            // ec_ccb_Type
            // 
            this.ec_ccb_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ec_ccb_Type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ec_ccb_Type.FormattingEnabled = true;
            this.ec_ccb_Type.Items.AddRange(new object[] {
            "考试",
            "课后测试"});
            this.ec_ccb_Type.Location = new System.Drawing.Point(196, 484);
            this.ec_ccb_Type.Name = "ec_ccb_Type";
            this.ec_ccb_Type.Size = new System.Drawing.Size(165, 27);
            this.ec_ccb_Type.TabIndex = 50;
            this.ec_ccb_Type.Visible = false;
            this.ec_ccb_Type.WaterText = "";
            // 
            // ExamChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 668);
            this.Controls.Add(this.ec_ccb_Type);
            this.Controls.Add(this.ec_lbl_Type);
            this.Controls.Add(this.ec_tBx_Exam_Name);
            this.Controls.Add(this.ec_lbl_End_Time);
            this.Controls.Add(this.ec_dtp_End_Time);
            this.Controls.Add(this.ec_lbl_Start_Time);
            this.Controls.Add(this.ec_dtp_Start_Time);
            this.Controls.Add(this.ec_lbl_Exam_Name);
            this.Controls.Add(this.ec_btn_Add_Exam);
            this.Controls.Add(this.ec_btn_back);
            this.Controls.Add(this.ec_btn_confirm);
            this.Controls.Add(this.ec_btn_All_Exam);
            this.Controls.Add(this.ec_btn_find);
            this.Controls.Add(this.ec_fLP_Exam_Info);
            this.Controls.Add(this.ec_lbl_keyword);
            this.Controls.Add(this.ec_tBx_findkeywords);
            this.Name = "ExamChoose";
            this.Text = "测试页面";
            this.Load += new System.EventHandler(this.ExamChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton ec_btn_back;
        private CCWin.SkinControl.SkinButton ec_btn_confirm;
        private CCWin.SkinControl.SkinButton ec_btn_All_Exam;
        private CCWin.SkinControl.SkinButton ec_btn_find;
        private System.Windows.Forms.FlowLayoutPanel ec_fLP_Exam_Info;
        private System.Windows.Forms.Label ec_lbl_keyword;
        private System.Windows.Forms.TextBox ec_tBx_findkeywords;
        private CCWin.SkinControl.SkinButton ec_btn_Add_Exam;
        private System.Windows.Forms.TextBox ec_tBx_Exam_Name;
        private System.Windows.Forms.Label ec_lbl_End_Time;
        private System.Windows.Forms.DateTimePicker ec_dtp_End_Time;
        private System.Windows.Forms.Label ec_lbl_Start_Time;
        private System.Windows.Forms.DateTimePicker ec_dtp_Start_Time;
        private System.Windows.Forms.Label ec_lbl_Exam_Name;
        private System.Windows.Forms.Label ec_lbl_Type;
        private CCWin.SkinControl.SkinComboBox ec_ccb_Type;
    }
}