namespace WindowsFormsApplication1
{
    partial class ChooseLesson
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
            this.lbl_lessonName = new System.Windows.Forms.Label();
            this.lbl_lessonOwner = new System.Windows.Forms.Label();
            this.tBx_lessonName = new System.Windows.Forms.TextBox();
            this.tBx_lessonOwner = new System.Windows.Forms.TextBox();
            this.CL_flpClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Finding = new CCWin.SkinControl.SkinButton();
            this.btn_AllClasses = new CCWin.SkinControl.SkinButton();
            this.btn_deteminal = new CCWin.SkinControl.SkinButton();
            this.btn_return = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // lbl_lessonName
            // 
            this.lbl_lessonName.AutoSize = true;
            this.lbl_lessonName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_lessonName.Location = new System.Drawing.Point(90, 56);
            this.lbl_lessonName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lessonName.Name = "lbl_lessonName";
            this.lbl_lessonName.Size = new System.Drawing.Size(90, 21);
            this.lbl_lessonName.TabIndex = 0;
            this.lbl_lessonName.Text = "课程名称：";
            // 
            // lbl_lessonOwner
            // 
            this.lbl_lessonOwner.AutoSize = true;
            this.lbl_lessonOwner.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_lessonOwner.Location = new System.Drawing.Point(294, 56);
            this.lbl_lessonOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lessonOwner.Name = "lbl_lessonOwner";
            this.lbl_lessonOwner.Size = new System.Drawing.Size(74, 21);
            this.lbl_lessonOwner.TabIndex = 1;
            this.lbl_lessonOwner.Text = "上传人：";
            // 
            // tBx_lessonName
            // 
            this.tBx_lessonName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tBx_lessonName.Location = new System.Drawing.Point(181, 52);
            this.tBx_lessonName.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_lessonName.Name = "tBx_lessonName";
            this.tBx_lessonName.Size = new System.Drawing.Size(94, 29);
            this.tBx_lessonName.TabIndex = 2;
            // 
            // tBx_lessonOwner
            // 
            this.tBx_lessonOwner.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tBx_lessonOwner.Location = new System.Drawing.Point(368, 52);
            this.tBx_lessonOwner.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_lessonOwner.Name = "tBx_lessonOwner";
            this.tBx_lessonOwner.Size = new System.Drawing.Size(92, 29);
            this.tBx_lessonOwner.TabIndex = 3;
            // 
            // CL_flpClasses
            // 
            this.CL_flpClasses.AutoScroll = true;
            this.CL_flpClasses.Location = new System.Drawing.Point(79, 98);
            this.CL_flpClasses.Name = "CL_flpClasses";
            this.CL_flpClasses.Size = new System.Drawing.Size(610, 367);
            this.CL_flpClasses.TabIndex = 7;
            // 
            // btn_Finding
            // 
            this.btn_Finding.BackColor = System.Drawing.Color.Transparent;
            this.btn_Finding.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Finding.DownBack = null;
            this.btn_Finding.Location = new System.Drawing.Point(478, 48);
            this.btn_Finding.MouseBack = null;
            this.btn_Finding.Name = "btn_Finding";
            this.btn_Finding.NormlBack = null;
            this.btn_Finding.Size = new System.Drawing.Size(84, 35);
            this.btn_Finding.TabIndex = 10;
            this.btn_Finding.Text = "查找";
            this.btn_Finding.UseVisualStyleBackColor = false;
            this.btn_Finding.Click += new System.EventHandler(this.btn_Finding_Click);
            // 
            // btn_AllClasses
            // 
            this.btn_AllClasses.BackColor = System.Drawing.Color.Transparent;
            this.btn_AllClasses.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_AllClasses.DownBack = null;
            this.btn_AllClasses.Location = new System.Drawing.Point(579, 48);
            this.btn_AllClasses.MouseBack = null;
            this.btn_AllClasses.Name = "btn_AllClasses";
            this.btn_AllClasses.NormlBack = null;
            this.btn_AllClasses.Size = new System.Drawing.Size(84, 35);
            this.btn_AllClasses.TabIndex = 11;
            this.btn_AllClasses.Text = "全部课程";
            this.btn_AllClasses.UseVisualStyleBackColor = false;
            this.btn_AllClasses.Click += new System.EventHandler(this.btn_AllClasses_Click);
            // 
            // btn_deteminal
            // 
            this.btn_deteminal.BackColor = System.Drawing.Color.Transparent;
            this.btn_deteminal.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_deteminal.DownBack = null;
            this.btn_deteminal.Location = new System.Drawing.Point(548, 508);
            this.btn_deteminal.MouseBack = null;
            this.btn_deteminal.Name = "btn_deteminal";
            this.btn_deteminal.NormlBack = null;
            this.btn_deteminal.Size = new System.Drawing.Size(85, 32);
            this.btn_deteminal.TabIndex = 12;
            this.btn_deteminal.Text = "确定";
            this.btn_deteminal.UseVisualStyleBackColor = false;
            this.btn_deteminal.Click += new System.EventHandler(this.btn_deteminal_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_return.DownBack = null;
            this.btn_return.Location = new System.Drawing.Point(639, 508);
            this.btn_return.MouseBack = null;
            this.btn_return.Name = "btn_return";
            this.btn_return.NormlBack = null;
            this.btn_return.Size = new System.Drawing.Size(85, 32);
            this.btn_return.TabIndex = 13;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ChooseLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_deteminal);
            this.Controls.Add(this.btn_AllClasses);
            this.Controls.Add(this.btn_Finding);
            this.Controls.Add(this.CL_flpClasses);
            this.Controls.Add(this.tBx_lessonOwner);
            this.Controls.Add(this.tBx_lessonName);
            this.Controls.Add(this.lbl_lessonOwner);
            this.Controls.Add(this.lbl_lessonName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChooseLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课";
            this.Load += new System.EventHandler(this.ChooseLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lessonName;
        private System.Windows.Forms.Label lbl_lessonOwner;
        private System.Windows.Forms.TextBox tBx_lessonName;
        private System.Windows.Forms.TextBox tBx_lessonOwner;
        private System.Windows.Forms.FlowLayoutPanel CL_flpClasses;
        private CCWin.SkinControl.SkinButton btn_Finding;
        private CCWin.SkinControl.SkinButton btn_AllClasses;
        private CCWin.SkinControl.SkinButton btn_deteminal;
        private CCWin.SkinControl.SkinButton btn_return;
    }
}