namespace WindowsFormsApplication1
{
    partial class ManagePlan
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
            this.mp_flp_PlanInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.mp_btn_reset = new CCWin.SkinControl.SkinButton();
            this.mp_btn_find = new CCWin.SkinControl.SkinButton();
            this.mp_lbl_keyword = new System.Windows.Forms.Label();
            this.mp_tBx_findkeywords = new System.Windows.Forms.TextBox();
            this.mp_btn_addPlan = new CCWin.SkinControl.SkinButton();
            this.mp_btn_back = new CCWin.SkinControl.SkinButton();
            this.mp_tBx_Plan_Name = new System.Windows.Forms.TextBox();
            this.mp_tBx_Emp_type = new System.Windows.Forms.TextBox();
            this.mp_lbl_Emp_Type = new System.Windows.Forms.Label();
            this.mp_tBx_Head_Summary = new System.Windows.Forms.TextBox();
            this.mp_lbl_Head_Summary = new System.Windows.Forms.Label();
            this.mp_lbl_Plan_Name = new System.Windows.Forms.Label();
            this.mp_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // mp_flp_PlanInfo
            // 
            this.mp_flp_PlanInfo.AutoScroll = true;
            this.mp_flp_PlanInfo.Location = new System.Drawing.Point(90, 106);
            this.mp_flp_PlanInfo.Name = "mp_flp_PlanInfo";
            this.mp_flp_PlanInfo.Size = new System.Drawing.Size(643, 144);
            this.mp_flp_PlanInfo.TabIndex = 16;
            // 
            // mp_btn_reset
            // 
            this.mp_btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_reset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_reset.DownBack = null;
            this.mp_btn_reset.Location = new System.Drawing.Point(562, 54);
            this.mp_btn_reset.MouseBack = null;
            this.mp_btn_reset.Name = "mp_btn_reset";
            this.mp_btn_reset.NormlBack = null;
            this.mp_btn_reset.Size = new System.Drawing.Size(56, 30);
            this.mp_btn_reset.TabIndex = 21;
            this.mp_btn_reset.Text = "重置";
            this.mp_btn_reset.UseVisualStyleBackColor = false;
            this.mp_btn_reset.Click += new System.EventHandler(this.mp_btn_reset_Click_1);
            // 
            // mp_btn_find
            // 
            this.mp_btn_find.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_find.DownBack = null;
            this.mp_btn_find.Location = new System.Drawing.Point(484, 54);
            this.mp_btn_find.MouseBack = null;
            this.mp_btn_find.Name = "mp_btn_find";
            this.mp_btn_find.NormlBack = null;
            this.mp_btn_find.Size = new System.Drawing.Size(56, 30);
            this.mp_btn_find.TabIndex = 20;
            this.mp_btn_find.Text = "查询";
            this.mp_btn_find.UseVisualStyleBackColor = false;
            this.mp_btn_find.Click += new System.EventHandler(this.mp_btn_find_Click);
            // 
            // mp_lbl_keyword
            // 
            this.mp_lbl_keyword.AutoSize = true;
            this.mp_lbl_keyword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_lbl_keyword.Location = new System.Drawing.Point(101, 59);
            this.mp_lbl_keyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mp_lbl_keyword.Name = "mp_lbl_keyword";
            this.mp_lbl_keyword.Size = new System.Drawing.Size(138, 21);
            this.mp_lbl_keyword.TabIndex = 19;
            this.mp_lbl_keyword.Text = "请您输入关键字：";
            // 
            // mp_tBx_findkeywords
            // 
            this.mp_tBx_findkeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_tBx_findkeywords.Location = new System.Drawing.Point(239, 55);
            this.mp_tBx_findkeywords.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tBx_findkeywords.Name = "mp_tBx_findkeywords";
            this.mp_tBx_findkeywords.Size = new System.Drawing.Size(219, 29);
            this.mp_tBx_findkeywords.TabIndex = 17;
            // 
            // mp_btn_addPlan
            // 
            this.mp_btn_addPlan.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_addPlan.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_addPlan.DownBack = null;
            this.mp_btn_addPlan.Location = new System.Drawing.Point(643, 54);
            this.mp_btn_addPlan.MouseBack = null;
            this.mp_btn_addPlan.Name = "mp_btn_addPlan";
            this.mp_btn_addPlan.NormlBack = null;
            this.mp_btn_addPlan.Size = new System.Drawing.Size(72, 30);
            this.mp_btn_addPlan.TabIndex = 22;
            this.mp_btn_addPlan.Text = "新增计划";
            this.mp_btn_addPlan.UseVisualStyleBackColor = false;
            this.mp_btn_addPlan.Click += new System.EventHandler(this.mp_btn_addPlan_Click);
            // 
            // mp_btn_back
            // 
            this.mp_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_back.DownBack = null;
            this.mp_btn_back.Location = new System.Drawing.Point(674, 462);
            this.mp_btn_back.MouseBack = null;
            this.mp_btn_back.Name = "mp_btn_back";
            this.mp_btn_back.NormlBack = null;
            this.mp_btn_back.Size = new System.Drawing.Size(91, 37);
            this.mp_btn_back.TabIndex = 23;
            this.mp_btn_back.Text = "返回";
            this.mp_btn_back.UseVisualStyleBackColor = false;
            this.mp_btn_back.Click += new System.EventHandler(this.mp_btn_back_Click);
            // 
            // mp_tBx_Plan_Name
            // 
            this.mp_tBx_Plan_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.mp_tBx_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_tBx_Plan_Name.Location = new System.Drawing.Point(155, 275);
            this.mp_tBx_Plan_Name.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tBx_Plan_Name.Name = "mp_tBx_Plan_Name";
            this.mp_tBx_Plan_Name.Size = new System.Drawing.Size(219, 29);
            this.mp_tBx_Plan_Name.TabIndex = 36;
            // 
            // mp_tBx_Emp_type
            // 
            this.mp_tBx_Emp_type.BackColor = System.Drawing.Color.SkyBlue;
            this.mp_tBx_Emp_type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_tBx_Emp_type.Location = new System.Drawing.Point(155, 423);
            this.mp_tBx_Emp_type.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tBx_Emp_type.Name = "mp_tBx_Emp_type";
            this.mp_tBx_Emp_type.Size = new System.Drawing.Size(219, 29);
            this.mp_tBx_Emp_type.TabIndex = 35;
            // 
            // mp_lbl_Emp_Type
            // 
            this.mp_lbl_Emp_Type.AutoSize = true;
            this.mp_lbl_Emp_Type.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Emp_Type.Location = new System.Drawing.Point(57, 430);
            this.mp_lbl_Emp_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Emp_Type.Name = "mp_lbl_Emp_Type";
            this.mp_lbl_Emp_Type.Size = new System.Drawing.Size(92, 17);
            this.mp_lbl_Emp_Type.TabIndex = 34;
            this.mp_lbl_Emp_Type.Text = "针对员工类型：";
            // 
            // mp_tBx_Head_Summary
            // 
            this.mp_tBx_Head_Summary.BackColor = System.Drawing.Color.SkyBlue;
            this.mp_tBx_Head_Summary.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_tBx_Head_Summary.Location = new System.Drawing.Point(155, 323);
            this.mp_tBx_Head_Summary.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tBx_Head_Summary.Multiline = true;
            this.mp_tBx_Head_Summary.Name = "mp_tBx_Head_Summary";
            this.mp_tBx_Head_Summary.Size = new System.Drawing.Size(350, 78);
            this.mp_tBx_Head_Summary.TabIndex = 33;
            // 
            // mp_lbl_Head_Summary
            // 
            this.mp_lbl_Head_Summary.AutoSize = true;
            this.mp_lbl_Head_Summary.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Head_Summary.Location = new System.Drawing.Point(57, 353);
            this.mp_lbl_Head_Summary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Head_Summary.Name = "mp_lbl_Head_Summary";
            this.mp_lbl_Head_Summary.Size = new System.Drawing.Size(92, 17);
            this.mp_lbl_Head_Summary.TabIndex = 32;
            this.mp_lbl_Head_Summary.Text = "学习计划简介：";
            // 
            // mp_lbl_Plan_Name
            // 
            this.mp_lbl_Plan_Name.AutoSize = true;
            this.mp_lbl_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Plan_Name.Location = new System.Drawing.Point(57, 282);
            this.mp_lbl_Plan_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Plan_Name.Name = "mp_lbl_Plan_Name";
            this.mp_lbl_Plan_Name.Size = new System.Drawing.Size(80, 17);
            this.mp_lbl_Plan_Name.TabIndex = 31;
            this.mp_lbl_Plan_Name.Text = "学习计划名：";
            // 
            // mp_btn_confirm
            // 
            this.mp_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_confirm.DownBack = null;
            this.mp_btn_confirm.Location = new System.Drawing.Point(562, 462);
            this.mp_btn_confirm.MouseBack = null;
            this.mp_btn_confirm.Name = "mp_btn_confirm";
            this.mp_btn_confirm.NormlBack = null;
            this.mp_btn_confirm.Size = new System.Drawing.Size(91, 37);
            this.mp_btn_confirm.TabIndex = 37;
            this.mp_btn_confirm.Text = "确定";
            this.mp_btn_confirm.UseVisualStyleBackColor = false;
            this.mp_btn_confirm.Click += new System.EventHandler(this.mp_btn_confirm_Click);
            // 
            // ManagePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 529);
            this.Controls.Add(this.mp_btn_confirm);
            this.Controls.Add(this.mp_tBx_Plan_Name);
            this.Controls.Add(this.mp_tBx_Emp_type);
            this.Controls.Add(this.mp_lbl_Emp_Type);
            this.Controls.Add(this.mp_tBx_Head_Summary);
            this.Controls.Add(this.mp_lbl_Head_Summary);
            this.Controls.Add(this.mp_lbl_Plan_Name);
            this.Controls.Add(this.mp_btn_back);
            this.Controls.Add(this.mp_btn_addPlan);
            this.Controls.Add(this.mp_btn_reset);
            this.Controls.Add(this.mp_btn_find);
            this.Controls.Add(this.mp_lbl_keyword);
            this.Controls.Add(this.mp_tBx_findkeywords);
            this.Controls.Add(this.mp_flp_PlanInfo);
            this.Name = "ManagePlan";
            this.Text = "学习计划管理";
            this.Load += new System.EventHandler(this.ManagePlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel mp_flp_PlanInfo;
        private CCWin.SkinControl.SkinButton mp_btn_reset;
        private CCWin.SkinControl.SkinButton mp_btn_find;
        private System.Windows.Forms.Label mp_lbl_keyword;
        private System.Windows.Forms.TextBox mp_tBx_findkeywords;
        private CCWin.SkinControl.SkinButton mp_btn_addPlan;
        private CCWin.SkinControl.SkinButton mp_btn_back;
        private System.Windows.Forms.TextBox mp_tBx_Plan_Name;
        private System.Windows.Forms.TextBox mp_tBx_Emp_type;
        private System.Windows.Forms.Label mp_lbl_Emp_Type;
        private System.Windows.Forms.TextBox mp_tBx_Head_Summary;
        private System.Windows.Forms.Label mp_lbl_Head_Summary;
        private System.Windows.Forms.Label mp_lbl_Plan_Name;
        private CCWin.SkinControl.SkinButton mp_btn_confirm;
    }
}