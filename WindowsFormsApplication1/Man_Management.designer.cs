namespace WindowsFormsApplication1
{
    partial class Man_Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBx_findkeywords = new System.Windows.Forms.TextBox();
            this.fLP_workers = new System.Windows.Forms.FlowLayoutPanel();
            this.MM_lblFileName = new CCWin.SkinControl.SkinLabel();
            this.MM_btnInput = new CCWin.SkinControl.SkinButton();
            this.btn_Input = new CCWin.SkinControl.SkinButton();
            this.MM_btnReturn = new CCWin.SkinControl.SkinButton();
            this.btn_find = new CCWin.SkinControl.SkinButton();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.cbB_findKey = new CCWin.SkinControl.SkinComboBox();
            this.cBx_workerEntryMonth = new CCWin.SkinControl.SkinComboBox();
            this.cBx_workerEntryYear = new CCWin.SkinControl.SkinComboBox();
            this.cBx_workertype = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(101, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "请您输入关键字：";
            // 
            // tBx_findkeywords
            // 
            this.tBx_findkeywords.Font = new System.Drawing.Font("宋体", 12F);
            this.tBx_findkeywords.Location = new System.Drawing.Point(239, 49);
            this.tBx_findkeywords.Margin = new System.Windows.Forms.Padding(2);
            this.tBx_findkeywords.Name = "tBx_findkeywords";
            this.tBx_findkeywords.Size = new System.Drawing.Size(130, 26);
            this.tBx_findkeywords.TabIndex = 1;
            // 
            // fLP_workers
            // 
            this.fLP_workers.AutoScroll = true;
            this.fLP_workers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fLP_workers.Location = new System.Drawing.Point(85, 101);
            this.fLP_workers.Margin = new System.Windows.Forms.Padding(2);
            this.fLP_workers.Name = "fLP_workers";
            this.fLP_workers.Size = new System.Drawing.Size(579, 353);
            this.fLP_workers.TabIndex = 5;
            // 
            // MM_lblFileName
            // 
            this.MM_lblFileName.AutoSize = true;
            this.MM_lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.MM_lblFileName.BorderColor = System.Drawing.Color.White;
            this.MM_lblFileName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MM_lblFileName.Location = new System.Drawing.Point(190, 477);
            this.MM_lblFileName.Name = "MM_lblFileName";
            this.MM_lblFileName.Size = new System.Drawing.Size(0, 17);
            this.MM_lblFileName.TabIndex = 11;
            // 
            // MM_btnInput
            // 
            this.MM_btnInput.BackColor = System.Drawing.Color.Transparent;
            this.MM_btnInput.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.MM_btnInput.DownBack = null;
            this.MM_btnInput.Location = new System.Drawing.Point(406, 473);
            this.MM_btnInput.MouseBack = null;
            this.MM_btnInput.Name = "MM_btnInput";
            this.MM_btnInput.NormlBack = null;
            this.MM_btnInput.Size = new System.Drawing.Size(82, 27);
            this.MM_btnInput.TabIndex = 12;
            this.MM_btnInput.Text = "批量导入";
            this.MM_btnInput.UseVisualStyleBackColor = false;
            this.MM_btnInput.Click += new System.EventHandler(this.MM_btnInput_Click);
            // 
            // btn_Input
            // 
            this.btn_Input.BackColor = System.Drawing.Color.Transparent;
            this.btn_Input.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Input.DownBack = null;
            this.btn_Input.Location = new System.Drawing.Point(85, 471);
            this.btn_Input.MouseBack = null;
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.NormlBack = null;
            this.btn_Input.Size = new System.Drawing.Size(82, 27);
            this.btn_Input.TabIndex = 13;
            this.btn_Input.Text = "选择文件";
            this.btn_Input.UseVisualStyleBackColor = false;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // MM_btnReturn
            // 
            this.MM_btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.MM_btnReturn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.MM_btnReturn.DownBack = null;
            this.MM_btnReturn.Location = new System.Drawing.Point(622, 506);
            this.MM_btnReturn.MouseBack = null;
            this.MM_btnReturn.Name = "MM_btnReturn";
            this.MM_btnReturn.NormlBack = null;
            this.MM_btnReturn.Size = new System.Drawing.Size(91, 37);
            this.MM_btnReturn.TabIndex = 14;
            this.MM_btnReturn.Text = "返回";
            this.MM_btnReturn.UseVisualStyleBackColor = false;
            this.MM_btnReturn.Click += new System.EventHandler(this.MM_btnReturn_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_find.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_find.DownBack = null;
            this.btn_find.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_find.Location = new System.Drawing.Point(511, 48);
            this.btn_find.MouseBack = null;
            this.btn_find.Name = "btn_find";
            this.btn_find.NormlBack = null;
            this.btn_find.Size = new System.Drawing.Size(65, 27);
            this.btn_find.TabIndex = 15;
            this.btn_find.Text = "查询";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_add.Location = new System.Drawing.Point(593, 48);
            this.btn_add.MouseBack = null;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Size = new System.Drawing.Size(65, 27);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbB_findKey
            // 
            this.cbB_findKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbB_findKey.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbB_findKey.FormattingEnabled = true;
            this.cbB_findKey.Location = new System.Drawing.Point(389, 50);
            this.cbB_findKey.Name = "cbB_findKey";
            this.cbB_findKey.Size = new System.Drawing.Size(110, 24);
            this.cbB_findKey.TabIndex = 17;
            this.cbB_findKey.WaterText = "";
            this.cbB_findKey.SelectedIndexChanged += new System.EventHandler(this.cbB_findKey_SelectedIndexChanged);
            // 
            // cBx_workerEntryMonth
            // 
            this.cBx_workerEntryMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_workerEntryMonth.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_workerEntryMonth.FormattingEnabled = true;
            this.cBx_workerEntryMonth.Location = new System.Drawing.Point(239, 1);
            this.cBx_workerEntryMonth.Name = "cBx_workerEntryMonth";
            this.cBx_workerEntryMonth.Size = new System.Drawing.Size(130, 24);
            this.cBx_workerEntryMonth.TabIndex = 18;
            this.cBx_workerEntryMonth.WaterText = "";
            // 
            // cBx_workerEntryYear
            // 
            this.cBx_workerEntryYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_workerEntryYear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_workerEntryYear.FormattingEnabled = true;
            this.cBx_workerEntryYear.Location = new System.Drawing.Point(239, 25);
            this.cBx_workerEntryYear.Name = "cBx_workerEntryYear";
            this.cBx_workerEntryYear.Size = new System.Drawing.Size(130, 24);
            this.cBx_workerEntryYear.TabIndex = 19;
            this.cBx_workerEntryYear.WaterText = "";
            // 
            // cBx_workertype
            // 
            this.cBx_workertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBx_workertype.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cBx_workertype.FormattingEnabled = true;
            this.cBx_workertype.Location = new System.Drawing.Point(239, 76);
            this.cBx_workertype.Name = "cBx_workertype";
            this.cBx_workertype.Size = new System.Drawing.Size(130, 24);
            this.cBx_workertype.TabIndex = 20;
            this.cBx_workertype.WaterText = "";
            // 
            // Man_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.cBx_workertype);
            this.Controls.Add(this.cBx_workerEntryYear);
            this.Controls.Add(this.cBx_workerEntryMonth);
            this.Controls.Add(this.cbB_findKey);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.MM_btnReturn);
            this.Controls.Add(this.btn_Input);
            this.Controls.Add(this.MM_btnInput);
            this.Controls.Add(this.MM_lblFileName);
            this.Controls.Add(this.fLP_workers);
            this.Controls.Add(this.tBx_findkeywords);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Man_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人员管理";
            this.Load += new System.EventHandler(this.Man_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBx_findkeywords;
        private System.Windows.Forms.FlowLayoutPanel fLP_workers;
        private CCWin.SkinControl.SkinLabel MM_lblFileName;
        private CCWin.SkinControl.SkinButton MM_btnInput;
        private CCWin.SkinControl.SkinButton btn_Input;
        private CCWin.SkinControl.SkinButton MM_btnReturn;
        private CCWin.SkinControl.SkinButton btn_find;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinComboBox cbB_findKey;
        private CCWin.SkinControl.SkinComboBox cBx_workerEntryMonth;
        private CCWin.SkinControl.SkinComboBox cBx_workerEntryYear;
        private CCWin.SkinControl.SkinComboBox cBx_workertype;
    }
}