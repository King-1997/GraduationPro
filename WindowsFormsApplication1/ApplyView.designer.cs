namespace WindowsFormsApplication1
{
    partial class ApplyView
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
            this.AV_lbl_Title = new System.Windows.Forms.Label();
            this.AV_lbl_Welcome = new System.Windows.Forms.Label();
            this.AV_lbl_User = new System.Windows.Forms.Label();
            this.AV_txtBx_Reason = new System.Windows.Forms.RichTextBox();
            this.AV_lbl_Reason = new System.Windows.Forms.Label();
            this.AV_lbl_Category = new System.Windows.Forms.Label();
            this.AV_Combx_category = new System.Windows.Forms.ComboBox();
            this.AV_lbl_StartTime = new System.Windows.Forms.Label();
            this.AV_dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.AV_dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.AV_lbl_EndTime = new System.Windows.Forms.Label();
            this.AV_lbl_Prove = new System.Windows.Forms.Label();
            this.AV_Combx_Prove = new System.Windows.Forms.ComboBox();
            this.AV_btn_Logout = new CCWin.SkinControl.SkinButton();
            this.AV_btn_Submit = new CCWin.SkinControl.SkinButton();
            this.AV_btn_Return = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AV_lbl_Title
            // 
            this.AV_lbl_Title.AutoSize = true;
            this.AV_lbl_Title.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AV_lbl_Title.Location = new System.Drawing.Point(36, 37);
            this.AV_lbl_Title.Name = "AV_lbl_Title";
            this.AV_lbl_Title.Size = new System.Drawing.Size(133, 39);
            this.AV_lbl_Title.TabIndex = 0;
            this.AV_lbl_Title.Text = "申请中心";
            // 
            // AV_lbl_Welcome
            // 
            this.AV_lbl_Welcome.AutoSize = true;
            this.AV_lbl_Welcome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_Welcome.Location = new System.Drawing.Point(526, 45);
            this.AV_lbl_Welcome.Name = "AV_lbl_Welcome";
            this.AV_lbl_Welcome.Size = new System.Drawing.Size(56, 17);
            this.AV_lbl_Welcome.TabIndex = 1;
            this.AV_lbl_Welcome.Text = "欢迎您，";
            // 
            // AV_lbl_User
            // 
            this.AV_lbl_User.AutoSize = true;
            this.AV_lbl_User.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_User.Location = new System.Drawing.Point(588, 45);
            this.AV_lbl_User.Name = "AV_lbl_User";
            this.AV_lbl_User.Size = new System.Drawing.Size(32, 17);
            this.AV_lbl_User.TabIndex = 2;
            this.AV_lbl_User.Text = "XXX";
            // 
            // AV_txtBx_Reason
            // 
            this.AV_txtBx_Reason.Location = new System.Drawing.Point(215, 204);
            this.AV_txtBx_Reason.Name = "AV_txtBx_Reason";
            this.AV_txtBx_Reason.Size = new System.Drawing.Size(407, 116);
            this.AV_txtBx_Reason.TabIndex = 5;
            this.AV_txtBx_Reason.Text = "";
            // 
            // AV_lbl_Reason
            // 
            this.AV_lbl_Reason.AutoSize = true;
            this.AV_lbl_Reason.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_Reason.Location = new System.Drawing.Point(212, 174);
            this.AV_lbl_Reason.Name = "AV_lbl_Reason";
            this.AV_lbl_Reason.Size = new System.Drawing.Size(68, 17);
            this.AV_lbl_Reason.TabIndex = 8;
            this.AV_lbl_Reason.Text = "请假原因：";
            // 
            // AV_lbl_Category
            // 
            this.AV_lbl_Category.AutoSize = true;
            this.AV_lbl_Category.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_Category.Location = new System.Drawing.Point(212, 88);
            this.AV_lbl_Category.Name = "AV_lbl_Category";
            this.AV_lbl_Category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AV_lbl_Category.Size = new System.Drawing.Size(68, 17);
            this.AV_lbl_Category.TabIndex = 11;
            this.AV_lbl_Category.Text = "请假类别：";
            // 
            // AV_Combx_category
            // 
            this.AV_Combx_category.BackColor = System.Drawing.SystemColors.Window;
            this.AV_Combx_category.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AV_Combx_category.FormattingEnabled = true;
            this.AV_Combx_category.Location = new System.Drawing.Point(341, 88);
            this.AV_Combx_category.Name = "AV_Combx_category";
            this.AV_Combx_category.Size = new System.Drawing.Size(144, 20);
            this.AV_Combx_category.TabIndex = 12;
            // 
            // AV_lbl_StartTime
            // 
            this.AV_lbl_StartTime.AutoSize = true;
            this.AV_lbl_StartTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_StartTime.Location = new System.Drawing.Point(212, 342);
            this.AV_lbl_StartTime.Name = "AV_lbl_StartTime";
            this.AV_lbl_StartTime.Size = new System.Drawing.Size(68, 17);
            this.AV_lbl_StartTime.TabIndex = 13;
            this.AV_lbl_StartTime.Text = "开始时间：";
            // 
            // AV_dtp_StartTime
            // 
            this.AV_dtp_StartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.AV_dtp_StartTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AV_dtp_StartTime.Location = new System.Drawing.Point(329, 337);
            this.AV_dtp_StartTime.Name = "AV_dtp_StartTime";
            this.AV_dtp_StartTime.Size = new System.Drawing.Size(156, 23);
            this.AV_dtp_StartTime.TabIndex = 22;
            // 
            // AV_dtp_EndTime
            // 
            this.AV_dtp_EndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.AV_dtp_EndTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AV_dtp_EndTime.Location = new System.Drawing.Point(329, 376);
            this.AV_dtp_EndTime.Name = "AV_dtp_EndTime";
            this.AV_dtp_EndTime.Size = new System.Drawing.Size(156, 23);
            this.AV_dtp_EndTime.TabIndex = 24;
            // 
            // AV_lbl_EndTime
            // 
            this.AV_lbl_EndTime.AutoSize = true;
            this.AV_lbl_EndTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_EndTime.Location = new System.Drawing.Point(212, 381);
            this.AV_lbl_EndTime.Name = "AV_lbl_EndTime";
            this.AV_lbl_EndTime.Size = new System.Drawing.Size(68, 17);
            this.AV_lbl_EndTime.TabIndex = 23;
            this.AV_lbl_EndTime.Text = "结束时间：";
            // 
            // AV_lbl_Prove
            // 
            this.AV_lbl_Prove.AutoSize = true;
            this.AV_lbl_Prove.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AV_lbl_Prove.Location = new System.Drawing.Point(212, 417);
            this.AV_lbl_Prove.Name = "AV_lbl_Prove";
            this.AV_lbl_Prove.Size = new System.Drawing.Size(68, 17);
            this.AV_lbl_Prove.TabIndex = 25;
            this.AV_lbl_Prove.Text = "请假证明：";
            // 
            // AV_Combx_Prove
            // 
            this.AV_Combx_Prove.BackColor = System.Drawing.SystemColors.Window;
            this.AV_Combx_Prove.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AV_Combx_Prove.FormattingEnabled = true;
            this.AV_Combx_Prove.Location = new System.Drawing.Point(329, 417);
            this.AV_Combx_Prove.Name = "AV_Combx_Prove";
            this.AV_Combx_Prove.Size = new System.Drawing.Size(156, 20);
            this.AV_Combx_Prove.TabIndex = 26;
            // 
            // AV_btn_Logout
            // 
            this.AV_btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.AV_btn_Logout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AV_btn_Logout.DownBack = null;
            this.AV_btn_Logout.Location = new System.Drawing.Point(640, 37);
            this.AV_btn_Logout.MouseBack = null;
            this.AV_btn_Logout.Name = "AV_btn_Logout";
            this.AV_btn_Logout.NormlBack = null;
            this.AV_btn_Logout.Size = new System.Drawing.Size(75, 32);
            this.AV_btn_Logout.TabIndex = 27;
            this.AV_btn_Logout.Text = "注销";
            this.AV_btn_Logout.UseVisualStyleBackColor = false;
            this.AV_btn_Logout.Click += new System.EventHandler(this.AV_btn_Logout_Click);
            // 
            // AV_btn_Submit
            // 
            this.AV_btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.AV_btn_Submit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AV_btn_Submit.DownBack = null;
            this.AV_btn_Submit.Location = new System.Drawing.Point(245, 464);
            this.AV_btn_Submit.MouseBack = null;
            this.AV_btn_Submit.Name = "AV_btn_Submit";
            this.AV_btn_Submit.NormlBack = null;
            this.AV_btn_Submit.Size = new System.Drawing.Size(75, 32);
            this.AV_btn_Submit.TabIndex = 28;
            this.AV_btn_Submit.Text = "确定";
            this.AV_btn_Submit.UseVisualStyleBackColor = false;
            this.AV_btn_Submit.Click += new System.EventHandler(this.AV_btn_Submit_Click);
            // 
            // AV_btn_Return
            // 
            this.AV_btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.AV_btn_Return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.AV_btn_Return.DownBack = null;
            this.AV_btn_Return.Location = new System.Drawing.Point(506, 464);
            this.AV_btn_Return.MouseBack = null;
            this.AV_btn_Return.Name = "AV_btn_Return";
            this.AV_btn_Return.NormlBack = null;
            this.AV_btn_Return.Size = new System.Drawing.Size(75, 32);
            this.AV_btn_Return.TabIndex = 29;
            this.AV_btn_Return.Text = "返回";
            this.AV_btn_Return.UseVisualStyleBackColor = false;
            this.AV_btn_Return.Click += new System.EventHandler(this.AV_btn_Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(212, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "可请天数：";
            // 
            // ApplyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(837, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AV_btn_Return);
            this.Controls.Add(this.AV_btn_Submit);
            this.Controls.Add(this.AV_btn_Logout);
            this.Controls.Add(this.AV_Combx_Prove);
            this.Controls.Add(this.AV_lbl_Prove);
            this.Controls.Add(this.AV_dtp_EndTime);
            this.Controls.Add(this.AV_lbl_EndTime);
            this.Controls.Add(this.AV_dtp_StartTime);
            this.Controls.Add(this.AV_lbl_StartTime);
            this.Controls.Add(this.AV_Combx_category);
            this.Controls.Add(this.AV_lbl_Category);
            this.Controls.Add(this.AV_lbl_Reason);
            this.Controls.Add(this.AV_txtBx_Reason);
            this.Controls.Add(this.AV_lbl_User);
            this.Controls.Add(this.AV_lbl_Welcome);
            this.Controls.Add(this.AV_lbl_Title);
            this.Name = "ApplyView";
            this.Text = "ApplyView";
            this.Load += new System.EventHandler(this.ApplyView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AV_lbl_Title;
        private System.Windows.Forms.Label AV_lbl_Welcome;
        private System.Windows.Forms.Label AV_lbl_User;
        private System.Windows.Forms.RichTextBox AV_txtBx_Reason;
        private System.Windows.Forms.Label AV_lbl_Reason;
        private System.Windows.Forms.Label AV_lbl_Category;
        private System.Windows.Forms.ComboBox AV_Combx_category;
        private System.Windows.Forms.Label AV_lbl_StartTime;
        private System.Windows.Forms.DateTimePicker AV_dtp_StartTime;
        private System.Windows.Forms.DateTimePicker AV_dtp_EndTime;
        private System.Windows.Forms.Label AV_lbl_EndTime;
        private System.Windows.Forms.Label AV_lbl_Prove;
        private System.Windows.Forms.ComboBox AV_Combx_Prove;
        private CCWin.SkinControl.SkinButton AV_btn_Logout;
        private CCWin.SkinControl.SkinButton AV_btn_Submit;
        private CCWin.SkinControl.SkinButton AV_btn_Return;
        private System.Windows.Forms.Label label1;
    }
}