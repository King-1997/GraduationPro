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
            this.cp_flpClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.cp_btn_reset = new CCWin.SkinControl.SkinButton();
            this.cp_btn_find = new CCWin.SkinControl.SkinButton();
            this.cp_lbl_keyword = new System.Windows.Forms.Label();
            this.cp_tBx_findkeywords = new System.Windows.Forms.TextBox();
            this.cp_btn_addPlan = new CCWin.SkinControl.SkinButton();
            this.cp_btn_back = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // cp_flpClasses
            // 
            this.cp_flpClasses.AutoScroll = true;
            this.cp_flpClasses.Location = new System.Drawing.Point(91, 106);
            this.cp_flpClasses.Name = "cp_flpClasses";
            this.cp_flpClasses.Size = new System.Drawing.Size(624, 228);
            this.cp_flpClasses.TabIndex = 16;
            // 
            // cp_btn_reset
            // 
            this.cp_btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.cp_btn_reset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cp_btn_reset.DownBack = null;
            this.cp_btn_reset.Location = new System.Drawing.Point(562, 54);
            this.cp_btn_reset.MouseBack = null;
            this.cp_btn_reset.Name = "cp_btn_reset";
            this.cp_btn_reset.NormlBack = null;
            this.cp_btn_reset.Size = new System.Drawing.Size(56, 30);
            this.cp_btn_reset.TabIndex = 21;
            this.cp_btn_reset.Text = "重置";
            this.cp_btn_reset.UseVisualStyleBackColor = false;
            this.cp_btn_reset.Click += new System.EventHandler(this.cp_btn_reset_Click);
            // 
            // cp_btn_find
            // 
            this.cp_btn_find.BackColor = System.Drawing.Color.Transparent;
            this.cp_btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cp_btn_find.DownBack = null;
            this.cp_btn_find.Location = new System.Drawing.Point(484, 54);
            this.cp_btn_find.MouseBack = null;
            this.cp_btn_find.Name = "cp_btn_find";
            this.cp_btn_find.NormlBack = null;
            this.cp_btn_find.Size = new System.Drawing.Size(56, 30);
            this.cp_btn_find.TabIndex = 20;
            this.cp_btn_find.Text = "查询";
            this.cp_btn_find.UseVisualStyleBackColor = false;
            this.cp_btn_find.Click += new System.EventHandler(this.cp_btn_find_Click);
            // 
            // cp_lbl_keyword
            // 
            this.cp_lbl_keyword.AutoSize = true;
            this.cp_lbl_keyword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cp_lbl_keyword.Location = new System.Drawing.Point(101, 59);
            this.cp_lbl_keyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cp_lbl_keyword.Name = "cp_lbl_keyword";
            this.cp_lbl_keyword.Size = new System.Drawing.Size(138, 21);
            this.cp_lbl_keyword.TabIndex = 19;
            this.cp_lbl_keyword.Text = "请您输入关键字：";
            // 
            // cp_tBx_findkeywords
            // 
            this.cp_tBx_findkeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cp_tBx_findkeywords.Location = new System.Drawing.Point(239, 55);
            this.cp_tBx_findkeywords.Margin = new System.Windows.Forms.Padding(2);
            this.cp_tBx_findkeywords.Name = "cp_tBx_findkeywords";
            this.cp_tBx_findkeywords.Size = new System.Drawing.Size(219, 29);
            this.cp_tBx_findkeywords.TabIndex = 17;
            // 
            // cp_btn_addPlan
            // 
            this.cp_btn_addPlan.BackColor = System.Drawing.Color.Transparent;
            this.cp_btn_addPlan.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cp_btn_addPlan.DownBack = null;
            this.cp_btn_addPlan.Location = new System.Drawing.Point(641, 54);
            this.cp_btn_addPlan.MouseBack = null;
            this.cp_btn_addPlan.Name = "cp_btn_addPlan";
            this.cp_btn_addPlan.NormlBack = null;
            this.cp_btn_addPlan.Size = new System.Drawing.Size(56, 30);
            this.cp_btn_addPlan.TabIndex = 22;
            this.cp_btn_addPlan.Text = "新增";
            this.cp_btn_addPlan.UseVisualStyleBackColor = false;
            // 
            // cp_btn_back
            // 
            this.cp_btn_back.BackColor = System.Drawing.Color.Transparent;
            this.cp_btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cp_btn_back.DownBack = null;
            this.cp_btn_back.Location = new System.Drawing.Point(674, 462);
            this.cp_btn_back.MouseBack = null;
            this.cp_btn_back.Name = "cp_btn_back";
            this.cp_btn_back.NormlBack = null;
            this.cp_btn_back.Size = new System.Drawing.Size(91, 37);
            this.cp_btn_back.TabIndex = 23;
            this.cp_btn_back.Text = "返回";
            this.cp_btn_back.UseVisualStyleBackColor = false;
            this.cp_btn_back.Click += new System.EventHandler(this.cp_btn_back_Click);
            // 
            // ManagePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 529);
            this.Controls.Add(this.cp_btn_back);
            this.Controls.Add(this.cp_btn_addPlan);
            this.Controls.Add(this.cp_btn_reset);
            this.Controls.Add(this.cp_btn_find);
            this.Controls.Add(this.cp_lbl_keyword);
            this.Controls.Add(this.cp_tBx_findkeywords);
            this.Controls.Add(this.cp_flpClasses);
            this.Name = "ManagePlan";
            this.Text = "学习计划管理";
            this.Load += new System.EventHandler(this.CreatePlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel cp_flpClasses;
        private CCWin.SkinControl.SkinButton cp_btn_reset;
        private CCWin.SkinControl.SkinButton cp_btn_find;
        private System.Windows.Forms.Label cp_lbl_keyword;
        private System.Windows.Forms.TextBox cp_tBx_findkeywords;
        private CCWin.SkinControl.SkinButton cp_btn_addPlan;
        private CCWin.SkinControl.SkinButton cp_btn_back;
    }
}