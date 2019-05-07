namespace WindowsFormsApplication1
{
    partial class Announce
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
            this.a_tbx_title = new System.Windows.Forms.TextBox();
            this.l_lbl_title = new System.Windows.Forms.Label();
            this.l_lbl_announcement = new System.Windows.Forms.Label();
            this.a_tBx_announcement = new System.Windows.Forms.TextBox();
            this.a_lbl_release_name = new System.Windows.Forms.Label();
            this.a_lbl_releaseName = new System.Windows.Forms.Label();
            this.a_btn_return = new CCWin.SkinControl.SkinButton();
            this.a_lbl_releaseTime = new System.Windows.Forms.Label();
            this.a_lbl_release_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a_tbx_title
            // 
            this.a_tbx_title.BackColor = System.Drawing.Color.SkyBlue;
            this.a_tbx_title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.a_tbx_title.Location = new System.Drawing.Point(150, 131);
            this.a_tbx_title.Margin = new System.Windows.Forms.Padding(2);
            this.a_tbx_title.Multiline = true;
            this.a_tbx_title.Name = "a_tbx_title";
            this.a_tbx_title.ReadOnly = true;
            this.a_tbx_title.Size = new System.Drawing.Size(219, 38);
            this.a_tbx_title.TabIndex = 44;
            // 
            // l_lbl_title
            // 
            this.l_lbl_title.AutoSize = true;
            this.l_lbl_title.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.l_lbl_title.Location = new System.Drawing.Point(56, 139);
            this.l_lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_lbl_title.Name = "l_lbl_title";
            this.l_lbl_title.Size = new System.Drawing.Size(68, 17);
            this.l_lbl_title.TabIndex = 43;
            this.l_lbl_title.Text = "公告标题：";
            // 
            // l_lbl_announcement
            // 
            this.l_lbl_announcement.AutoSize = true;
            this.l_lbl_announcement.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.l_lbl_announcement.Location = new System.Drawing.Point(56, 241);
            this.l_lbl_announcement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_lbl_announcement.Name = "l_lbl_announcement";
            this.l_lbl_announcement.Size = new System.Drawing.Size(68, 17);
            this.l_lbl_announcement.TabIndex = 42;
            this.l_lbl_announcement.Text = "公告正文：";
            // 
            // a_tBx_announcement
            // 
            this.a_tBx_announcement.BackColor = System.Drawing.Color.SkyBlue;
            this.a_tBx_announcement.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.a_tBx_announcement.Location = new System.Drawing.Point(150, 188);
            this.a_tBx_announcement.Margin = new System.Windows.Forms.Padding(2);
            this.a_tBx_announcement.Multiline = true;
            this.a_tBx_announcement.Name = "a_tBx_announcement";
            this.a_tBx_announcement.ReadOnly = true;
            this.a_tBx_announcement.Size = new System.Drawing.Size(361, 123);
            this.a_tBx_announcement.TabIndex = 41;
            // 
            // a_lbl_release_name
            // 
            this.a_lbl_release_name.AutoSize = true;
            this.a_lbl_release_name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.a_lbl_release_name.Location = new System.Drawing.Point(56, 61);
            this.a_lbl_release_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a_lbl_release_name.Name = "a_lbl_release_name";
            this.a_lbl_release_name.Size = new System.Drawing.Size(56, 17);
            this.a_lbl_release_name.TabIndex = 45;
            this.a_lbl_release_name.Text = "发布人：";
            // 
            // a_lbl_releaseName
            // 
            this.a_lbl_releaseName.AutoSize = true;
            this.a_lbl_releaseName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.a_lbl_releaseName.Location = new System.Drawing.Point(147, 61);
            this.a_lbl_releaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a_lbl_releaseName.Name = "a_lbl_releaseName";
            this.a_lbl_releaseName.Size = new System.Drawing.Size(44, 17);
            this.a_lbl_releaseName.TabIndex = 46;
            this.a_lbl_releaseName.Text = "发布人";
            // 
            // a_btn_return
            // 
            this.a_btn_return.BackColor = System.Drawing.Color.Transparent;
            this.a_btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.a_btn_return.DownBack = null;
            this.a_btn_return.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.a_btn_return.Location = new System.Drawing.Point(474, 346);
            this.a_btn_return.MouseBack = null;
            this.a_btn_return.Name = "a_btn_return";
            this.a_btn_return.NormlBack = null;
            this.a_btn_return.Size = new System.Drawing.Size(77, 37);
            this.a_btn_return.TabIndex = 47;
            this.a_btn_return.Text = "返回";
            this.a_btn_return.UseVisualStyleBackColor = false;
            this.a_btn_return.Click += new System.EventHandler(this.a_btn_return_Click);
            // 
            // a_lbl_releaseTime
            // 
            this.a_lbl_releaseTime.AutoSize = true;
            this.a_lbl_releaseTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.a_lbl_releaseTime.Location = new System.Drawing.Point(147, 99);
            this.a_lbl_releaseTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a_lbl_releaseTime.Name = "a_lbl_releaseTime";
            this.a_lbl_releaseTime.Size = new System.Drawing.Size(56, 17);
            this.a_lbl_releaseTime.TabIndex = 49;
            this.a_lbl_releaseTime.Text = "发布时间";
            // 
            // a_lbl_release_time
            // 
            this.a_lbl_release_time.AutoSize = true;
            this.a_lbl_release_time.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.a_lbl_release_time.Location = new System.Drawing.Point(56, 99);
            this.a_lbl_release_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a_lbl_release_time.Name = "a_lbl_release_time";
            this.a_lbl_release_time.Size = new System.Drawing.Size(68, 17);
            this.a_lbl_release_time.TabIndex = 48;
            this.a_lbl_release_time.Text = "发布时间：";
            // 
            // Announce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 406);
            this.Controls.Add(this.a_lbl_releaseTime);
            this.Controls.Add(this.a_lbl_release_time);
            this.Controls.Add(this.a_btn_return);
            this.Controls.Add(this.a_lbl_releaseName);
            this.Controls.Add(this.a_lbl_release_name);
            this.Controls.Add(this.a_tbx_title);
            this.Controls.Add(this.l_lbl_title);
            this.Controls.Add(this.l_lbl_announcement);
            this.Controls.Add(this.a_tBx_announcement);
            this.Name = "Announce";
            this.Text = "公告信息";
            this.Load += new System.EventHandler(this.Announce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a_tbx_title;
        private System.Windows.Forms.Label l_lbl_title;
        private System.Windows.Forms.Label l_lbl_announcement;
        private System.Windows.Forms.TextBox a_tBx_announcement;
        private System.Windows.Forms.Label a_lbl_release_name;
        private System.Windows.Forms.Label a_lbl_releaseName;
        private CCWin.SkinControl.SkinButton a_btn_return;
        private System.Windows.Forms.Label a_lbl_releaseTime;
        private System.Windows.Forms.Label a_lbl_release_time;
    }
}