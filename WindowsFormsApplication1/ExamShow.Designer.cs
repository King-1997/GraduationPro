namespace WindowsFormsApplication1
{
    partial class ExamShow
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
            this.fLP_showQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBx_passCount = new CCWin.SkinControl.SkinComboBox();
            this.btn_addQuestions = new CCWin.SkinControl.SkinButton();
            this.btn_choose = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // fLP_showQuestions
            // 
            this.fLP_showQuestions.AutoScroll = true;
            this.fLP_showQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLP_showQuestions.Location = new System.Drawing.Point(64, 50);
            this.fLP_showQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_showQuestions.Name = "fLP_showQuestions";
            this.fLP_showQuestions.Size = new System.Drawing.Size(503, 374);
            this.fLP_showQuestions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label1.Location = new System.Drawing.Point(39, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "设置达标题数：";
            // 
            // cBx_passCount
            // 
            this.cBx_passCount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_passCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_passCount.FormattingEnabled = true;
            this.cBx_passCount.Location = new System.Drawing.Point(170, 450);
            this.cBx_passCount.Name = "cBx_passCount";
            this.cBx_passCount.Size = new System.Drawing.Size(121, 24);
            this.cBx_passCount.TabIndex = 4;
            this.cBx_passCount.WaterText = "";
            // 
            // btn_addQuestions
            // 
            this.btn_addQuestions.BackColor = System.Drawing.Color.Transparent;
            this.btn_addQuestions.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_addQuestions.DownBack = null;
            this.btn_addQuestions.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_addQuestions.Location = new System.Drawing.Point(609, 222);
            this.btn_addQuestions.MouseBack = null;
            this.btn_addQuestions.Name = "btn_addQuestions";
            this.btn_addQuestions.NormlBack = null;
            this.btn_addQuestions.Size = new System.Drawing.Size(82, 35);
            this.btn_addQuestions.TabIndex = 6;
            this.btn_addQuestions.Text = "增加题目";
            this.btn_addQuestions.UseVisualStyleBackColor = false;
            this.btn_addQuestions.Click += new System.EventHandler(this.btn_addQuestions_Click);
            // 
            // btn_choose
            // 
            this.btn_choose.BackColor = System.Drawing.Color.Transparent;
            this.btn_choose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_choose.DownBack = null;
            this.btn_choose.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_choose.Location = new System.Drawing.Point(535, 516);
            this.btn_choose.MouseBack = null;
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.NormlBack = null;
            this.btn_choose.Size = new System.Drawing.Size(82, 35);
            this.btn_choose.TabIndex = 7;
            this.btn_choose.Text = "确定";
            this.btn_choose.UseVisualStyleBackColor = false;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_cancel.Location = new System.Drawing.Point(635, 516);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(82, 35);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ExamShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.btn_addQuestions);
            this.Controls.Add(this.cBx_passCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fLP_showQuestions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExamShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考题预览";
            this.Load += new System.EventHandler(this.ExamShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLP_showQuestions;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinComboBox cBx_passCount;
        private CCWin.SkinControl.SkinButton btn_addQuestions;
        private CCWin.SkinControl.SkinButton btn_choose;
        private CCWin.SkinControl.SkinButton btn_cancel;
    }
}