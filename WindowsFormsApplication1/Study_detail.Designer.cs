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
            this.SuspendLayout();
            // 
            // sd_flp_detail
            // 
            this.sd_flp_detail.AllowDrop = true;
            this.sd_flp_detail.AutoScroll = true;
            this.sd_flp_detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sd_flp_detail.Location = new System.Drawing.Point(55, 116);
            this.sd_flp_detail.Name = "sd_flp_detail";
            this.sd_flp_detail.Size = new System.Drawing.Size(722, 287);
            this.sd_flp_detail.TabIndex = 19;
            // 
            // sd_btn_Return
            // 
            this.sd_btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.sd_btn_Return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sd_btn_Return.DownBack = null;
            this.sd_btn_Return.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.sd_btn_Return.Location = new System.Drawing.Point(721, 448);
            this.sd_btn_Return.MouseBack = null;
            this.sd_btn_Return.Name = "sd_btn_Return";
            this.sd_btn_Return.NormlBack = null;
            this.sd_btn_Return.Size = new System.Drawing.Size(73, 37);
            this.sd_btn_Return.TabIndex = 20;
            this.sd_btn_Return.Text = "返回";
            this.sd_btn_Return.UseVisualStyleBackColor = false;
            this.sd_btn_Return.Click += new System.EventHandler(this.sd_btn_Return_Click);
            // 
            // Study_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 506);
            this.Controls.Add(this.sd_btn_Return);
            this.Controls.Add(this.sd_flp_detail);
            this.Name = "Study_detail";
            this.Text = "学习详情";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sd_flp_detail;
        private CCWin.SkinControl.SkinButton sd_btn_Return;
    }
}