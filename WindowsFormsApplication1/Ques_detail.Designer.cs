namespace WindowsFormsApplication1
{
    partial class Ques_detail
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
            this.pc_btn_return = new CCWin.SkinControl.SkinButton();
            this.btn_oK = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.btn_find = new CCWin.SkinControl.SkinButton();
            this.cbB_findKey = new CCWin.SkinControl.SkinComboBox();
            this.cBx_c_name = new CCWin.SkinControl.SkinComboBox();
            this.cBx_allSelect = new System.Windows.Forms.CheckBox();
            this.fLP_people = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBx_goal = new CCWin.SkinControl.SkinComboBox();
            this.qd_btn_reset = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // pc_btn_return
            // 
            this.pc_btn_return.BackColor = System.Drawing.Color.Transparent;
            this.pc_btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pc_btn_return.DownBack = null;
            this.pc_btn_return.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pc_btn_return.Location = new System.Drawing.Point(630, 525);
            this.pc_btn_return.MouseBack = null;
            this.pc_btn_return.Name = "pc_btn_return";
            this.pc_btn_return.NormlBack = null;
            this.pc_btn_return.Size = new System.Drawing.Size(91, 37);
            this.pc_btn_return.TabIndex = 40;
            this.pc_btn_return.Text = "返回";
            this.pc_btn_return.UseVisualStyleBackColor = false;
            // 
            // btn_oK
            // 
            this.btn_oK.BackColor = System.Drawing.Color.Transparent;
            this.btn_oK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_oK.DownBack = null;
            this.btn_oK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_oK.Location = new System.Drawing.Point(521, 525);
            this.btn_oK.MouseBack = null;
            this.btn_oK.Name = "btn_oK";
            this.btn_oK.NormlBack = null;
            this.btn_oK.Size = new System.Drawing.Size(91, 37);
            this.btn_oK.TabIndex = 39;
            this.btn_oK.Text = "确定";
            this.btn_oK.UseVisualStyleBackColor = false;
            this.btn_oK.Click += new System.EventHandler(this.btn_oK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_cancel.Location = new System.Drawing.Point(688, 88);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(56, 30);
            this.btn_cancel.TabIndex = 38;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_find.DownBack = null;
            this.btn_find.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_find.Location = new System.Drawing.Point(556, 87);
            this.btn_find.MouseBack = null;
            this.btn_find.Name = "btn_find";
            this.btn_find.NormlBack = null;
            this.btn_find.Size = new System.Drawing.Size(56, 30);
            this.btn_find.TabIndex = 37;
            this.btn_find.Text = "查询";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cbB_findKey
            // 
            this.cbB_findKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbB_findKey.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbB_findKey.FormattingEnabled = true;
            this.cbB_findKey.Location = new System.Drawing.Point(212, 87);
            this.cbB_findKey.Name = "cbB_findKey";
            this.cbB_findKey.Size = new System.Drawing.Size(112, 24);
            this.cbB_findKey.TabIndex = 36;
            this.cbB_findKey.WaterText = "";
            this.cbB_findKey.SelectedIndexChanged += new System.EventHandler(this.cbB_findKey_SelectedIndexChanged);
            // 
            // cBx_c_name
            // 
            this.cBx_c_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_c_name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_c_name.FormattingEnabled = true;
            this.cBx_c_name.Location = new System.Drawing.Point(330, 88);
            this.cBx_c_name.Name = "cBx_c_name";
            this.cBx_c_name.Size = new System.Drawing.Size(220, 24);
            this.cBx_c_name.TabIndex = 35;
            this.cBx_c_name.WaterText = "";
            // 
            // cBx_allSelect
            // 
            this.cBx_allSelect.AutoSize = true;
            this.cBx_allSelect.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cBx_allSelect.Location = new System.Drawing.Point(85, 476);
            this.cBx_allSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cBx_allSelect.Name = "cBx_allSelect";
            this.cBx_allSelect.Size = new System.Drawing.Size(61, 25);
            this.cBx_allSelect.TabIndex = 32;
            this.cBx_allSelect.Text = "全选";
            this.cBx_allSelect.UseVisualStyleBackColor = true;
            // 
            // fLP_people
            // 
            this.fLP_people.AutoScroll = true;
            this.fLP_people.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLP_people.Location = new System.Drawing.Point(85, 145);
            this.fLP_people.Margin = new System.Windows.Forms.Padding(4);
            this.fLP_people.Name = "fLP_people";
            this.fLP_people.Size = new System.Drawing.Size(570, 326);
            this.fLP_people.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(73, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "请您输入关键字：";
            // 
            // cBx_goal
            // 
            this.cBx_goal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_goal.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_goal.FormattingEnabled = true;
            this.cBx_goal.Location = new System.Drawing.Point(330, 58);
            this.cBx_goal.Name = "cBx_goal";
            this.cBx_goal.Size = new System.Drawing.Size(220, 24);
            this.cBx_goal.TabIndex = 41;
            this.cBx_goal.WaterText = "";
            // 
            // qd_btn_reset
            // 
            this.qd_btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.qd_btn_reset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.qd_btn_reset.DownBack = null;
            this.qd_btn_reset.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qd_btn_reset.Location = new System.Drawing.Point(622, 88);
            this.qd_btn_reset.MouseBack = null;
            this.qd_btn_reset.Name = "qd_btn_reset";
            this.qd_btn_reset.NormlBack = null;
            this.qd_btn_reset.Size = new System.Drawing.Size(56, 30);
            this.qd_btn_reset.TabIndex = 42;
            this.qd_btn_reset.Text = "重置";
            this.qd_btn_reset.UseVisualStyleBackColor = false;
            this.qd_btn_reset.Click += new System.EventHandler(this.qd_btn_reset_Click);
            // 
            // Ques_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 574);
            this.Controls.Add(this.qd_btn_reset);
            this.Controls.Add(this.cBx_goal);
            this.Controls.Add(this.pc_btn_return);
            this.Controls.Add(this.btn_oK);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.cbB_findKey);
            this.Controls.Add(this.cBx_c_name);
            this.Controls.Add(this.cBx_allSelect);
            this.Controls.Add(this.fLP_people);
            this.Controls.Add(this.label1);
            this.Name = "Ques_detail";
            this.Text = "Ques_detail";
            this.Load += new System.EventHandler(this.Ques_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton pc_btn_return;
        private CCWin.SkinControl.SkinButton btn_oK;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private CCWin.SkinControl.SkinButton btn_find;
        private CCWin.SkinControl.SkinComboBox cbB_findKey;
        private CCWin.SkinControl.SkinComboBox cBx_c_name;
        private System.Windows.Forms.CheckBox cBx_allSelect;
        private System.Windows.Forms.FlowLayoutPanel fLP_people;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinComboBox cBx_goal;
        private CCWin.SkinControl.SkinButton qd_btn_reset;
    }
}