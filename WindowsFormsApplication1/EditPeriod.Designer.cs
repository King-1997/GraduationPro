namespace WindowsFormsApplication1
{
    partial class EditPeriod
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
            this.ep_lbl_Plan_Name = new System.Windows.Forms.Label();
            this.ep_lbl_Plan_Summary = new System.Windows.Forms.Label();
            this.ep_tBx_Head_Summary = new System.Windows.Forms.TextBox();
            this.ep_btn_addPeroid = new CCWin.SkinControl.SkinButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ep_btn_back = new CCWin.SkinControl.SkinButton();
            this.ep_lbl_Emp_Type = new System.Windows.Forms.Label();
            this.ep_tBx_Emp_type = new System.Windows.Forms.TextBox();
            this.ep_tBx_Plan_Name = new System.Windows.Forms.TextBox();
            this.ep_btn_confirm = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // ep_lbl_Plan_Name
            // 
            this.ep_lbl_Plan_Name.AutoSize = true;
            this.ep_lbl_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Plan_Name.Location = new System.Drawing.Point(43, 52);
            this.ep_lbl_Plan_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Plan_Name.Name = "ep_lbl_Plan_Name";
            this.ep_lbl_Plan_Name.Size = new System.Drawing.Size(80, 17);
            this.ep_lbl_Plan_Name.TabIndex = 3;
            this.ep_lbl_Plan_Name.Text = "学习计划名：";
            // 
            // ep_lbl_Plan_Summary
            // 
            this.ep_lbl_Plan_Summary.AutoSize = true;
            this.ep_lbl_Plan_Summary.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Plan_Summary.Location = new System.Drawing.Point(43, 123);
            this.ep_lbl_Plan_Summary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Plan_Summary.Name = "ep_lbl_Plan_Summary";
            this.ep_lbl_Plan_Summary.Size = new System.Drawing.Size(92, 17);
            this.ep_lbl_Plan_Summary.TabIndex = 5;
            this.ep_lbl_Plan_Summary.Text = "学习计划简介：";
            // 
            // ep_tBx_Head_Summary
            // 
            this.ep_tBx_Head_Summary.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Head_Summary.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Head_Summary.Location = new System.Drawing.Point(141, 93);
            this.ep_tBx_Head_Summary.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Head_Summary.Multiline = true;
            this.ep_tBx_Head_Summary.Name = "ep_tBx_Head_Summary";
            this.ep_tBx_Head_Summary.ReadOnly = true;
            this.ep_tBx_Head_Summary.Size = new System.Drawing.Size(350, 78);
            this.ep_tBx_Head_Summary.TabIndex = 11;
            // 
            // ep_btn_addPeroid
            // 
            this.ep_btn_addPeroid.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_addPeroid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_addPeroid.DownBack = null;
            this.ep_btn_addPeroid.Location = new System.Drawing.Point(46, 419);
            this.ep_btn_addPeroid.MouseBack = null;
            this.ep_btn_addPeroid.Name = "ep_btn_addPeroid";
            this.ep_btn_addPeroid.NormlBack = null;
            this.ep_btn_addPeroid.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_addPeroid.TabIndex = 25;
            this.ep_btn_addPeroid.Text = "添加阶段";
            this.ep_btn_addPeroid.UseVisualStyleBackColor = false;
            this.ep_btn_addPeroid.Click += new System.EventHandler(this.ep_btn_addPeroid_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(679, 160);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // ep_btn_back
            // 
            this.ep_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_back.DownBack = null;
            this.ep_btn_back.Location = new System.Drawing.Point(729, 465);
            this.ep_btn_back.MouseBack = null;
            this.ep_btn_back.Name = "ep_btn_back";
            this.ep_btn_back.NormlBack = null;
            this.ep_btn_back.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_back.TabIndex = 27;
            this.ep_btn_back.Text = "返回";
            this.ep_btn_back.UseVisualStyleBackColor = false;
            this.ep_btn_back.Click += new System.EventHandler(this.ep_btn_back_Click);
            // 
            // ep_lbl_Emp_Type
            // 
            this.ep_lbl_Emp_Type.AutoSize = true;
            this.ep_lbl_Emp_Type.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ep_lbl_Emp_Type.Location = new System.Drawing.Point(43, 200);
            this.ep_lbl_Emp_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ep_lbl_Emp_Type.Name = "ep_lbl_Emp_Type";
            this.ep_lbl_Emp_Type.Size = new System.Drawing.Size(92, 17);
            this.ep_lbl_Emp_Type.TabIndex = 28;
            this.ep_lbl_Emp_Type.Text = "针对员工类型：";
            // 
            // ep_tBx_Emp_type
            // 
            this.ep_tBx_Emp_type.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Emp_type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Emp_type.Location = new System.Drawing.Point(141, 193);
            this.ep_tBx_Emp_type.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Emp_type.Name = "ep_tBx_Emp_type";
            this.ep_tBx_Emp_type.ReadOnly = true;
            this.ep_tBx_Emp_type.Size = new System.Drawing.Size(219, 29);
            this.ep_tBx_Emp_type.TabIndex = 29;
            // 
            // ep_tBx_Plan_Name
            // 
            this.ep_tBx_Plan_Name.BackColor = System.Drawing.Color.SkyBlue;
            this.ep_tBx_Plan_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ep_tBx_Plan_Name.Location = new System.Drawing.Point(141, 45);
            this.ep_tBx_Plan_Name.Margin = new System.Windows.Forms.Padding(2);
            this.ep_tBx_Plan_Name.Name = "ep_tBx_Plan_Name";
            this.ep_tBx_Plan_Name.ReadOnly = true;
            this.ep_tBx_Plan_Name.Size = new System.Drawing.Size(219, 29);
            this.ep_tBx_Plan_Name.TabIndex = 30;
            // 
            // ep_btn_confirm
            // 
            this.ep_btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.ep_btn_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ep_btn_confirm.DownBack = null;
            this.ep_btn_confirm.Location = new System.Drawing.Point(644, 465);
            this.ep_btn_confirm.MouseBack = null;
            this.ep_btn_confirm.Name = "ep_btn_confirm";
            this.ep_btn_confirm.NormlBack = null;
            this.ep_btn_confirm.Size = new System.Drawing.Size(70, 30);
            this.ep_btn_confirm.TabIndex = 31;
            this.ep_btn_confirm.Text = "确定";
            this.ep_btn_confirm.UseVisualStyleBackColor = false;
            this.ep_btn_confirm.Click += new System.EventHandler(this.ep_btn_confirm_Click);
            // 
            // EditPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 518);
            this.Controls.Add(this.ep_btn_confirm);
            this.Controls.Add(this.ep_tBx_Plan_Name);
            this.Controls.Add(this.ep_tBx_Emp_type);
            this.Controls.Add(this.ep_lbl_Emp_Type);
            this.Controls.Add(this.ep_btn_back);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ep_btn_addPeroid);
            this.Controls.Add(this.ep_tBx_Head_Summary);
            this.Controls.Add(this.ep_lbl_Plan_Summary);
            this.Controls.Add(this.ep_lbl_Plan_Name);
            this.Name = "EditPeriod";
            this.Text = "学习计划阶段管理";
            this.Load += new System.EventHandler(this.EditPeriod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ep_lbl_Plan_Name;
        private System.Windows.Forms.Label ep_lbl_Plan_Summary;
        private System.Windows.Forms.TextBox ep_tBx_Head_Summary;
        private CCWin.SkinControl.SkinButton ep_btn_addPeroid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CCWin.SkinControl.SkinButton ep_btn_back;
        private System.Windows.Forms.Label ep_lbl_Emp_Type;
        private System.Windows.Forms.TextBox ep_tBx_Emp_type;
        private System.Windows.Forms.TextBox ep_tBx_Plan_Name;
        private CCWin.SkinControl.SkinButton ep_btn_confirm;
    }
}