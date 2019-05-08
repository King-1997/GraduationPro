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
            this.SuspendLayout();
            // 
            // me_btn_back
            // 
            this.me_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.me_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.me_btn_back.DownBack = null;
            this.me_btn_back.Location = new System.Drawing.Point(607, 431);
            this.me_btn_back.MouseBack = null;
            this.me_btn_back.Name = "me_btn_back";
            this.me_btn_back.NormlBack = null;
            this.me_btn_back.Size = new System.Drawing.Size(73, 37);
            this.me_btn_back.TabIndex = 22;
            this.me_btn_back.Text = "返回";
            this.me_btn_back.UseVisualStyleBackColor = false;
            this.me_btn_back.Click += new System.EventHandler(this.me_btn_back_Click);
            // 
            // ManageExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 490);
            this.Controls.Add(this.me_btn_back);
            this.Name = "ManageExam";
            this.Text = "考试详细信息";
            this.Load += new System.EventHandler(this.ManageExam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton me_btn_back;
    }
}