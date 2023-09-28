namespace AutoClicker
{
    partial class ProcessId
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
            this.listBoxProcesses = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.btnSendKey = new System.Windows.Forms.Button();
            this.KeyboardCheckBox = new System.Windows.Forms.CheckBox();
            this.btnRefreshProcesses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProcesses
            // 
            this.listBoxProcesses.FormattingEnabled = true;
            this.listBoxProcesses.ItemHeight = 15;
            this.listBoxProcesses.Location = new System.Drawing.Point(13, 12);
            this.listBoxProcesses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxProcesses.Name = "listBoxProcesses";
            this.listBoxProcesses.Size = new System.Drawing.Size(440, 439);
            this.listBoxProcesses.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(286, 457);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(167, 57);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "FOCUS THIS PROCESS";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 15;
            this.listBoxDevices.Location = new System.Drawing.Point(460, 57);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDevices.Size = new System.Drawing.Size(1087, 394);
            this.listBoxDevices.TabIndex = 2;
            // 
            // btnSendKey
            // 
            this.btnSendKey.Location = new System.Drawing.Point(700, 457);
            this.btnSendKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendKey.Name = "btnSendKey";
            this.btnSendKey.Size = new System.Drawing.Size(479, 56);
            this.btnSendKey.TabIndex = 3;
            this.btnSendKey.Text = "FOCUS PROCESS AND SEND DATA TO THE SELECTED INPUT DEVICE";
            this.btnSendKey.UseVisualStyleBackColor = true;
            this.btnSendKey.Click += new System.EventHandler(this.btnSendKey_Click);
            // 
            // KeyboardCheckBox
            // 
            this.KeyboardCheckBox.AutoSize = true;
            this.KeyboardCheckBox.Location = new System.Drawing.Point(557, 12);
            this.KeyboardCheckBox.Name = "KeyboardCheckBox";
            this.KeyboardCheckBox.Size = new System.Drawing.Size(90, 19);
            this.KeyboardCheckBox.TabIndex = 4;
            this.KeyboardCheckBox.Text = "Keyboard";
            this.KeyboardCheckBox.UseVisualStyleBackColor = true;
            this.KeyboardCheckBox.CheckedChanged += new System.EventHandler(this.KeyboardCheckBox_CheckedChanged);
            // 
            // btnRefreshProcesses
            // 
            this.btnRefreshProcesses.Location = new System.Drawing.Point(12, 457);
            this.btnRefreshProcesses.Name = "btnRefreshProcesses";
            this.btnRefreshProcesses.Size = new System.Drawing.Size(162, 47);
            this.btnRefreshProcesses.TabIndex = 5;
            this.btnRefreshProcesses.Text = "REFRESH PROCESSES";
            this.btnRefreshProcesses.UseVisualStyleBackColor = true;
            this.btnRefreshProcesses.Click += new System.EventHandler(this.btnRefreshProcesses_Click);
            // 
            // ProcessId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 557);
            this.Controls.Add(this.btnRefreshProcesses);
            this.Controls.Add(this.KeyboardCheckBox);
            this.Controls.Add(this.btnSendKey);
            this.Controls.Add(this.listBoxDevices);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listBoxProcesses);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProcessId";
            this.Text = "ProcessId";
            this.Load += new System.EventHandler(this.ProcessId_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProcesses;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.Button btnSendKey;
        private System.Windows.Forms.CheckBox KeyboardCheckBox;
        private System.Windows.Forms.Button btnRefreshProcesses;
    }
}