namespace WindowsFormsApplication1
{
    partial class ExamForm
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
            this.lbl_Lesson_Name = new System.Windows.Forms.Label();
            this.fLP_ExamShow = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.btn_hand = new CCWin.SkinControl.SkinButton();
            this.ef_timer = new System.Windows.Forms.Timer(this.components);
            this.ef_lbl_curTime = new System.Windows.Forms.Label();
            this.ef_lbl_totalGoal = new System.Windows.Forms.Label();
            this.ef_lbl_passGoal = new System.Windows.Forms.Label();
            this.ef_lbl_exam_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Lesson_Name
            // 
            this.lbl_Lesson_Name.AutoSize = true;
            this.lbl_Lesson_Name.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.lbl_Lesson_Name.Location = new System.Drawing.Point(33, 38);
            this.lbl_Lesson_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Lesson_Name.Name = "lbl_Lesson_Name";
            this.lbl_Lesson_Name.Size = new System.Drawing.Size(82, 41);
            this.lbl_Lesson_Name.TabIndex = 0;
            this.lbl_Lesson_Name.Text = "考题";
            // 
            // fLP_ExamShow
            // 
            this.fLP_ExamShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLP_ExamShow.Location = new System.Drawing.Point(92, 149);
            this.fLP_ExamShow.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_ExamShow.Name = "fLP_ExamShow";
            this.fLP_ExamShow.Size = new System.Drawing.Size(559, 309);
            this.fLP_ExamShow.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(646, 517);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(76, 37);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "返回";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_hand
            // 
            this.btn_hand.BackColor = System.Drawing.Color.Transparent;
            this.btn_hand.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_hand.DownBack = null;
            this.btn_hand.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_hand.Location = new System.Drawing.Point(564, 517);
            this.btn_hand.MouseBack = null;
            this.btn_hand.Name = "btn_hand";
            this.btn_hand.NormlBack = null;
            this.btn_hand.Size = new System.Drawing.Size(76, 37);
            this.btn_hand.TabIndex = 5;
            this.btn_hand.Text = "提交";
            this.btn_hand.UseVisualStyleBackColor = false;
            this.btn_hand.Click += new System.EventHandler(this.btn_hand_Click);
            // 
            // ef_timer
            // 
            this.ef_timer.Tick += new System.EventHandler(this.ef_timer_Tick);
            // 
            // ef_lbl_curTime
            // 
            this.ef_lbl_curTime.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ef_lbl_curTime.Location = new System.Drawing.Point(530, 47);
            this.ef_lbl_curTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ef_lbl_curTime.Name = "ef_lbl_curTime";
            this.ef_lbl_curTime.Size = new System.Drawing.Size(174, 32);
            this.ef_lbl_curTime.TabIndex = 6;
            this.ef_lbl_curTime.Text = "YYYY/MM/dd HH:mm:ss";
            // 
            // ef_lbl_totalGoal
            // 
            this.ef_lbl_totalGoal.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ef_lbl_totalGoal.Location = new System.Drawing.Point(356, 47);
            this.ef_lbl_totalGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ef_lbl_totalGoal.Name = "ef_lbl_totalGoal";
            this.ef_lbl_totalGoal.Size = new System.Drawing.Size(117, 32);
            this.ef_lbl_totalGoal.TabIndex = 7;
            this.ef_lbl_totalGoal.Text = "总分为：";
            // 
            // ef_lbl_passGoal
            // 
            this.ef_lbl_passGoal.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ef_lbl_passGoal.Location = new System.Drawing.Point(356, 88);
            this.ef_lbl_passGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ef_lbl_passGoal.Name = "ef_lbl_passGoal";
            this.ef_lbl_passGoal.Size = new System.Drawing.Size(117, 32);
            this.ef_lbl_passGoal.TabIndex = 8;
            this.ef_lbl_passGoal.Text = "通过分数为：";
            // 
            // ef_lbl_exam_name
            // 
            this.ef_lbl_exam_name.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ef_lbl_exam_name.Location = new System.Drawing.Point(121, 47);
            this.ef_lbl_exam_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ef_lbl_exam_name.Name = "ef_lbl_exam_name";
            this.ef_lbl_exam_name.Size = new System.Drawing.Size(117, 32);
            this.ef_lbl_exam_name.TabIndex = 9;
            this.ef_lbl_exam_name.Text = "考试名：";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.ef_lbl_exam_name);
            this.Controls.Add(this.ef_lbl_passGoal);
            this.Controls.Add(this.ef_lbl_totalGoal);
            this.Controls.Add(this.ef_lbl_curTime);
            this.Controls.Add(this.btn_hand);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.fLP_ExamShow);
            this.Controls.Add(this.lbl_Lesson_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lesson_Name;
        private System.Windows.Forms.FlowLayoutPanel fLP_ExamShow;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private CCWin.SkinControl.SkinButton btn_hand;
        private System.Windows.Forms.Timer ef_timer;
        private System.Windows.Forms.Label ef_lbl_curTime;
        private System.Windows.Forms.Label ef_lbl_totalGoal;
        private System.Windows.Forms.Label ef_lbl_passGoal;
        private System.Windows.Forms.Label ef_lbl_exam_name;
    }
}