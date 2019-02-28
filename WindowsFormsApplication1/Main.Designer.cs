namespace WindowsFormsApplication1
{
    partial class Main
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
            this.m_btnPersonal = new System.Windows.Forms.Button();
            this.m_lblTitle = new System.Windows.Forms.Label();
            this.m_btnClass = new System.Windows.Forms.Button();
            this.m_btnManage = new System.Windows.Forms.Button();
            this.p_btnQuit = new System.Windows.Forms.Button();
            this.p_lblCurPerson = new System.Windows.Forms.Label();
            this.p_lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_btnPersonal
            // 
            this.m_btnPersonal.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnPersonal.Location = new System.Drawing.Point(66, 100);
            this.m_btnPersonal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnPersonal.Name = "m_btnPersonal";
            this.m_btnPersonal.Size = new System.Drawing.Size(132, 183);
            this.m_btnPersonal.TabIndex = 0;
            this.m_btnPersonal.Text = "个人中心";
            this.m_btnPersonal.UseVisualStyleBackColor = true;
            this.m_btnPersonal.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_lblTitle
            // 
            this.m_lblTitle.Enabled = false;
            this.m_lblTitle.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lblTitle.Location = new System.Drawing.Point(182, 37);
            this.m_lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_lblTitle.Name = "m_lblTitle";
            this.m_lblTitle.Size = new System.Drawing.Size(308, 38);
            this.m_lblTitle.TabIndex = 1;
            this.m_lblTitle.Text = "南昌科勒学习系统";
            this.m_lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // m_btnClass
            // 
            this.m_btnClass.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnClass.Location = new System.Drawing.Point(278, 100);
            this.m_btnClass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnClass.Name = "m_btnClass";
            this.m_btnClass.Size = new System.Drawing.Size(126, 183);
            this.m_btnClass.TabIndex = 2;
            this.m_btnClass.Text = "课程中心";
            this.m_btnClass.UseVisualStyleBackColor = true;
            this.m_btnClass.Click += new System.EventHandler(this.m_btnClass_Click);
            // 
            // m_btnManage
            // 
            this.m_btnManage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnManage.Location = new System.Drawing.Point(466, 100);
            this.m_btnManage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.m_btnManage.Name = "m_btnManage";
            this.m_btnManage.Size = new System.Drawing.Size(120, 183);
            this.m_btnManage.TabIndex = 3;
            this.m_btnManage.Text = "管理中心";
            this.m_btnManage.UseVisualStyleBackColor = true;
            this.m_btnManage.Click += new System.EventHandler(this.m_btnManage_Click);
            // 
            // p_btnQuit
            // 
            this.p_btnQuit.Font = new System.Drawing.Font("宋体", 9F);
            this.p_btnQuit.Location = new System.Drawing.Point(608, 37);
            this.p_btnQuit.Name = "p_btnQuit";
            this.p_btnQuit.Size = new System.Drawing.Size(60, 23);
            this.p_btnQuit.TabIndex = 6;
            this.p_btnQuit.Text = "注销";
            this.p_btnQuit.UseVisualStyleBackColor = true;
            this.p_btnQuit.Click += new System.EventHandler(this.p_btnQuit_Click);
            // 
            // p_lblCurPerson
            // 
            this.p_lblCurPerson.AutoSize = true;
            this.p_lblCurPerson.Font = new System.Drawing.Font("宋体", 9F);
            this.p_lblCurPerson.Location = new System.Drawing.Point(579, 42);
            this.p_lblCurPerson.Name = "p_lblCurPerson";
            this.p_lblCurPerson.Size = new System.Drawing.Size(31, 15);
            this.p_lblCurPerson.TabIndex = 5;
            this.p_lblCurPerson.Text = "XXX";
            // 
            // p_lblWelcome
            // 
            this.p_lblWelcome.AutoSize = true;
            this.p_lblWelcome.Font = new System.Drawing.Font("宋体", 9F);
            this.p_lblWelcome.Location = new System.Drawing.Point(533, 42);
            this.p_lblWelcome.Name = "p_lblWelcome";
            this.p_lblWelcome.Size = new System.Drawing.Size(67, 15);
            this.p_lblWelcome.TabIndex = 4;
            this.p_lblWelcome.Text = "欢迎您，";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(680, 537);
            this.Controls.Add(this.p_btnQuit);
            this.Controls.Add(this.p_lblCurPerson);
            this.Controls.Add(this.p_lblWelcome);
            this.Controls.Add(this.m_btnManage);
            this.Controls.Add(this.m_btnClass);
            this.Controls.Add(this.m_lblTitle);
            this.Controls.Add(this.m_btnPersonal);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnPersonal;
        private System.Windows.Forms.Label m_lblTitle;
        private System.Windows.Forms.Button m_btnClass;
        private System.Windows.Forms.Button m_btnManage;
        private System.Windows.Forms.Button p_btnQuit;
        private System.Windows.Forms.Label p_lblCurPerson;
        private System.Windows.Forms.Label p_lblWelcome;
    }
}