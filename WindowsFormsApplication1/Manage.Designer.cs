namespace WindowsFormsApplication1
{
    partial class Manage
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
            this.p_lblTitle = new System.Windows.Forms.Label();
            this.p_lblCurPerson = new System.Windows.Forms.Label();
            this.p_lblWelcome = new System.Windows.Forms.Label();
            this.p_btnQuit = new CCWin.SkinControl.SkinButton();
            this.btn_allTime = new CCWin.SkinControl.SkinButton();
            this.m_btnHR = new CCWin.SkinControl.SkinButton();
            this.m_btnClasses = new CCWin.SkinControl.SkinButton();
            this.btn_uploadclasses = new CCWin.SkinControl.SkinButton();
            this.p_btnHome = new CCWin.SkinControl.SkinButton();
            this.m_btn_plan_manage = new CCWin.SkinControl.SkinButton();
            this.m_flp_announcement = new System.Windows.Forms.FlowLayoutPanel();
            this.m_btn_Announce = new CCWin.SkinControl.SkinButton();
            this.m_tBx_announcement = new System.Windows.Forms.TextBox();
            this.m_lbl_announcement = new System.Windows.Forms.Label();
            this.m_btn_release = new CCWin.SkinControl.SkinButton();
            this.m_lbl_ann = new System.Windows.Forms.Label();
            this.m_btn_load_question = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // p_lblTitle
            // 
            this.p_lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this.p_lblTitle.Location = new System.Drawing.Point(17, 30);
            this.p_lblTitle.Name = "p_lblTitle";
            this.p_lblTitle.Size = new System.Drawing.Size(168, 42);
            this.p_lblTitle.TabIndex = 1;
            this.p_lblTitle.Text = "管理中心";
            // 
            // p_lblCurPerson
            // 
            this.p_lblCurPerson.AutoSize = true;
            this.p_lblCurPerson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCurPerson.Location = new System.Drawing.Point(605, 50);
            this.p_lblCurPerson.Name = "p_lblCurPerson";
            this.p_lblCurPerson.Size = new System.Drawing.Size(32, 17);
            this.p_lblCurPerson.TabIndex = 8;
            this.p_lblCurPerson.Text = "XXX";
            // 
            // p_lblWelcome
            // 
            this.p_lblWelcome.AutoSize = true;
            this.p_lblWelcome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblWelcome.Location = new System.Drawing.Point(549, 50);
            this.p_lblWelcome.Name = "p_lblWelcome";
            this.p_lblWelcome.Size = new System.Drawing.Size(56, 17);
            this.p_lblWelcome.TabIndex = 7;
            this.p_lblWelcome.Text = "欢迎您，";
            // 
            // p_btnQuit
            // 
            this.p_btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnQuit.DownBack = null;
            this.p_btnQuit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.p_btnQuit.Location = new System.Drawing.Point(650, 39);
            this.p_btnQuit.MouseBack = null;
            this.p_btnQuit.Name = "p_btnQuit";
            this.p_btnQuit.NormlBack = null;
            this.p_btnQuit.Size = new System.Drawing.Size(75, 33);
            this.p_btnQuit.TabIndex = 14;
            this.p_btnQuit.Text = "注销";
            this.p_btnQuit.UseVisualStyleBackColor = false;
            this.p_btnQuit.Click += new System.EventHandler(this.p_btnQuit_Click);
            // 
            // btn_allTime
            // 
            this.btn_allTime.BackColor = System.Drawing.Color.Transparent;
            this.btn_allTime.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_allTime.DownBack = null;
            this.btn_allTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_allTime.Location = new System.Drawing.Point(37, 232);
            this.btn_allTime.MouseBack = null;
            this.btn_allTime.Name = "btn_allTime";
            this.btn_allTime.NormlBack = null;
            this.btn_allTime.Size = new System.Drawing.Size(89, 46);
            this.btn_allTime.TabIndex = 15;
            this.btn_allTime.Text = "导出全部学时";
            this.btn_allTime.UseVisualStyleBackColor = false;
            this.btn_allTime.Click += new System.EventHandler(this.btn_allTime_Click);
            // 
            // m_btnHR
            // 
            this.m_btnHR.BackColor = System.Drawing.Color.Transparent;
            this.m_btnHR.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btnHR.DownBack = null;
            this.m_btnHR.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_btnHR.Location = new System.Drawing.Point(37, 147);
            this.m_btnHR.MouseBack = null;
            this.m_btnHR.Name = "m_btnHR";
            this.m_btnHR.NormlBack = null;
            this.m_btnHR.Size = new System.Drawing.Size(89, 46);
            this.m_btnHR.TabIndex = 16;
            this.m_btnHR.Text = "人员管理";
            this.m_btnHR.UseVisualStyleBackColor = false;
            this.m_btnHR.Click += new System.EventHandler(this.m_btnHR_Click);
            // 
            // m_btnClasses
            // 
            this.m_btnClasses.BackColor = System.Drawing.Color.Transparent;
            this.m_btnClasses.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btnClasses.DownBack = null;
            this.m_btnClasses.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_btnClasses.Location = new System.Drawing.Point(670, 232);
            this.m_btnClasses.MouseBack = null;
            this.m_btnClasses.Name = "m_btnClasses";
            this.m_btnClasses.NormlBack = null;
            this.m_btnClasses.Size = new System.Drawing.Size(89, 46);
            this.m_btnClasses.TabIndex = 17;
            this.m_btnClasses.Text = "学习计划分配";
            this.m_btnClasses.UseVisualStyleBackColor = false;
            this.m_btnClasses.Click += new System.EventHandler(this.m_btnClasses_Click);
            // 
            // btn_uploadclasses
            // 
            this.btn_uploadclasses.BackColor = System.Drawing.Color.Transparent;
            this.btn_uploadclasses.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_uploadclasses.DownBack = null;
            this.btn_uploadclasses.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_uploadclasses.Location = new System.Drawing.Point(670, 147);
            this.btn_uploadclasses.MouseBack = null;
            this.btn_uploadclasses.Name = "btn_uploadclasses";
            this.btn_uploadclasses.NormlBack = null;
            this.btn_uploadclasses.Size = new System.Drawing.Size(89, 46);
            this.btn_uploadclasses.TabIndex = 18;
            this.btn_uploadclasses.Text = "上传课程";
            this.btn_uploadclasses.UseVisualStyleBackColor = false;
            this.btn_uploadclasses.Click += new System.EventHandler(this.btn_uploadclasses_Click);
            // 
            // p_btnHome
            // 
            this.p_btnHome.BackColor = System.Drawing.Color.Transparent;
            this.p_btnHome.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnHome.DownBack = null;
            this.p_btnHome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_btnHome.Location = new System.Drawing.Point(679, 556);
            this.p_btnHome.MouseBack = null;
            this.p_btnHome.Name = "p_btnHome";
            this.p_btnHome.NormlBack = null;
            this.p_btnHome.Size = new System.Drawing.Size(91, 37);
            this.p_btnHome.TabIndex = 19;
            this.p_btnHome.Text = "返回主页";
            this.p_btnHome.UseVisualStyleBackColor = false;
            this.p_btnHome.Click += new System.EventHandler(this.p_btnHome_Click);
            // 
            // m_btn_plan_manage
            // 
            this.m_btn_plan_manage.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_plan_manage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btn_plan_manage.DownBack = null;
            this.m_btn_plan_manage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_btn_plan_manage.Location = new System.Drawing.Point(670, 321);
            this.m_btn_plan_manage.MouseBack = null;
            this.m_btn_plan_manage.Name = "m_btn_plan_manage";
            this.m_btn_plan_manage.NormlBack = null;
            this.m_btn_plan_manage.Size = new System.Drawing.Size(89, 46);
            this.m_btn_plan_manage.TabIndex = 20;
            this.m_btn_plan_manage.Text = "学习计划管理";
            this.m_btn_plan_manage.UseVisualStyleBackColor = false;
            this.m_btn_plan_manage.Click += new System.EventHandler(this.m_btn_plan_manage_Click);
            // 
            // m_flp_announcement
            // 
            this.m_flp_announcement.AutoScroll = true;
            this.m_flp_announcement.Location = new System.Drawing.Point(152, 131);
            this.m_flp_announcement.Name = "m_flp_announcement";
            this.m_flp_announcement.Size = new System.Drawing.Size(492, 265);
            this.m_flp_announcement.TabIndex = 21;
            // 
            // m_btn_Announce
            // 
            this.m_btn_Announce.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_Announce.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btn_Announce.DownBack = null;
            this.m_btn_Announce.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_btn_Announce.Location = new System.Drawing.Point(37, 321);
            this.m_btn_Announce.MouseBack = null;
            this.m_btn_Announce.Name = "m_btn_Announce";
            this.m_btn_Announce.NormlBack = null;
            this.m_btn_Announce.Size = new System.Drawing.Size(89, 46);
            this.m_btn_Announce.TabIndex = 22;
            this.m_btn_Announce.Text = "发布公告";
            this.m_btn_Announce.UseVisualStyleBackColor = false;
            this.m_btn_Announce.Click += new System.EventHandler(this.m_btn_Announce_Click);
            // 
            // m_tBx_announcement
            // 
            this.m_tBx_announcement.BackColor = System.Drawing.Color.SkyBlue;
            this.m_tBx_announcement.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.m_tBx_announcement.Location = new System.Drawing.Point(152, 412);
            this.m_tBx_announcement.Margin = new System.Windows.Forms.Padding(2);
            this.m_tBx_announcement.Multiline = true;
            this.m_tBx_announcement.Name = "m_tBx_announcement";
            this.m_tBx_announcement.Size = new System.Drawing.Size(492, 78);
            this.m_tBx_announcement.TabIndex = 34;
            // 
            // m_lbl_announcement
            // 
            this.m_lbl_announcement.AutoSize = true;
            this.m_lbl_announcement.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_lbl_announcement.Location = new System.Drawing.Point(57, 443);
            this.m_lbl_announcement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbl_announcement.Name = "m_lbl_announcement";
            this.m_lbl_announcement.Size = new System.Drawing.Size(68, 17);
            this.m_lbl_announcement.TabIndex = 35;
            this.m_lbl_announcement.Text = "公告正文：";
            // 
            // m_btn_release
            // 
            this.m_btn_release.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_release.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btn_release.DownBack = null;
            this.m_btn_release.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_btn_release.Location = new System.Drawing.Point(355, 517);
            this.m_btn_release.MouseBack = null;
            this.m_btn_release.Name = "m_btn_release";
            this.m_btn_release.NormlBack = null;
            this.m_btn_release.Size = new System.Drawing.Size(65, 37);
            this.m_btn_release.TabIndex = 36;
            this.m_btn_release.Text = "发布";
            this.m_btn_release.UseVisualStyleBackColor = false;
            this.m_btn_release.Click += new System.EventHandler(this.m_btn_release_Click);
            // 
            // m_lbl_ann
            // 
            this.m_lbl_ann.AutoSize = true;
            this.m_lbl_ann.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_ann.Location = new System.Drawing.Point(150, 97);
            this.m_lbl_ann.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbl_ann.Name = "m_lbl_ann";
            this.m_lbl_ann.Size = new System.Drawing.Size(79, 20);
            this.m_lbl_ann.TabIndex = 37;
            this.m_lbl_ann.Text = "公告信息：";
            // 
            // m_btn_load_question
            // 
            this.m_btn_load_question.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_load_question.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.m_btn_load_question.DownBack = null;
            this.m_btn_load_question.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.m_btn_load_question.Location = new System.Drawing.Point(670, 404);
            this.m_btn_load_question.MouseBack = null;
            this.m_btn_load_question.Name = "m_btn_load_question";
            this.m_btn_load_question.NormlBack = null;
            this.m_btn_load_question.Size = new System.Drawing.Size(89, 46);
            this.m_btn_load_question.TabIndex = 38;
            this.m_btn_load_question.Text = "上传试题";
            this.m_btn_load_question.UseVisualStyleBackColor = false;
            this.m_btn_load_question.Click += new System.EventHandler(this.m_btn_load_question_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 618);
            this.ControlBox = false;
            this.Controls.Add(this.m_btn_load_question);
            this.Controls.Add(this.m_lbl_ann);
            this.Controls.Add(this.m_btn_release);
            this.Controls.Add(this.m_lbl_announcement);
            this.Controls.Add(this.m_tBx_announcement);
            this.Controls.Add(this.m_btn_Announce);
            this.Controls.Add(this.m_flp_announcement);
            this.Controls.Add(this.m_btn_plan_manage);
            this.Controls.Add(this.p_btnHome);
            this.Controls.Add(this.btn_uploadclasses);
            this.Controls.Add(this.m_btnClasses);
            this.Controls.Add(this.m_btnHR);
            this.Controls.Add(this.btn_allTime);
            this.Controls.Add(this.p_btnQuit);
            this.Controls.Add(this.p_lblCurPerson);
            this.Controls.Add(this.p_lblWelcome);
            this.Controls.Add(this.p_lblTitle);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_lblTitle;
        private System.Windows.Forms.Label p_lblCurPerson;
        private System.Windows.Forms.Label p_lblWelcome;
        private CCWin.SkinControl.SkinButton p_btnQuit;
        private CCWin.SkinControl.SkinButton btn_allTime;
        private CCWin.SkinControl.SkinButton m_btnHR;
        private CCWin.SkinControl.SkinButton m_btnClasses;
        private CCWin.SkinControl.SkinButton btn_uploadclasses;
        private CCWin.SkinControl.SkinButton p_btnHome;
        private CCWin.SkinControl.SkinButton m_btn_plan_manage;
        private System.Windows.Forms.FlowLayoutPanel m_flp_announcement;
        private CCWin.SkinControl.SkinButton m_btn_Announce;
        private System.Windows.Forms.TextBox m_tBx_announcement;
        private System.Windows.Forms.Label m_lbl_announcement;
        private CCWin.SkinControl.SkinButton m_btn_release;
        private System.Windows.Forms.Label m_lbl_ann;
        private CCWin.SkinControl.SkinButton m_btn_load_question;
    }
}