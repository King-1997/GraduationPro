namespace WindowsFormsApplication1
{
    partial class LoadExam
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbx_questions = new System.Windows.Forms.TextBox();
            this.tbx_A = new System.Windows.Forms.TextBox();
            this.tbx_B = new System.Windows.Forms.TextBox();
            this.tbx_C = new System.Windows.Forms.TextBox();
            this.tbx_D = new System.Windows.Forms.TextBox();
            this.lbl_questiions = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_D = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.cBx_answer = new CCWin.SkinControl.SkinComboBox();
            this.btn_load = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.le_lbl_goal = new System.Windows.Forms.Label();
            this.tbx_Goal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbx_questions
            // 
            this.tbx_questions.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_questions.Location = new System.Drawing.Point(140, 33);
            this.tbx_questions.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_questions.Multiline = true;
            this.tbx_questions.Name = "tbx_questions";
            this.tbx_questions.Size = new System.Drawing.Size(448, 74);
            this.tbx_questions.TabIndex = 2;
            // 
            // tbx_A
            // 
            this.tbx_A.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_A.Location = new System.Drawing.Point(140, 125);
            this.tbx_A.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_A.Name = "tbx_A";
            this.tbx_A.Size = new System.Drawing.Size(448, 23);
            this.tbx_A.TabIndex = 3;
            // 
            // tbx_B
            // 
            this.tbx_B.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_B.Location = new System.Drawing.Point(140, 183);
            this.tbx_B.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_B.Name = "tbx_B";
            this.tbx_B.Size = new System.Drawing.Size(448, 23);
            this.tbx_B.TabIndex = 4;
            // 
            // tbx_C
            // 
            this.tbx_C.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_C.Location = new System.Drawing.Point(140, 234);
            this.tbx_C.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_C.Name = "tbx_C";
            this.tbx_C.Size = new System.Drawing.Size(448, 23);
            this.tbx_C.TabIndex = 5;
            // 
            // tbx_D
            // 
            this.tbx_D.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_D.Location = new System.Drawing.Point(140, 291);
            this.tbx_D.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_D.Name = "tbx_D";
            this.tbx_D.Size = new System.Drawing.Size(448, 23);
            this.tbx_D.TabIndex = 6;
            // 
            // lbl_questiions
            // 
            this.lbl_questiions.AutoSize = true;
            this.lbl_questiions.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_questiions.Location = new System.Drawing.Point(59, 57);
            this.lbl_questiions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_questiions.Name = "lbl_questiions";
            this.lbl_questiions.Size = new System.Drawing.Size(58, 21);
            this.lbl_questiions.TabIndex = 7;
            this.lbl_questiions.Text = "题目：";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_A.Location = new System.Drawing.Point(57, 125);
            this.lbl_A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(69, 21);
            this.lbl_A.TabIndex = 8;
            this.lbl_A.Text = "选项A：";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_B.Location = new System.Drawing.Point(57, 183);
            this.lbl_B.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(68, 21);
            this.lbl_B.TabIndex = 9;
            this.lbl_B.Text = "选项B：";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_C.Location = new System.Drawing.Point(57, 234);
            this.lbl_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(69, 21);
            this.lbl_C.TabIndex = 10;
            this.lbl_C.Text = "选项C：";
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_D.Location = new System.Drawing.Point(59, 291);
            this.lbl_D.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(70, 21);
            this.lbl_D.TabIndex = 11;
            this.lbl_D.Text = "选项D：";
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_answer.Location = new System.Drawing.Point(59, 344);
            this.lbl_answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(58, 21);
            this.lbl_answer.TabIndex = 12;
            this.lbl_answer.Text = "答案：";
            // 
            // cBx_answer
            // 
            this.cBx_answer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_answer.FormattingEnabled = true;
            this.cBx_answer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cBx_answer.Location = new System.Drawing.Point(140, 343);
            this.cBx_answer.Name = "cBx_answer";
            this.cBx_answer.Size = new System.Drawing.Size(121, 22);
            this.cBx_answer.TabIndex = 14;
            this.cBx_answer.WaterText = "";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_load.DownBack = null;
            this.btn_load.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_load.Location = new System.Drawing.Point(454, 384);
            this.btn_load.MouseBack = null;
            this.btn_load.Name = "btn_load";
            this.btn_load.NormlBack = null;
            this.btn_load.Size = new System.Drawing.Size(70, 30);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "上传";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_cancel.Location = new System.Drawing.Point(539, 384);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(70, 30);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // le_lbl_goal
            // 
            this.le_lbl_goal.AutoSize = true;
            this.le_lbl_goal.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.le_lbl_goal.Location = new System.Drawing.Point(59, 387);
            this.le_lbl_goal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.le_lbl_goal.Name = "le_lbl_goal";
            this.le_lbl_goal.Size = new System.Drawing.Size(58, 21);
            this.le_lbl_goal.TabIndex = 18;
            this.le_lbl_goal.Text = "分值：";
            // 
            // tbx_Goal
            // 
            this.tbx_Goal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tbx_Goal.Location = new System.Drawing.Point(140, 387);
            this.tbx_Goal.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Goal.Name = "tbx_Goal";
            this.tbx_Goal.Size = new System.Drawing.Size(121, 23);
            this.tbx_Goal.TabIndex = 17;
            // 
            // LoadExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(639, 430);
            this.ControlBox = false;
            this.Controls.Add(this.le_lbl_goal);
            this.Controls.Add(this.tbx_Goal);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.cBx_answer);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lbl_D);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.lbl_questiions);
            this.Controls.Add(this.tbx_D);
            this.Controls.Add(this.tbx_C);
            this.Controls.Add(this.tbx_B);
            this.Controls.Add(this.tbx_A);
            this.Controls.Add(this.tbx_questions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoadExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考题上传";
            this.Load += new System.EventHandler(this.LoadExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox tbx_questions;
        private System.Windows.Forms.TextBox tbx_A;
        private System.Windows.Forms.TextBox tbx_B;
        private System.Windows.Forms.TextBox tbx_C;
        private System.Windows.Forms.TextBox tbx_D;
        private System.Windows.Forms.Label lbl_questiions;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_D;
        private System.Windows.Forms.Label lbl_answer;
        private CCWin.SkinControl.SkinComboBox cBx_answer;
        private CCWin.SkinControl.SkinButton btn_load;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private System.Windows.Forms.Label le_lbl_goal;
        private System.Windows.Forms.TextBox tbx_Goal;
    }
}