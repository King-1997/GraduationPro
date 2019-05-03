namespace WindowsFormsApplication1
{
    partial class PersonalForm
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
            this.p_lblWelcome = new System.Windows.Forms.Label();
            this.p_lblCurPerson = new System.Windows.Forms.Label();
            this.p_lbl_Name = new System.Windows.Forms.Label();
            this.p_lblName = new System.Windows.Forms.Label();
            this.p_lbl_Account = new System.Windows.Forms.Label();
            this.p_lblAccount = new System.Windows.Forms.Label();
            this.p_lbl_Group = new System.Windows.Forms.Label();
            this.p_lblGroup = new System.Windows.Forms.Label();
            this.p_lbl_Credit = new System.Windows.Forms.Label();
            this.p_lblCredit = new System.Windows.Forms.Label();
            this.p_lbl_MyClasses = new System.Windows.Forms.Label();
            this.p_lbl_Phone = new System.Windows.Forms.Label();
            this.p_flpClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.p_btnQuit = new CCWin.SkinControl.SkinButton();
            this.Btn_classfinished = new CCWin.SkinControl.SkinButton();
            this.btn_classunfinished = new CCWin.SkinControl.SkinButton();
            this.p_btnHome = new CCWin.SkinControl.SkinButton();
            this.p_lbl_Apply = new System.Windows.Forms.Label();
            this.Btn_ApplyUndisposed = new CCWin.SkinControl.SkinButton();
            this.Btn_MyApply = new CCWin.SkinControl.SkinButton();
            this.p_lbl_EntryTime = new System.Windows.Forms.Label();
            this.p_lblEntryTime = new System.Windows.Forms.Label();
            this.p_btnEdit = new CCWin.SkinControl.SkinButton();
            this.p_lbl_Email = new System.Windows.Forms.Label();
            this.p_txtBxEmail = new System.Windows.Forms.TextBox();
            this.p_txtBxPhone = new System.Windows.Forms.TextBox();
            this.p_btnSubmit = new CCWin.SkinControl.SkinButton();
            this.p_lbl_Score = new System.Windows.Forms.Label();
            this.p_tbx_Score = new System.Windows.Forms.TextBox();
            this.p_lbl_Prompt = new System.Windows.Forms.Label();
            this.p_tbx_prompt = new System.Windows.Forms.TextBox();
            this.p_btn_Submit = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // p_lblTitle
            // 
            this.p_lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this.p_lblTitle.Location = new System.Drawing.Point(17, 31);
            this.p_lblTitle.Name = "p_lblTitle";
            this.p_lblTitle.Size = new System.Drawing.Size(168, 42);
            this.p_lblTitle.TabIndex = 0;
            this.p_lblTitle.Text = "个人中心";
            // 
            // p_lblWelcome
            // 
            this.p_lblWelcome.AutoSize = true;
            this.p_lblWelcome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblWelcome.Location = new System.Drawing.Point(556, 42);
            this.p_lblWelcome.Name = "p_lblWelcome";
            this.p_lblWelcome.Size = new System.Drawing.Size(56, 17);
            this.p_lblWelcome.TabIndex = 1;
            this.p_lblWelcome.Text = "欢迎您，";
            // 
            // p_lblCurPerson
            // 
            this.p_lblCurPerson.AutoSize = true;
            this.p_lblCurPerson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCurPerson.Location = new System.Drawing.Point(618, 42);
            this.p_lblCurPerson.Name = "p_lblCurPerson";
            this.p_lblCurPerson.Size = new System.Drawing.Size(32, 17);
            this.p_lblCurPerson.TabIndex = 2;
            this.p_lblCurPerson.Text = "XXX";
            // 
            // p_lbl_Name
            // 
            this.p_lbl_Name.AutoSize = true;
            this.p_lbl_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Name.Location = new System.Drawing.Point(96, 89);
            this.p_lbl_Name.Name = "p_lbl_Name";
            this.p_lbl_Name.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Name.TabIndex = 5;
            this.p_lbl_Name.Text = "姓名：";
            // 
            // p_lblName
            // 
            this.p_lblName.AutoSize = true;
            this.p_lblName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblName.Location = new System.Drawing.Point(179, 89);
            this.p_lblName.Name = "p_lblName";
            this.p_lblName.Size = new System.Drawing.Size(32, 17);
            this.p_lblName.TabIndex = 6;
            this.p_lblName.Text = "张三";
            // 
            // p_lbl_Account
            // 
            this.p_lbl_Account.AutoSize = true;
            this.p_lbl_Account.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Account.Location = new System.Drawing.Point(96, 119);
            this.p_lbl_Account.Name = "p_lbl_Account";
            this.p_lbl_Account.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Account.TabIndex = 7;
            this.p_lbl_Account.Text = "工号：";
            // 
            // p_lblAccount
            // 
            this.p_lblAccount.AutoSize = true;
            this.p_lblAccount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblAccount.Location = new System.Drawing.Point(179, 119);
            this.p_lblAccount.Name = "p_lblAccount";
            this.p_lblAccount.Size = new System.Drawing.Size(36, 17);
            this.p_lblAccount.TabIndex = 8;
            this.p_lblAccount.Text = "1001";
            // 
            // p_lbl_Group
            // 
            this.p_lbl_Group.AutoSize = true;
            this.p_lbl_Group.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Group.Location = new System.Drawing.Point(96, 147);
            this.p_lbl_Group.Name = "p_lbl_Group";
            this.p_lbl_Group.Size = new System.Drawing.Size(68, 17);
            this.p_lbl_Group.TabIndex = 9;
            this.p_lbl_Group.Text = "所在部门：";
            // 
            // p_lblGroup
            // 
            this.p_lblGroup.AutoSize = true;
            this.p_lblGroup.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblGroup.Location = new System.Drawing.Point(179, 147);
            this.p_lblGroup.Name = "p_lblGroup";
            this.p_lblGroup.Size = new System.Drawing.Size(32, 17);
            this.p_lblGroup.TabIndex = 10;
            this.p_lblGroup.Text = "涂装";
            // 
            // p_lbl_Credit
            // 
            this.p_lbl_Credit.AutoSize = true;
            this.p_lbl_Credit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Credit.Location = new System.Drawing.Point(96, 177);
            this.p_lbl_Credit.Name = "p_lbl_Credit";
            this.p_lbl_Credit.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Credit.TabIndex = 11;
            this.p_lbl_Credit.Text = "学分：";
            // 
            // p_lblCredit
            // 
            this.p_lblCredit.AutoSize = true;
            this.p_lblCredit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCredit.Location = new System.Drawing.Point(179, 177);
            this.p_lblCredit.Name = "p_lblCredit";
            this.p_lblCredit.Size = new System.Drawing.Size(22, 17);
            this.p_lblCredit.TabIndex = 12;
            this.p_lblCredit.Text = "63";
            // 
            // p_lbl_MyClasses
            // 
            this.p_lbl_MyClasses.AutoSize = true;
            this.p_lbl_MyClasses.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_MyClasses.Location = new System.Drawing.Point(96, 233);
            this.p_lbl_MyClasses.Name = "p_lbl_MyClasses";
            this.p_lbl_MyClasses.Size = new System.Drawing.Size(68, 17);
            this.p_lbl_MyClasses.TabIndex = 13;
            this.p_lbl_MyClasses.Text = "我的课程：";
            // 
            // p_lbl_Phone
            // 
            this.p_lbl_Phone.AutoSize = true;
            this.p_lbl_Phone.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Phone.Location = new System.Drawing.Point(96, 270);
            this.p_lbl_Phone.Name = "p_lbl_Phone";
            this.p_lbl_Phone.Size = new System.Drawing.Size(68, 17);
            this.p_lbl_Phone.TabIndex = 16;
            this.p_lbl_Phone.Text = "电话号码：";
            // 
            // p_flpClasses
            // 
            this.p_flpClasses.AllowDrop = true;
            this.p_flpClasses.AutoScroll = true;
            this.p_flpClasses.Location = new System.Drawing.Point(99, 382);
            this.p_flpClasses.Name = "p_flpClasses";
            this.p_flpClasses.Size = new System.Drawing.Size(572, 154);
            this.p_flpClasses.TabIndex = 18;
            // 
            // p_btnQuit
            // 
            this.p_btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnQuit.DownBack = null;
            this.p_btnQuit.Location = new System.Drawing.Point(665, 34);
            this.p_btnQuit.MouseBack = null;
            this.p_btnQuit.Name = "p_btnQuit";
            this.p_btnQuit.NormlBack = null;
            this.p_btnQuit.Size = new System.Drawing.Size(61, 34);
            this.p_btnQuit.TabIndex = 19;
            this.p_btnQuit.Text = "注销";
            this.p_btnQuit.UseVisualStyleBackColor = false;
            this.p_btnQuit.Click += new System.EventHandler(this.p_btnQuit_Click);
            // 
            // Btn_classfinished
            // 
            this.Btn_classfinished.BackColor = System.Drawing.Color.Transparent;
            this.Btn_classfinished.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_classfinished.DownBack = null;
            this.Btn_classfinished.Location = new System.Drawing.Point(182, 224);
            this.Btn_classfinished.MouseBack = null;
            this.Btn_classfinished.Name = "Btn_classfinished";
            this.Btn_classfinished.NormlBack = null;
            this.Btn_classfinished.Size = new System.Drawing.Size(77, 34);
            this.Btn_classfinished.TabIndex = 20;
            this.Btn_classfinished.Text = "已完成";
            this.Btn_classfinished.UseVisualStyleBackColor = false;
            this.Btn_classfinished.Click += new System.EventHandler(this.Btn_classfinished_Click);
            // 
            // btn_classunfinished
            // 
            this.btn_classunfinished.BackColor = System.Drawing.Color.Transparent;
            this.btn_classunfinished.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_classunfinished.DownBack = null;
            this.btn_classunfinished.Location = new System.Drawing.Point(274, 224);
            this.btn_classunfinished.MouseBack = null;
            this.btn_classunfinished.Name = "btn_classunfinished";
            this.btn_classunfinished.NormlBack = null;
            this.btn_classunfinished.Size = new System.Drawing.Size(77, 34);
            this.btn_classunfinished.TabIndex = 21;
            this.btn_classunfinished.Text = "尚未完成";
            this.btn_classunfinished.UseVisualStyleBackColor = false;
            this.btn_classunfinished.Click += new System.EventHandler(this.btn_classunfinished_Click);
            // 
            // p_btnHome
            // 
            this.p_btnHome.BackColor = System.Drawing.Color.Transparent;
            this.p_btnHome.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnHome.DownBack = null;
            this.p_btnHome.Location = new System.Drawing.Point(717, 655);
            this.p_btnHome.MouseBack = null;
            this.p_btnHome.Name = "p_btnHome";
            this.p_btnHome.NormlBack = null;
            this.p_btnHome.Size = new System.Drawing.Size(73, 37);
            this.p_btnHome.TabIndex = 22;
            this.p_btnHome.Text = "返回主页";
            this.p_btnHome.UseVisualStyleBackColor = false;
            this.p_btnHome.Click += new System.EventHandler(this.p_btnHome_Click);
            // 
            // p_lbl_Apply
            // 
            this.p_lbl_Apply.AutoSize = true;
            this.p_lbl_Apply.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Apply.Location = new System.Drawing.Point(96, 339);
            this.p_lbl_Apply.Name = "p_lbl_Apply";
            this.p_lbl_Apply.Size = new System.Drawing.Size(68, 17);
            this.p_lbl_Apply.TabIndex = 23;
            this.p_lbl_Apply.Text = "请假申请：";
            // 
            // Btn_ApplyUndisposed
            // 
            this.Btn_ApplyUndisposed.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ApplyUndisposed.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_ApplyUndisposed.DownBack = null;
            this.Btn_ApplyUndisposed.Location = new System.Drawing.Point(182, 329);
            this.Btn_ApplyUndisposed.MouseBack = null;
            this.Btn_ApplyUndisposed.Name = "Btn_ApplyUndisposed";
            this.Btn_ApplyUndisposed.NormlBack = null;
            this.Btn_ApplyUndisposed.Size = new System.Drawing.Size(77, 34);
            this.Btn_ApplyUndisposed.TabIndex = 24;
            this.Btn_ApplyUndisposed.Text = "未处理";
            this.Btn_ApplyUndisposed.UseVisualStyleBackColor = false;
            this.Btn_ApplyUndisposed.Click += new System.EventHandler(this.Btn_ApplyUndisposed_Click);
            // 
            // Btn_MyApply
            // 
            this.Btn_MyApply.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MyApply.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_MyApply.DownBack = null;
            this.Btn_MyApply.Location = new System.Drawing.Point(274, 329);
            this.Btn_MyApply.MouseBack = null;
            this.Btn_MyApply.Name = "Btn_MyApply";
            this.Btn_MyApply.NormlBack = null;
            this.Btn_MyApply.Size = new System.Drawing.Size(77, 34);
            this.Btn_MyApply.TabIndex = 25;
            this.Btn_MyApply.Text = "我的申请";
            this.Btn_MyApply.UseVisualStyleBackColor = false;
            this.Btn_MyApply.Click += new System.EventHandler(this.Btn_MyApply_Click);
            // 
            // p_lbl_EntryTime
            // 
            this.p_lbl_EntryTime.AutoSize = true;
            this.p_lbl_EntryTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_EntryTime.Location = new System.Drawing.Point(96, 204);
            this.p_lbl_EntryTime.Name = "p_lbl_EntryTime";
            this.p_lbl_EntryTime.Size = new System.Drawing.Size(68, 17);
            this.p_lbl_EntryTime.TabIndex = 26;
            this.p_lbl_EntryTime.Text = "入职时间：";
            // 
            // p_lblEntryTime
            // 
            this.p_lblEntryTime.AutoSize = true;
            this.p_lblEntryTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblEntryTime.Location = new System.Drawing.Point(179, 204);
            this.p_lblEntryTime.Name = "p_lblEntryTime";
            this.p_lblEntryTime.Size = new System.Drawing.Size(36, 17);
            this.p_lblEntryTime.TabIndex = 27;
            this.p_lblEntryTime.Text = "2342";
            // 
            // p_btnEdit
            // 
            this.p_btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnEdit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnEdit.DownBack = null;
            this.p_btnEdit.Location = new System.Drawing.Point(565, 655);
            this.p_btnEdit.MouseBack = null;
            this.p_btnEdit.Name = "p_btnEdit";
            this.p_btnEdit.NormlBack = null;
            this.p_btnEdit.Size = new System.Drawing.Size(70, 37);
            this.p_btnEdit.TabIndex = 28;
            this.p_btnEdit.Text = "编辑";
            this.p_btnEdit.UseVisualStyleBackColor = false;
            this.p_btnEdit.Click += new System.EventHandler(this.p_btnEdit_Click);
            // 
            // p_lbl_Email
            // 
            this.p_lbl_Email.AutoSize = true;
            this.p_lbl_Email.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Email.Location = new System.Drawing.Point(96, 302);
            this.p_lbl_Email.Name = "p_lbl_Email";
            this.p_lbl_Email.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Email.TabIndex = 29;
            this.p_lbl_Email.Text = "邮箱：";
            // 
            // p_txtBxEmail
            // 
            this.p_txtBxEmail.BackColor = System.Drawing.Color.SkyBlue;
            this.p_txtBxEmail.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.p_txtBxEmail.Location = new System.Drawing.Point(182, 298);
            this.p_txtBxEmail.Name = "p_txtBxEmail";
            this.p_txtBxEmail.ReadOnly = true;
            this.p_txtBxEmail.Size = new System.Drawing.Size(154, 29);
            this.p_txtBxEmail.TabIndex = 30;
            // 
            // p_txtBxPhone
            // 
            this.p_txtBxPhone.BackColor = System.Drawing.Color.SkyBlue;
            this.p_txtBxPhone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.p_txtBxPhone.Location = new System.Drawing.Point(182, 266);
            this.p_txtBxPhone.Name = "p_txtBxPhone";
            this.p_txtBxPhone.ReadOnly = true;
            this.p_txtBxPhone.Size = new System.Drawing.Size(136, 29);
            this.p_txtBxPhone.TabIndex = 31;
            // 
            // p_btnSubmit
            // 
            this.p_btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnSubmit.DownBack = null;
            this.p_btnSubmit.Location = new System.Drawing.Point(641, 655);
            this.p_btnSubmit.MouseBack = null;
            this.p_btnSubmit.Name = "p_btnSubmit";
            this.p_btnSubmit.NormlBack = null;
            this.p_btnSubmit.Size = new System.Drawing.Size(70, 37);
            this.p_btnSubmit.TabIndex = 32;
            this.p_btnSubmit.Text = "确定";
            this.p_btnSubmit.UseVisualStyleBackColor = false;
            this.p_btnSubmit.Click += new System.EventHandler(this.p_btnSubmit_Click);
            // 
            // p_lbl_Score
            // 
            this.p_lbl_Score.AutoSize = true;
            this.p_lbl_Score.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Score.Location = new System.Drawing.Point(62, 565);
            this.p_lbl_Score.Name = "p_lbl_Score";
            this.p_lbl_Score.Size = new System.Drawing.Size(197, 17);
            this.p_lbl_Score.TabIndex = 33;
            this.p_lbl_Score.Text = "评分（请输入1-100之内的数字）：";
            // 
            // p_tbx_Score
            // 
            this.p_tbx_Score.BackColor = System.Drawing.Color.SkyBlue;
            this.p_tbx_Score.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.p_tbx_Score.Location = new System.Drawing.Point(265, 559);
            this.p_tbx_Score.Name = "p_tbx_Score";
            this.p_tbx_Score.Size = new System.Drawing.Size(86, 29);
            this.p_tbx_Score.TabIndex = 34;
            // 
            // p_lbl_Prompt
            // 
            this.p_lbl_Prompt.AutoSize = true;
            this.p_lbl_Prompt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Prompt.Location = new System.Drawing.Point(62, 629);
            this.p_lbl_Prompt.Name = "p_lbl_Prompt";
            this.p_lbl_Prompt.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Prompt.TabIndex = 35;
            this.p_lbl_Prompt.Text = "备注：";
            // 
            // p_tbx_prompt
            // 
            this.p_tbx_prompt.BackColor = System.Drawing.Color.SkyBlue;
            this.p_tbx_prompt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.p_tbx_prompt.Location = new System.Drawing.Point(99, 606);
            this.p_tbx_prompt.Margin = new System.Windows.Forms.Padding(2);
            this.p_tbx_prompt.Multiline = true;
            this.p_tbx_prompt.Name = "p_tbx_prompt";
            this.p_tbx_prompt.Size = new System.Drawing.Size(318, 63);
            this.p_tbx_prompt.TabIndex = 36;
            // 
            // p_btn_Submit
            // 
            this.p_btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.p_btn_Submit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btn_Submit.DownBack = null;
            this.p_btn_Submit.Location = new System.Drawing.Point(443, 581);
            this.p_btn_Submit.MouseBack = null;
            this.p_btn_Submit.Name = "p_btn_Submit";
            this.p_btn_Submit.NormlBack = null;
            this.p_btn_Submit.Size = new System.Drawing.Size(70, 37);
            this.p_btn_Submit.TabIndex = 37;
            this.p_btn_Submit.Text = "提交";
            this.p_btn_Submit.UseVisualStyleBackColor = false;
            this.p_btn_Submit.Click += new System.EventHandler(this.p_btn_Submit_Click);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 715);
            this.ControlBox = false;
            this.Controls.Add(this.p_btn_Submit);
            this.Controls.Add(this.p_tbx_prompt);
            this.Controls.Add(this.p_lbl_Prompt);
            this.Controls.Add(this.p_tbx_Score);
            this.Controls.Add(this.p_lbl_Score);
            this.Controls.Add(this.p_btnSubmit);
            this.Controls.Add(this.p_txtBxPhone);
            this.Controls.Add(this.p_btnEdit);
            this.Controls.Add(this.p_txtBxEmail);
            this.Controls.Add(this.p_lbl_Email);
            this.Controls.Add(this.p_lblEntryTime);
            this.Controls.Add(this.p_lbl_EntryTime);
            this.Controls.Add(this.Btn_MyApply);
            this.Controls.Add(this.Btn_ApplyUndisposed);
            this.Controls.Add(this.p_lbl_Apply);
            this.Controls.Add(this.p_btnHome);
            this.Controls.Add(this.btn_classunfinished);
            this.Controls.Add(this.Btn_classfinished);
            this.Controls.Add(this.p_btnQuit);
            this.Controls.Add(this.p_flpClasses);
            this.Controls.Add(this.p_lbl_Phone);
            this.Controls.Add(this.p_lbl_MyClasses);
            this.Controls.Add(this.p_lblCredit);
            this.Controls.Add(this.p_lbl_Credit);
            this.Controls.Add(this.p_lblGroup);
            this.Controls.Add(this.p_lbl_Account);
            this.Controls.Add(this.p_lbl_Name);
            this.Controls.Add(this.p_lbl_Group);
            this.Controls.Add(this.p_lblAccount);
            this.Controls.Add(this.p_lblName);
            this.Controls.Add(this.p_lblCurPerson);
            this.Controls.Add(this.p_lblWelcome);
            this.Controls.Add(this.p_lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PersonalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_lblTitle;
        private System.Windows.Forms.Label p_lblWelcome;
        private System.Windows.Forms.Label p_lblCurPerson;
        private System.Windows.Forms.Label p_lbl_Name;
        private System.Windows.Forms.Label p_lblName;
        private System.Windows.Forms.Label p_lbl_Account;
        private System.Windows.Forms.Label p_lblAccount;
        private System.Windows.Forms.Label p_lbl_Group;
        private System.Windows.Forms.Label p_lblGroup;
        private System.Windows.Forms.Label p_lbl_Credit;
        private System.Windows.Forms.Label p_lblCredit;
        private System.Windows.Forms.Label p_lbl_MyClasses;
        private System.Windows.Forms.Label p_lbl_Phone;
        private System.Windows.Forms.FlowLayoutPanel p_flpClasses;
        private CCWin.SkinControl.SkinButton p_btnQuit;
        private CCWin.SkinControl.SkinButton Btn_classfinished;
        private CCWin.SkinControl.SkinButton btn_classunfinished;
        private CCWin.SkinControl.SkinButton p_btnHome;
        private System.Windows.Forms.Label p_lbl_Apply;
        private CCWin.SkinControl.SkinButton Btn_ApplyUndisposed;
        private CCWin.SkinControl.SkinButton Btn_MyApply;
        private System.Windows.Forms.Label p_lbl_EntryTime;
        private System.Windows.Forms.Label p_lblEntryTime;
        private CCWin.SkinControl.SkinButton p_btnEdit;
        private System.Windows.Forms.Label p_lbl_Email;
        private System.Windows.Forms.TextBox p_txtBxEmail;
        private System.Windows.Forms.TextBox p_txtBxPhone;
        private CCWin.SkinControl.SkinButton p_btnSubmit;
        private System.Windows.Forms.Label p_lbl_Score;
        private System.Windows.Forms.TextBox p_tbx_Score;
        private System.Windows.Forms.Label p_lbl_Prompt;
        private System.Windows.Forms.TextBox p_tbx_prompt;
        private CCWin.SkinControl.SkinButton p_btn_Submit;
    }
}