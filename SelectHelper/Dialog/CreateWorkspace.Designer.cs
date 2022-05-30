namespace SelectHelper.Dialog
{
    partial class CreateWorkspace
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
            this.textBoxCreateSDBName = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.comboBoxCreateSDBType = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBoxCreateSDBVersion = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonCreateSDBOK = new System.Windows.Forms.Button();
            this.textBoxCreateSDBPassword = new System.Windows.Forms.TextBox();
            this.buttonCreateSDBFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCreateSDBPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCreateSDBName
            // 
            this.textBoxCreateSDBName.Location = new System.Drawing.Point(189, 267);
            this.textBoxCreateSDBName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCreateSDBName.Name = "textBoxCreateSDBName";
            this.textBoxCreateSDBName.Size = new System.Drawing.Size(373, 28);
            this.textBoxCreateSDBName.TabIndex = 18;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(49, 272);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(98, 18);
            this.label50.TabIndex = 22;
            this.label50.Text = "工作空间名";
            // 
            // comboBoxCreateSDBType
            // 
            this.comboBoxCreateSDBType.FormattingEnabled = true;
            this.comboBoxCreateSDBType.Items.AddRange(new object[] {
            "SXW",
            "SMW"});
            this.comboBoxCreateSDBType.Location = new System.Drawing.Point(189, 208);
            this.comboBoxCreateSDBType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCreateSDBType.Name = "comboBoxCreateSDBType";
            this.comboBoxCreateSDBType.Size = new System.Drawing.Size(373, 26);
            this.comboBoxCreateSDBType.TabIndex = 17;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(49, 213);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 18);
            this.label26.TabIndex = 21;
            this.label26.Text = "工作空间类型";
            // 
            // comboBoxCreateSDBVersion
            // 
            this.comboBoxCreateSDBVersion.FormattingEnabled = true;
            this.comboBoxCreateSDBVersion.Location = new System.Drawing.Point(189, 153);
            this.comboBoxCreateSDBVersion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCreateSDBVersion.Name = "comboBoxCreateSDBVersion";
            this.comboBoxCreateSDBVersion.Size = new System.Drawing.Size(373, 26);
            this.comboBoxCreateSDBVersion.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 158);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 18);
            this.label25.TabIndex = 19;
            this.label25.Text = "工作空间版本";
            // 
            // buttonCreateSDBOK
            // 
            this.buttonCreateSDBOK.Location = new System.Drawing.Point(422, 352);
            this.buttonCreateSDBOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateSDBOK.Name = "buttonCreateSDBOK";
            this.buttonCreateSDBOK.Size = new System.Drawing.Size(150, 62);
            this.buttonCreateSDBOK.TabIndex = 20;
            this.buttonCreateSDBOK.Text = "确定";
            this.buttonCreateSDBOK.UseVisualStyleBackColor = true;
            this.buttonCreateSDBOK.Click += new System.EventHandler(this.buttonCreateSDBOK_Click);
            // 
            // textBoxCreateSDBPassword
            // 
            this.textBoxCreateSDBPassword.Location = new System.Drawing.Point(189, 96);
            this.textBoxCreateSDBPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCreateSDBPassword.Name = "textBoxCreateSDBPassword";
            this.textBoxCreateSDBPassword.Size = new System.Drawing.Size(373, 28);
            this.textBoxCreateSDBPassword.TabIndex = 14;
            // 
            // buttonCreateSDBFile
            // 
            this.buttonCreateSDBFile.Location = new System.Drawing.Point(639, 36);
            this.buttonCreateSDBFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateSDBFile.Name = "buttonCreateSDBFile";
            this.buttonCreateSDBFile.Size = new System.Drawing.Size(112, 34);
            this.buttonCreateSDBFile.TabIndex = 13;
            this.buttonCreateSDBFile.Text = "浏览";
            this.buttonCreateSDBFile.UseVisualStyleBackColor = true;
            this.buttonCreateSDBFile.Click += new System.EventHandler(this.buttonCreateSDBFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 100);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "密码";
            // 
            // textBoxCreateSDBPath
            // 
            this.textBoxCreateSDBPath.Location = new System.Drawing.Point(189, 39);
            this.textBoxCreateSDBPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCreateSDBPath.Name = "textBoxCreateSDBPath";
            this.textBoxCreateSDBPath.Size = new System.Drawing.Size(373, 28);
            this.textBoxCreateSDBPath.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "工作空间路径";
            // 
            // CreateWorkspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCreateSDBName);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.comboBoxCreateSDBType);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.comboBoxCreateSDBVersion);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.buttonCreateSDBOK);
            this.Controls.Add(this.textBoxCreateSDBPassword);
            this.Controls.Add(this.buttonCreateSDBFile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxCreateSDBPath);
            this.Controls.Add(this.label14);
            this.Name = "CreateWorkspace";
            this.Text = "CreateWorkspace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCreateSDBName;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox comboBoxCreateSDBType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBoxCreateSDBVersion;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button buttonCreateSDBOK;
        private System.Windows.Forms.TextBox textBoxCreateSDBPassword;
        private System.Windows.Forms.Button buttonCreateSDBFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCreateSDBPath;
        private System.Windows.Forms.Label label14;
    }
}