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
            this.mp_lbl_Emp_dpt = new System.Windows.Forms.Label();
            this.mp_tBx_Head_Summary = new System.Windows.Forms.TextBox();
            this.mp_lbl_Head_Summary = new System.Windows.Forms.Label();
            this.mp_lbl_Plan_Name = new System.Windows.Forms.Label();
            this.mp_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.mp_lbl_Emp_station = new System.Windows.Forms.Label();
            this.mp_tbx_Emp_station = new CCWin.SkinControl.SkinComboBox();
            this.mp_tbx_Emp_dpt = new CCWin.SkinControl.SkinComboBox();
            this.mp_tbx_Emp_type = new CCWin.SkinControl.SkinComboBox();
            this.mp_lbl_Emp_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mp_flp_PlanInfo
            // 
            this.mp_flp_PlanInfo.AutoScroll = true;
            this.mp_flp_PlanInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mp_flp_PlanInfo.Location = new System.Drawing.Point(65, 114);
            this.mp_flp_PlanInfo.Name = "mp_flp_PlanInfo";
            this.mp_flp_PlanInfo.Size = new System.Drawing.Size(735, 144);
            this.mp_flp_PlanInfo.TabIndex = 16;
            // 
            // mp_btn_reset
            // 
            this.mp_btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_reset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_reset.DownBack = null;
            this.mp_btn_reset.Location = new System.Drawing.Point(580, 59);
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
            this.mp_btn_find.Location = new System.Drawing.Point(499, 59);
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
            this.mp_lbl_keyword.Location = new System.Drawing.Point(116, 64);
            this.mp_lbl_keyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mp_lbl_keyword.Name = "mp_lbl_keyword";
            this.mp_lbl_keyword.Size = new System.Drawing.Size(138, 21);
            this.mp_lbl_keyword.TabIndex = 19;
            this.mp_lbl_keyword.Text = "请您输入关键字：";
            // 
            // mp_tBx_findkeywords
            // 
            this.mp_tBx_findkeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_tBx_findkeywords.Location = new System.Drawing.Point(254, 60);
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
            this.mp_btn_addPlan.Location = new System.Drawing.Point(658, 59);
            this.mp_btn_addPlan.MouseBack = null;
            this.mp_btn_addPlan.Name = "mp_btn_addPlan";
            this.mp_btn_addPlan.NormlBack = null;
            this.mp_btn_addPlan.Size = new System.Drawing.Size(72, 30);
            this.mp_btn_addPlan.TabIndex = 22;
            this.mp_btn_addPlan.Text = "新增阶段";
            this.mp_btn_addPlan.UseVisualStyleBackColor = false;
            this.mp_btn_addPlan.Click += new System.EventHandler(this.mp_btn_addPlan_Click);
            // 
            // mp_btn_back
            // 
            this.mp_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_back.DownBack = null;
            this.mp_btn_back.Location = new System.Drawing.Point(728, 563);
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
            this.mp_tBx_Plan_Name.Location = new System.Drawing.Point(191, 283);
            this.mp_tBx_Plan_Name.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tBx_Plan_Name.Name = "mp_tBx_Plan_Name";
            this.mp_tBx_Plan_Name.Size = new System.Drawing.Size(217, 29);
            this.mp_tBx_Plan_Name.TabIndex = 36;
            // 
            // mp_lbl_Emp_dpt
            // 
            this.mp_lbl_Emp_dpt.AutoSize = true;
            this.mp_lbl_Emp_dpt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Emp_dpt.Location = new System.Drawing.Point(93, 438);
            this.mp_lbl_Emp_dpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Emp_dpt.Name = "mp_lbl_Emp_dpt";
            this.mp_lbl_Emp_dpt.Size = new System.Drawing.Size(68, 17);
            this.mp_lbl_Emp_dpt.TabIndex = 34;
            this.mp_lbl_Emp_dpt.Text = "针对部门：";
            // 
            // mp_tBx_Head_Summary
            // 
            this.mp_tBx_Head_Summary.BackColor = System.Drawing.Color.SkyBlue;
            this.mp_tBx_Head_Summary.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mp_tBx_Head_Summary.Location = new System.Drawing.Point(191, 331);
            this.mp_tBx_Head_Summary.Margin = new System.Windows.Forms.Padding(2);
            this.mp_tBx_Head_Summary.Multiline = true;
            this.mp_tBx_Head_Summary.Name = "mp_tBx_Head_Summary";
            this.mp_tBx_Head_Summary.Size = new System.Drawing.Size(352, 78);
            this.mp_tBx_Head_Summary.TabIndex = 33;
            // 
            // mp_lbl_Head_Summary
            // 
            this.mp_lbl_Head_Summary.AutoSize = true;
            this.mp_lbl_Head_Summary.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Head_Summary.Location = new System.Drawing.Point(93, 361);
            this.mp_lbl_Head_Summary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Head_Summary.Name = "mp_lbl_Head_Summary";
            this.mp_lbl_Head_Summary.Size = new System.Drawing.Size(92, 17);
            this.mp_lbl_Head_Summary.TabIndex = 32;
            this.mp_lbl_Head_Summary.Text = "学习阶段简介：";
            // 
            // mp_lbl_Plan_Name
            // 
            this.mp_lbl_Plan_Name.AutoSize = true;
            this.mp_lbl_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Plan_Name.Location = new System.Drawing.Point(93, 290);
            this.mp_lbl_Plan_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Plan_Name.Name = "mp_lbl_Plan_Name";
            this.mp_lbl_Plan_Name.Size = new System.Drawing.Size(80, 17);
            this.mp_lbl_Plan_Name.TabIndex = 31;
            this.mp_lbl_Plan_Name.Text = "学习阶段名：";
            // 
            // mp_btn_confirm
            // 
            this.mp_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.mp_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mp_btn_confirm.DownBack = null;
            this.mp_btn_confirm.Location = new System.Drawing.Point(616, 563);
            this.mp_btn_confirm.MouseBack = null;
            this.mp_btn_confirm.Name = "mp_btn_confirm";
            this.mp_btn_confirm.NormlBack = null;
            this.mp_btn_confirm.Size = new System.Drawing.Size(91, 37);
            this.mp_btn_confirm.TabIndex = 37;
            this.mp_btn_confirm.Text = "确定";
            this.mp_btn_confirm.UseVisualStyleBackColor = false;
            this.mp_btn_confirm.Click += new System.EventHandler(this.mp_btn_confirm_Click);
            // 
            // mp_lbl_Emp_station
            // 
            this.mp_lbl_Emp_station.AutoSize = true;
            this.mp_lbl_Emp_station.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Emp_station.Location = new System.Drawing.Point(93, 523);
            this.mp_lbl_Emp_station.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Emp_station.Name = "mp_lbl_Emp_station";
            this.mp_lbl_Emp_station.Size = new System.Drawing.Size(92, 17);
            this.mp_lbl_Emp_station.TabIndex = 38;
            this.mp_lbl_Emp_station.Text = "针对员工岗位：";
            // 
            // mp_tbx_Emp_station
            // 
            this.mp_tbx_Emp_station.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mp_tbx_Emp_station.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mp_tbx_Emp_station.FormattingEnabled = true;
            this.mp_tbx_Emp_station.Location = new System.Drawing.Point(191, 517);
            this.mp_tbx_Emp_station.Name = "mp_tbx_Emp_station";
            this.mp_tbx_Emp_station.Size = new System.Drawing.Size(138, 27);
            this.mp_tbx_Emp_station.TabIndex = 39;
            this.mp_tbx_Emp_station.WaterText = "";
            // 
            // mp_tbx_Emp_dpt
            // 
            this.mp_tbx_Emp_dpt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mp_tbx_Emp_dpt.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mp_tbx_Emp_dpt.FormattingEnabled = true;
            this.mp_tbx_Emp_dpt.Location = new System.Drawing.Point(191, 432);
            this.mp_tbx_Emp_dpt.Name = "mp_tbx_Emp_dpt";
            this.mp_tbx_Emp_dpt.Size = new System.Drawing.Size(138, 27);
            this.mp_tbx_Emp_dpt.TabIndex = 40;
            this.mp_tbx_Emp_dpt.WaterText = "";
            // 
            // mp_tbx_Emp_type
            // 
            this.mp_tbx_Emp_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.mp_tbx_Emp_type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mp_tbx_Emp_type.FormattingEnabled = true;
            this.mp_tbx_Emp_type.Location = new System.Drawing.Point(191, 475);
            this.mp_tbx_Emp_type.Name = "mp_tbx_Emp_type";
            this.mp_tbx_Emp_type.Size = new System.Drawing.Size(138, 27);
            this.mp_tbx_Emp_type.TabIndex = 42;
            this.mp_tbx_Emp_type.WaterText = "";
            // 
            // mp_lbl_Emp_type
            // 
            this.mp_lbl_Emp_type.AutoSize = true;
            this.mp_lbl_Emp_type.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mp_lbl_Emp_type.Location = new System.Drawing.Point(93, 481);
            this.mp_lbl_Emp_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mp_lbl_Emp_type.Name = "mp_lbl_Emp_type";
            this.mp_lbl_Emp_type.Size = new System.Drawing.Size(92, 17);
            this.mp_lbl_Emp_type.TabIndex = 41;
            this.mp_lbl_Emp_type.Text = "针对员工类型：";
            // 
            // ManagePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 622);
            this.Controls.Add(this.mp_tbx_Emp_type);
            this.Controls.Add(this.mp_lbl_Emp_type);
            this.Controls.Add(this.mp_tbx_Emp_dpt);
            this.Controls.Add(this.mp_tbx_Emp_station);
            this.Controls.Add(this.mp_lbl_Emp_station);
            this.Controls.Add(this.mp_btn_confirm);
            this.Controls.Add(this.mp_tBx_Plan_Name);
            this.Controls.Add(this.mp_lbl_Emp_dpt);
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
            this.Text = "学习阶段管理";
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
        private System.Windows.Forms.Label mp_lbl_Emp_dpt;
        private System.Windows.Forms.TextBox mp_tBx_Head_Summary;
        private System.Windows.Forms.Label mp_lbl_Head_Summary;
        private System.Windows.Forms.Label mp_lbl_Plan_Name;
        private CCWin.SkinControl.SkinButton mp_btn_confirm;
        private System.Windows.Forms.Label mp_lbl_Emp_station;
        private CCWin.SkinControl.SkinComboBox mp_tbx_Emp_station;
        private CCWin.SkinControl.SkinComboBox mp_tbx_Emp_dpt;
        private CCWin.SkinControl.SkinComboBox mp_tbx_Emp_type;
        private System.Windows.Forms.Label mp_lbl_Emp_type;
    }
}