namespace WindowsFormsApplication1
{
    partial class LessonArrangement
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
            this.label1 = new System.Windows.Forms.Label();
            this.fLP_lessonesAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.fLP_peopleChoosed = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addLesson = new CCWin.SkinControl.SkinButton();
            this.btn_peopleAdd = new CCWin.SkinControl.SkinButton();
            this.btn_sure = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label1.Location = new System.Drawing.Point(304, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "学习计划安排";
            // 
            // fLP_lessonesAdd
            // 
            this.fLP_lessonesAdd.AutoScroll = true;
            this.fLP_lessonesAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLP_lessonesAdd.Location = new System.Drawing.Point(143, 107);
            this.fLP_lessonesAdd.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_lessonesAdd.Name = "fLP_lessonesAdd";
            this.fLP_lessonesAdd.Size = new System.Drawing.Size(532, 152);
            this.fLP_lessonesAdd.TabIndex = 3;
            // 
            // fLP_peopleChoosed
            // 
            this.fLP_peopleChoosed.AutoScroll = true;
            this.fLP_peopleChoosed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLP_peopleChoosed.Location = new System.Drawing.Point(143, 313);
            this.fLP_peopleChoosed.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_peopleChoosed.Name = "fLP_peopleChoosed";
            this.fLP_peopleChoosed.Size = new System.Drawing.Size(532, 152);
            this.fLP_peopleChoosed.TabIndex = 4;
            // 
            // btn_addLesson
            // 
            this.btn_addLesson.BackColor = System.Drawing.Color.Transparent;
            this.btn_addLesson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_addLesson.DownBack = null;
            this.btn_addLesson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_addLesson.Location = new System.Drawing.Point(18, 153);
            this.btn_addLesson.MouseBack = null;
            this.btn_addLesson.Name = "btn_addLesson";
            this.btn_addLesson.NormlBack = null;
            this.btn_addLesson.Size = new System.Drawing.Size(105, 50);
            this.btn_addLesson.TabIndex = 7;
            this.btn_addLesson.Text = "添加学习计划";
            this.btn_addLesson.UseVisualStyleBackColor = false;
            this.btn_addLesson.Click += new System.EventHandler(this.btn_addLesson_Click);
            // 
            // btn_peopleAdd
            // 
            this.btn_peopleAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_peopleAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_peopleAdd.DownBack = null;
            this.btn_peopleAdd.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_peopleAdd.Location = new System.Drawing.Point(18, 365);
            this.btn_peopleAdd.MouseBack = null;
            this.btn_peopleAdd.Name = "btn_peopleAdd";
            this.btn_peopleAdd.NormlBack = null;
            this.btn_peopleAdd.Size = new System.Drawing.Size(105, 50);
            this.btn_peopleAdd.TabIndex = 8;
            this.btn_peopleAdd.Text = "添加员工";
            this.btn_peopleAdd.UseVisualStyleBackColor = false;
            this.btn_peopleAdd.Click += new System.EventHandler(this.btn_peopleAdd_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.BackColor = System.Drawing.Color.Transparent;
            this.btn_sure.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_sure.DownBack = null;
            this.btn_sure.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_sure.Location = new System.Drawing.Point(545, 505);
            this.btn_sure.MouseBack = null;
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.NormlBack = null;
            this.btn_sure.Size = new System.Drawing.Size(85, 32);
            this.btn_sure.TabIndex = 9;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = false;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_cancel.Location = new System.Drawing.Point(645, 505);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(85, 32);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // LessonArrangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.btn_peopleAdd);
            this.Controls.Add(this.btn_addLesson);
            this.Controls.Add(this.fLP_peopleChoosed);
            this.Controls.Add(this.fLP_lessonesAdd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LessonArrangement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程安排";
            this.Load += new System.EventHandler(this.LessonArrangement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fLP_lessonesAdd;
        private System.Windows.Forms.FlowLayoutPanel fLP_peopleChoosed;
        private CCWin.SkinControl.SkinButton btn_addLesson;
        private CCWin.SkinControl.SkinButton btn_sure;
        private CCWin.SkinControl.SkinButton btn_peopleAdd;
        private CCWin.SkinControl.SkinButton btn_cancel;
    }
}