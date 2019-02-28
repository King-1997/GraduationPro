namespace WindowsFormsApplication1
{
    partial class News
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
            this.N_lbl_NameLbl = new CCWin.SkinControl.SkinLabel();
            this.N_lbl_Name = new CCWin.SkinControl.SkinLabel();
            this.N_lbl_TypeLbl = new CCWin.SkinControl.SkinLabel();
            this.N_lbl_ReasonLbl = new CCWin.SkinControl.SkinLabel();
            this.N_lbl_IfAgree = new CCWin.SkinControl.SkinLabel();
            this.N_cbx_IfAgree = new CCWin.SkinControl.SkinComboBox();
            this.N_lbl_DisAgreeLbl = new CCWin.SkinControl.SkinLabel();
            this.N_tbx_DisAgree = new CCWin.SkinControl.SkinTextBox();
            this.N_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.N_btn_cancel = new CCWin.SkinControl.SkinButton();
            this.N_lbl_Group = new CCWin.SkinControl.SkinLabel();
            this.N_lbl_GroupLbl = new CCWin.SkinControl.SkinLabel();
            this.N_tbx_Reason = new CCWin.SkinControl.SkinTextBox();
            this.N_lbl_Type = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // p_lblTitle
            // 
            this.p_lblTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.p_lblTitle.Location = new System.Drawing.Point(26, 39);
            this.p_lblTitle.Name = "p_lblTitle";
            this.p_lblTitle.Size = new System.Drawing.Size(168, 42);
            this.p_lblTitle.TabIndex = 2;
            this.p_lblTitle.Text = "消息中心";
            // 
            // N_lbl_NameLbl
            // 
            this.N_lbl_NameLbl.AutoSize = true;
            this.N_lbl_NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_NameLbl.BorderColor = System.Drawing.Color.White;
            this.N_lbl_NameLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_NameLbl.Location = new System.Drawing.Point(150, 88);
            this.N_lbl_NameLbl.Name = "N_lbl_NameLbl";
            this.N_lbl_NameLbl.Size = new System.Drawing.Size(56, 17);
            this.N_lbl_NameLbl.TabIndex = 3;
            this.N_lbl_NameLbl.Text = "申请人：";
            // 
            // N_lbl_Name
            // 
            this.N_lbl_Name.AutoSize = true;
            this.N_lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_Name.BorderColor = System.Drawing.Color.White;
            this.N_lbl_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_Name.Location = new System.Drawing.Point(233, 88);
            this.N_lbl_Name.Name = "N_lbl_Name";
            this.N_lbl_Name.Size = new System.Drawing.Size(68, 17);
            this.N_lbl_Name.TabIndex = 4;
            this.N_lbl_Name.Text = "申请人名字";
            // 
            // N_lbl_TypeLbl
            // 
            this.N_lbl_TypeLbl.AutoSize = true;
            this.N_lbl_TypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_TypeLbl.BorderColor = System.Drawing.Color.White;
            this.N_lbl_TypeLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_TypeLbl.Location = new System.Drawing.Point(150, 152);
            this.N_lbl_TypeLbl.Name = "N_lbl_TypeLbl";
            this.N_lbl_TypeLbl.Size = new System.Drawing.Size(68, 17);
            this.N_lbl_TypeLbl.TabIndex = 5;
            this.N_lbl_TypeLbl.Text = "申请类别：";
            // 
            // N_lbl_ReasonLbl
            // 
            this.N_lbl_ReasonLbl.AutoSize = true;
            this.N_lbl_ReasonLbl.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_ReasonLbl.BorderColor = System.Drawing.Color.White;
            this.N_lbl_ReasonLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_ReasonLbl.Location = new System.Drawing.Point(150, 190);
            this.N_lbl_ReasonLbl.Name = "N_lbl_ReasonLbl";
            this.N_lbl_ReasonLbl.Size = new System.Drawing.Size(68, 17);
            this.N_lbl_ReasonLbl.TabIndex = 7;
            this.N_lbl_ReasonLbl.Text = "申请原因：";
            // 
            // N_lbl_IfAgree
            // 
            this.N_lbl_IfAgree.AutoSize = true;
            this.N_lbl_IfAgree.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_IfAgree.BorderColor = System.Drawing.Color.White;
            this.N_lbl_IfAgree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_IfAgree.Location = new System.Drawing.Point(150, 282);
            this.N_lbl_IfAgree.Name = "N_lbl_IfAgree";
            this.N_lbl_IfAgree.Size = new System.Drawing.Size(68, 17);
            this.N_lbl_IfAgree.TabIndex = 9;
            this.N_lbl_IfAgree.Text = "是否同意：";
            // 
            // N_cbx_IfAgree
            // 
            this.N_cbx_IfAgree.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.N_cbx_IfAgree.FormattingEnabled = true;
            this.N_cbx_IfAgree.Items.AddRange(new object[] {
            "同意",
            "驳回"});
            this.N_cbx_IfAgree.Location = new System.Drawing.Point(236, 279);
            this.N_cbx_IfAgree.Name = "N_cbx_IfAgree";
            this.N_cbx_IfAgree.Size = new System.Drawing.Size(95, 22);
            this.N_cbx_IfAgree.TabIndex = 10;
            this.N_cbx_IfAgree.WaterText = "";
            this.N_cbx_IfAgree.SelectedIndexChanged += new System.EventHandler(this.N_cbx_IfAgree_SelectedIndexChanged);
            // 
            // N_lbl_DisAgreeLbl
            // 
            this.N_lbl_DisAgreeLbl.AutoSize = true;
            this.N_lbl_DisAgreeLbl.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_DisAgreeLbl.BorderColor = System.Drawing.Color.White;
            this.N_lbl_DisAgreeLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_DisAgreeLbl.Location = new System.Drawing.Point(150, 315);
            this.N_lbl_DisAgreeLbl.Name = "N_lbl_DisAgreeLbl";
            this.N_lbl_DisAgreeLbl.Size = new System.Drawing.Size(68, 17);
            this.N_lbl_DisAgreeLbl.TabIndex = 11;
            this.N_lbl_DisAgreeLbl.Text = "驳回理由：";
            this.N_lbl_DisAgreeLbl.Visible = false;
            // 
            // N_tbx_DisAgree
            // 
            this.N_tbx_DisAgree.BackColor = System.Drawing.Color.Transparent;
            this.N_tbx_DisAgree.DownBack = null;
            this.N_tbx_DisAgree.Icon = null;
            this.N_tbx_DisAgree.IconIsButton = false;
            this.N_tbx_DisAgree.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.N_tbx_DisAgree.IsPasswordChat = '\0';
            this.N_tbx_DisAgree.IsSystemPasswordChar = false;
            this.N_tbx_DisAgree.Lines = new string[] {
        "理由"};
            this.N_tbx_DisAgree.Location = new System.Drawing.Point(236, 315);
            this.N_tbx_DisAgree.Margin = new System.Windows.Forms.Padding(0);
            this.N_tbx_DisAgree.MaxLength = 32767;
            this.N_tbx_DisAgree.MinimumSize = new System.Drawing.Size(28, 28);
            this.N_tbx_DisAgree.MouseBack = null;
            this.N_tbx_DisAgree.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.N_tbx_DisAgree.Multiline = true;
            this.N_tbx_DisAgree.Name = "N_tbx_DisAgree";
            this.N_tbx_DisAgree.NormlBack = null;
            this.N_tbx_DisAgree.Padding = new System.Windows.Forms.Padding(5);
            this.N_tbx_DisAgree.ReadOnly = false;
            this.N_tbx_DisAgree.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.N_tbx_DisAgree.Size = new System.Drawing.Size(273, 71);
            // 
            // 
            // 
            this.N_tbx_DisAgree.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.N_tbx_DisAgree.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_tbx_DisAgree.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.N_tbx_DisAgree.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.N_tbx_DisAgree.SkinTxt.Multiline = true;
            this.N_tbx_DisAgree.SkinTxt.Name = "BaseText";
            this.N_tbx_DisAgree.SkinTxt.Size = new System.Drawing.Size(263, 61);
            this.N_tbx_DisAgree.SkinTxt.TabIndex = 0;
            this.N_tbx_DisAgree.SkinTxt.Text = "理由";
            this.N_tbx_DisAgree.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.N_tbx_DisAgree.SkinTxt.WaterText = "";
            this.N_tbx_DisAgree.TabIndex = 9;
            this.N_tbx_DisAgree.Text = "理由";
            this.N_tbx_DisAgree.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.N_tbx_DisAgree.Visible = false;
            this.N_tbx_DisAgree.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.N_tbx_DisAgree.WaterText = "";
            this.N_tbx_DisAgree.WordWrap = true;
            // 
            // N_btn_confirm
            // 
            this.N_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.N_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.N_btn_confirm.DownBack = null;
            this.N_btn_confirm.Location = new System.Drawing.Point(508, 414);
            this.N_btn_confirm.MouseBack = null;
            this.N_btn_confirm.Name = "N_btn_confirm";
            this.N_btn_confirm.NormlBack = null;
            this.N_btn_confirm.Size = new System.Drawing.Size(75, 32);
            this.N_btn_confirm.TabIndex = 12;
            this.N_btn_confirm.Text = "确定";
            this.N_btn_confirm.UseVisualStyleBackColor = false;
            this.N_btn_confirm.Click += new System.EventHandler(this.N_btn_confirm_Click);
            // 
            // N_btn_cancel
            // 
            this.N_btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.N_btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.N_btn_cancel.DownBack = null;
            this.N_btn_cancel.Location = new System.Drawing.Point(600, 414);
            this.N_btn_cancel.MouseBack = null;
            this.N_btn_cancel.Name = "N_btn_cancel";
            this.N_btn_cancel.NormlBack = null;
            this.N_btn_cancel.Size = new System.Drawing.Size(75, 32);
            this.N_btn_cancel.TabIndex = 13;
            this.N_btn_cancel.Text = "取消";
            this.N_btn_cancel.UseVisualStyleBackColor = false;
            this.N_btn_cancel.Click += new System.EventHandler(this.N_btn_cancel_Click);
            // 
            // N_lbl_Group
            // 
            this.N_lbl_Group.AutoSize = true;
            this.N_lbl_Group.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_Group.BorderColor = System.Drawing.Color.White;
            this.N_lbl_Group.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_Group.Location = new System.Drawing.Point(233, 119);
            this.N_lbl_Group.Name = "N_lbl_Group";
            this.N_lbl_Group.Size = new System.Drawing.Size(68, 17);
            this.N_lbl_Group.TabIndex = 15;
            this.N_lbl_Group.Text = "申请人组别";
            // 
            // N_lbl_GroupLbl
            // 
            this.N_lbl_GroupLbl.AutoSize = true;
            this.N_lbl_GroupLbl.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_GroupLbl.BorderColor = System.Drawing.Color.White;
            this.N_lbl_GroupLbl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_GroupLbl.Location = new System.Drawing.Point(150, 119);
            this.N_lbl_GroupLbl.Name = "N_lbl_GroupLbl";
            this.N_lbl_GroupLbl.Size = new System.Drawing.Size(80, 17);
            this.N_lbl_GroupLbl.TabIndex = 14;
            this.N_lbl_GroupLbl.Text = "申请人组别：";
            // 
            // N_tbx_Reason
            // 
            this.N_tbx_Reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.N_tbx_Reason.DownBack = null;
            this.N_tbx_Reason.Icon = null;
            this.N_tbx_Reason.IconIsButton = false;
            this.N_tbx_Reason.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.N_tbx_Reason.IsPasswordChat = '\0';
            this.N_tbx_Reason.IsSystemPasswordChar = false;
            this.N_tbx_Reason.Lines = new string[] {
        "原因"};
            this.N_tbx_Reason.Location = new System.Drawing.Point(236, 190);
            this.N_tbx_Reason.Margin = new System.Windows.Forms.Padding(0);
            this.N_tbx_Reason.MaxLength = 32767;
            this.N_tbx_Reason.MinimumSize = new System.Drawing.Size(28, 28);
            this.N_tbx_Reason.MouseBack = null;
            this.N_tbx_Reason.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.N_tbx_Reason.Multiline = true;
            this.N_tbx_Reason.Name = "N_tbx_Reason";
            this.N_tbx_Reason.NormlBack = null;
            this.N_tbx_Reason.Padding = new System.Windows.Forms.Padding(5);
            this.N_tbx_Reason.ReadOnly = true;
            this.N_tbx_Reason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.N_tbx_Reason.Size = new System.Drawing.Size(273, 71);
            // 
            // 
            // 
            this.N_tbx_Reason.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.N_tbx_Reason.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_tbx_Reason.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.N_tbx_Reason.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.N_tbx_Reason.SkinTxt.Multiline = true;
            this.N_tbx_Reason.SkinTxt.Name = "BaseText";
            this.N_tbx_Reason.SkinTxt.ReadOnly = true;
            this.N_tbx_Reason.SkinTxt.Size = new System.Drawing.Size(263, 61);
            this.N_tbx_Reason.SkinTxt.TabIndex = 0;
            this.N_tbx_Reason.SkinTxt.Text = "原因";
            this.N_tbx_Reason.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.N_tbx_Reason.SkinTxt.WaterText = "";
            this.N_tbx_Reason.TabIndex = 8;
            this.N_tbx_Reason.Text = "原因";
            this.N_tbx_Reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.N_tbx_Reason.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.N_tbx_Reason.WaterText = "";
            this.N_tbx_Reason.WordWrap = true;
            // 
            // N_lbl_Type
            // 
            this.N_lbl_Type.AutoSize = true;
            this.N_lbl_Type.BackColor = System.Drawing.Color.Transparent;
            this.N_lbl_Type.BorderColor = System.Drawing.Color.White;
            this.N_lbl_Type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.N_lbl_Type.Location = new System.Drawing.Point(233, 152);
            this.N_lbl_Type.Name = "N_lbl_Type";
            this.N_lbl_Type.Size = new System.Drawing.Size(56, 17);
            this.N_lbl_Type.TabIndex = 16;
            this.N_lbl_Type.Text = "申请类型";
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 464);
            this.Controls.Add(this.N_lbl_Type);
            this.Controls.Add(this.N_lbl_Group);
            this.Controls.Add(this.N_lbl_GroupLbl);
            this.Controls.Add(this.N_btn_cancel);
            this.Controls.Add(this.N_btn_confirm);
            this.Controls.Add(this.N_tbx_DisAgree);
            this.Controls.Add(this.N_lbl_DisAgreeLbl);
            this.Controls.Add(this.N_cbx_IfAgree);
            this.Controls.Add(this.N_lbl_IfAgree);
            this.Controls.Add(this.N_tbx_Reason);
            this.Controls.Add(this.N_lbl_ReasonLbl);
            this.Controls.Add(this.N_lbl_TypeLbl);
            this.Controls.Add(this.N_lbl_Name);
            this.Controls.Add(this.N_lbl_NameLbl);
            this.Controls.Add(this.p_lblTitle);
            this.Name = "News";
            this.Text = "News";
            this.Load += new System.EventHandler(this.News_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_lblTitle;
        private CCWin.SkinControl.SkinLabel N_lbl_NameLbl;
        private CCWin.SkinControl.SkinLabel N_lbl_Name;
        private CCWin.SkinControl.SkinLabel N_lbl_TypeLbl;
        private CCWin.SkinControl.SkinLabel N_lbl_ReasonLbl;
        private CCWin.SkinControl.SkinLabel N_lbl_IfAgree;
        private CCWin.SkinControl.SkinComboBox N_cbx_IfAgree;
        private CCWin.SkinControl.SkinLabel N_lbl_DisAgreeLbl;
        private CCWin.SkinControl.SkinTextBox N_tbx_DisAgree;
        private CCWin.SkinControl.SkinButton N_btn_confirm;
        private CCWin.SkinControl.SkinButton N_btn_cancel;
        private CCWin.SkinControl.SkinLabel N_lbl_Group;
        private CCWin.SkinControl.SkinLabel N_lbl_GroupLbl;
        private CCWin.SkinControl.SkinTextBox N_tbx_Reason;
        private CCWin.SkinControl.SkinLabel N_lbl_Type;
    }
}