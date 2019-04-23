namespace WindowsFormsApplication1
{
    partial class ClassChoose
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
            this.tBx_findkeywords = new System.Windows.Forms.TextBox();
            this.cbB_findKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fLP_lessons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_find = new CCWin.SkinControl.SkinButton();
            this.btn_allClasses = new CCWin.SkinControl.SkinButton();
            this.btn_oK = new CCWin.SkinControl.SkinButton();
            this.btn_back = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // tBx_findkeywords
            // 
            this.tBx_findkeywords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tBx_findkeywords.Location = new System.Drawing.Point(221, 48);
            this.tBx_findkeywords.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_findkeywords.Name = "tBx_findkeywords";
            this.tBx_findkeywords.Size = new System.Drawing.Size(219, 29);
            this.tBx_findkeywords.TabIndex = 3;
            // 
            // cbB_findKey
            // 
            this.cbB_findKey.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbB_findKey.FormattingEnabled = true;
            this.cbB_findKey.Location = new System.Drawing.Point(445, 48);
            this.cbB_findKey.Margin = new System.Windows.Forms.Padding(2);
            this.cbB_findKey.Name = "cbB_findKey";
            this.cbB_findKey.Size = new System.Drawing.Size(92, 29);
            this.cbB_findKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(83, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "请您输入关键字：";
            // 
            // fLP_lessons
            // 
            this.fLP_lessons.AutoScroll = true;
            this.fLP_lessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.fLP_lessons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLP_lessons.Location = new System.Drawing.Point(87, 114);
            this.fLP_lessons.Margin = new System.Windows.Forms.Padding(4);
            this.fLP_lessons.Name = "fLP_lessons";
            this.fLP_lessons.Size = new System.Drawing.Size(568, 368);
            this.fLP_lessons.TabIndex = 6;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_find.DownBack = null;
            this.btn_find.Location = new System.Drawing.Point(542, 47);
            this.btn_find.MouseBack = null;
            this.btn_find.Name = "btn_find";
            this.btn_find.NormlBack = null;
            this.btn_find.Size = new System.Drawing.Size(56, 30);
            this.btn_find.TabIndex = 10;
            this.btn_find.Text = "查询";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_allClasses
            // 
            this.btn_allClasses.BackColor = System.Drawing.Color.Transparent;
            this.btn_allClasses.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_allClasses.DownBack = null;
            this.btn_allClasses.Location = new System.Drawing.Point(604, 47);
            this.btn_allClasses.MouseBack = null;
            this.btn_allClasses.Name = "btn_allClasses";
            this.btn_allClasses.NormlBack = null;
            this.btn_allClasses.Size = new System.Drawing.Size(70, 30);
            this.btn_allClasses.TabIndex = 11;
            this.btn_allClasses.Text = "所有课程";
            this.btn_allClasses.UseVisualStyleBackColor = false;
            this.btn_allClasses.Click += new System.EventHandler(this.btn_allClasses_Click);
            // 
            // btn_oK
            // 
            this.btn_oK.BackColor = System.Drawing.Color.Transparent;
            this.btn_oK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_oK.DownBack = null;
            this.btn_oK.Location = new System.Drawing.Point(507, 510);
            this.btn_oK.MouseBack = null;
            this.btn_oK.Name = "btn_oK";
            this.btn_oK.NormlBack = null;
            this.btn_oK.Size = new System.Drawing.Size(91, 37);
            this.btn_oK.TabIndex = 12;
            this.btn_oK.Text = "确定";
            this.btn_oK.UseVisualStyleBackColor = false;
            this.btn_oK.Click += new System.EventHandler(this.btn_oK_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_back.DownBack = null;
            this.btn_back.Location = new System.Drawing.Point(628, 510);
            this.btn_back.MouseBack = null;
            this.btn_back.Name = "btn_back";
            this.btn_back.NormlBack = null;
            this.btn_back.Size = new System.Drawing.Size(91, 37);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ClassChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_oK);
            this.Controls.Add(this.btn_allClasses);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.fLP_lessons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbB_findKey);
            this.Controls.Add(this.tBx_findkeywords);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClassChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择课程";
            this.Load += new System.EventHandler(this.ClassChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBx_findkeywords;
        private System.Windows.Forms.ComboBox cbB_findKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fLP_lessons;
        private CCWin.SkinControl.SkinButton btn_find;
        private CCWin.SkinControl.SkinButton btn_allClasses;
        private CCWin.SkinControl.SkinButton btn_oK;
        private CCWin.SkinControl.SkinButton btn_back;
    }
}