namespace WindowsFormsApplication1
{
    partial class Study_detail
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
            this.sd_flp_detail = new System.Windows.Forms.FlowLayoutPanel();
            this.sd_btn_Return = new CCWin.SkinControl.SkinButton();
            this.cbB_findKey = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sd_ccb_group = new CCWin.SkinControl.SkinComboBox();
            this.mm_btn_all = new CCWin.SkinControl.SkinButton();
            this.btn_find = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // sd_flp_detail
            // 
            this.sd_flp_detail.AllowDrop = true;
            this.sd_flp_detail.AutoScroll = true;
            this.sd_flp_detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sd_flp_detail.Location = new System.Drawing.Point(47, 116);
            this.sd_flp_detail.Name = "sd_flp_detail";
            this.sd_flp_detail.Size = new System.Drawing.Size(752, 287);
            this.sd_flp_detail.TabIndex = 19;
            // 
            // sd_btn_Return
            // 
            this.sd_btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.sd_btn_Return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sd_btn_Return.DownBack = null;
            this.sd_btn_Return.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.sd_btn_Return.Location = new System.Drawing.Point(755, 502);
            this.sd_btn_Return.MouseBack = null;
            this.sd_btn_Return.Name = "sd_btn_Return";
            this.sd_btn_Return.NormlBack = null;
            this.sd_btn_Return.Size = new System.Drawing.Size(73, 37);
            this.sd_btn_Return.TabIndex = 20;
            this.sd_btn_Return.Text = "返回";
            this.sd_btn_Return.UseVisualStyleBackColor = false;
            this.sd_btn_Return.Click += new System.EventHandler(this.sd_btn_Return_Click);
            // 
            // cbB_findKey
            // 
            this.cbB_findKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbB_findKey.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbB_findKey.FormattingEnabled = true;
            this.cbB_findKey.Location = new System.Drawing.Point(276, 66);
            this.cbB_findKey.Name = "cbB_findKey";
            this.cbB_findKey.Size = new System.Drawing.Size(110, 24);
            this.cbB_findKey.TabIndex = 21;
            this.cbB_findKey.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(128, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "请您输入关键字：";
            // 
            // sd_ccb_group
            // 
            this.sd_ccb_group.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sd_ccb_group.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.sd_ccb_group.FormattingEnabled = true;
            this.sd_ccb_group.Location = new System.Drawing.Point(402, 66);
            this.sd_ccb_group.Name = "sd_ccb_group";
            this.sd_ccb_group.Size = new System.Drawing.Size(110, 24);
            this.sd_ccb_group.TabIndex = 23;
            this.sd_ccb_group.WaterText = "";
            // 
            // mm_btn_all
            // 
            this.mm_btn_all.BackColor = System.Drawing.Color.Transparent;
            this.mm_btn_all.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.mm_btn_all.DownBack = null;
            this.mm_btn_all.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.mm_btn_all.Location = new System.Drawing.Point(643, 64);
            this.mm_btn_all.MouseBack = null;
            this.mm_btn_all.Name = "mm_btn_all";
            this.mm_btn_all.NormlBack = null;
            this.mm_btn_all.Size = new System.Drawing.Size(50, 27);
            this.mm_btn_all.TabIndex = 25;
            this.mm_btn_all.Text = "重置";
            this.mm_btn_all.UseVisualStyleBackColor = false;
            this.mm_btn_all.Click += new System.EventHandler(this.mm_btn_all_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_find.DownBack = null;
            this.btn_find.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_find.Location = new System.Drawing.Point(554, 64);
            this.btn_find.MouseBack = null;
            this.btn_find.Name = "btn_find";
            this.btn_find.NormlBack = null;
            this.btn_find.Size = new System.Drawing.Size(53, 27);
            this.btn_find.TabIndex = 24;
            this.btn_find.Text = "查询";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // Study_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 558);
            this.Controls.Add(this.mm_btn_all);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.sd_ccb_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbB_findKey);
            this.Controls.Add(this.sd_btn_Return);
            this.Controls.Add(this.sd_flp_detail);
            this.Name = "Study_detail";
            this.Text = "学习详情";
            this.Load += new System.EventHandler(this.Study_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sd_flp_detail;
        private CCWin.SkinControl.SkinButton sd_btn_Return;
        private CCWin.SkinControl.SkinComboBox cbB_findKey;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinComboBox sd_ccb_group;
        private CCWin.SkinControl.SkinButton mm_btn_all;
        private CCWin.SkinControl.SkinButton btn_find;
    }
}