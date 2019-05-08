namespace WindowsFormsApplication1
{
    partial class Mainmenu
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
            this.m_lblTitle = new System.Windows.Forms.Label();
            this.p_lblCurPerson = new System.Windows.Forms.Label();
            this.p_lblWelcome = new System.Windows.Forms.Label();
            this.p_btnQuit = new CCWin.SkinControl.SkinButton();
            this.m_btnPersonal = new CCWin.SkinControl.SkinButton();
            this.m_btnClass = new CCWin.SkinControl.SkinButton();
            this.m_btnManage = new CCWin.SkinControl.SkinButton();
            this.m_btnSign = new CCWin.SkinControl.SkinButton();
            this.mm_lbl_ann = new System.Windows.Forms.Label();
            this.mm_flp_announcement = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // m_lblTitle
            // 
            this.m_lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.m_lblTitle.Enabled = false;
            this.m_lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this.m_lblTitle.Location = new System.Drawing.Point(334, 74);
            this.m_lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblTitle.Name = "m_lblTitle";
            this.m_lblTitle.Size = new System.Drawing.Size(304, 53);
            this.m_lblTitle.TabIndex = 1;
            this.m_lblTitle.Text = "员工学习管理系统";
            // 
            // p_lblCurPerson
            // 
            this.p_lblCurPerson.AutoSize = true;
            this.p_lblCurPerson.BackColor = System.Drawing.Color.Transparent;
            this.p_lblCurPerson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCurPerson.Location = new System.Drawing.Point(707, 157);
            this.p_lblCurPerson.Name = "p_lblCurPerson";
            this.p_lblCurPerson.Size = new System.Drawing.Size(32, 17);
            this.p_lblCurPerson.TabIndex = 5;
            this.p_lblCurPerson.Text = "XXX";
            // 
            // p_lblWelcome
            // 
            this.p_lblWelcome.AutoSize = true;
            this.p_lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.p_lblWelcome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblWelcome.Location = new System.Drawing.Point(648, 157);
            this.p_lblWelcome.Name = "p_lblWelcome";
            this.p_lblWelcome.Size = new System.Drawing.Size(56, 17);
            this.p_lblWelcome.TabIndex = 4;
            this.p_lblWelcome.Text = "欢迎您，";
            // 
            // p_btnQuit
            // 
            this.p_btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnQuit.DownBack = null;
            this.p_btnQuit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.p_btnQuit.Location = new System.Drawing.Point(757, 148);
            this.p_btnQuit.MouseBack = null;
            this.p_btnQuit.Name = "p_btnQuit";
            this.p_btnQuit.NormlBack = null;
            this.p_btnQuit.Size = new System.Drawing.Size(75, 33);
            this.p_btnQuit.TabIndex = 8;
            this.p_btnQuit.Text = "注销";
            this.p_btnQuit.UseVisualStyleBackColor = false;
            this.p_btnQuit.Click += new System.EventHandler(this.p_btnQuit_Click_1);
            // 
            // m_btnPersonal
            // 
            this.m_btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.m_btnPersonal.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btnPersonal.DownBack = null;
            this.m_btnPersonal.Location = new System.Drawing.Point(136, 288);
            this.m_btnPersonal.MouseBack = null;
            this.m_btnPersonal.Name = "m_btnPersonal";
            this.m_btnPersonal.NormlBack = null;
            this.m_btnPersonal.Size = new System.Drawing.Size(159, 217);
            this.m_btnPersonal.TabIndex = 9;
            this.m_btnPersonal.Text = "个人中心";
            this.m_btnPersonal.UseVisualStyleBackColor = false;
            this.m_btnPersonal.Click += new System.EventHandler(this.m_btnPersonal_Click);
            // 
            // m_btnClass
            // 
            this.m_btnClass.BackColor = System.Drawing.Color.Transparent;
            this.m_btnClass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btnClass.DownBack = null;
            this.m_btnClass.Location = new System.Drawing.Point(350, 288);
            this.m_btnClass.MouseBack = null;
            this.m_btnClass.Name = "m_btnClass";
            this.m_btnClass.NormlBack = null;
            this.m_btnClass.Size = new System.Drawing.Size(159, 217);
            this.m_btnClass.TabIndex = 10;
            this.m_btnClass.Text = "课程中心";
            this.m_btnClass.UseVisualStyleBackColor = false;
            this.m_btnClass.Click += new System.EventHandler(this.m_btnClass_Click);
            // 
            // m_btnManage
            // 
            this.m_btnManage.BackColor = System.Drawing.Color.Transparent;
            this.m_btnManage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btnManage.DownBack = null;
            this.m_btnManage.Location = new System.Drawing.Point(566, 288);
            this.m_btnManage.MouseBack = null;
            this.m_btnManage.Name = "m_btnManage";
            this.m_btnManage.NormlBack = null;
            this.m_btnManage.Size = new System.Drawing.Size(159, 217);
            this.m_btnManage.TabIndex = 11;
            this.m_btnManage.Text = "管理中心";
            this.m_btnManage.UseVisualStyleBackColor = false;
            this.m_btnManage.Visible = false;
            this.m_btnManage.Click += new System.EventHandler(this.m_btnManage_Click);
            // 
            // m_btnSign
            // 
            this.m_btnSign.BackColor = System.Drawing.Color.Transparent;
            this.m_btnSign.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btnSign.DownBack = null;
            this.m_btnSign.Location = new System.Drawing.Point(776, 288);
            this.m_btnSign.MouseBack = null;
            this.m_btnSign.Name = "m_btnSign";
            this.m_btnSign.NormlBack = null;
            this.m_btnSign.Size = new System.Drawing.Size(159, 217);
            this.m_btnSign.TabIndex = 12;
            this.m_btnSign.Text = "申请中心";
            this.m_btnSign.UseVisualStyleBackColor = false;
            this.m_btnSign.Click += new System.EventHandler(this.m_btnSign_Click);
            // 
            // mm_lbl_ann
            // 
            this.mm_lbl_ann.AutoSize = true;
            this.mm_lbl_ann.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mm_lbl_ann.Location = new System.Drawing.Point(110, 132);
            this.mm_lbl_ann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mm_lbl_ann.Name = "mm_lbl_ann";
            this.mm_lbl_ann.Size = new System.Drawing.Size(90, 21);
            this.mm_lbl_ann.TabIndex = 39;
            this.mm_lbl_ann.Text = "公告信息：";
            // 
            // mm_flp_announcement
            // 
            this.mm_flp_announcement.AutoScroll = true;
            this.mm_flp_announcement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mm_flp_announcement.Location = new System.Drawing.Point(108, 166);
            this.mm_flp_announcement.Name = "mm_flp_announcement";
            this.mm_flp_announcement.Size = new System.Drawing.Size(418, 99);
            this.mm_flp_announcement.TabIndex = 38;
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 627);
            this.ControlBox = false;
            this.Controls.Add(this.mm_lbl_ann);
            this.Controls.Add(this.mm_flp_announcement);
            this.Controls.Add(this.m_btnSign);
            this.Controls.Add(this.m_btnManage);
            this.Controls.Add(this.m_btnClass);
            this.Controls.Add(this.m_btnPersonal);
            this.Controls.Add(this.p_btnQuit);
            this.Controls.Add(this.p_lblCurPerson);
            this.Controls.Add(this.p_lblWelcome);
            this.Controls.Add(this.m_lblTitle);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工学习管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label m_lblTitle;
        private System.Windows.Forms.Label p_lblCurPerson;
        private System.Windows.Forms.Label p_lblWelcome;
        private CCWin.SkinControl.SkinButton p_btnQuit;
        private CCWin.SkinControl.SkinButton m_btnPersonal;
        private CCWin.SkinControl.SkinButton m_btnClass;
        private CCWin.SkinControl.SkinButton m_btnManage;
        private CCWin.SkinControl.SkinButton m_btnSign;
        private System.Windows.Forms.Label mm_lbl_ann;
        private System.Windows.Forms.FlowLayoutPanel mm_flp_announcement;
    }
}