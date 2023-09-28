namespace AutoClicker
{
    partial class Keyboard
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
            this.KeyboardKeyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.DelayCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DurationCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gotoMouse = new System.Windows.Forms.Button();
            this.gotoProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyboardKeyCheckedListBox
            // 
            this.KeyboardKeyCheckedListBox.BackColor = System.Drawing.Color.Silver;
            this.KeyboardKeyCheckedListBox.CheckOnClick = true;
            this.KeyboardKeyCheckedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyboardKeyCheckedListBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyboardKeyCheckedListBox.FormattingEnabled = true;
            this.KeyboardKeyCheckedListBox.Items.AddRange(new object[] {
            "W",
            "A",
            "S",
            "D",
            "F3",
            "F4",
            "Space",
            "Enter"});
            this.KeyboardKeyCheckedListBox.Location = new System.Drawing.Point(12, 36);
            this.KeyboardKeyCheckedListBox.Margin = new System.Windows.Forms.Padding(5);
            this.KeyboardKeyCheckedListBox.Name = "KeyboardKeyCheckedListBox";
            this.KeyboardKeyCheckedListBox.Size = new System.Drawing.Size(61, 132);
            this.KeyboardKeyCheckedListBox.TabIndex = 0;
            this.KeyboardKeyCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.KeyboardKeyCheckedListBox_ItemCheck);
            // 
            // Autoclicker
            // 
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // DelayCheckedListBox
            // 
            this.DelayCheckedListBox.BackColor = System.Drawing.Color.Silver;
            this.DelayCheckedListBox.CheckOnClick = true;
            this.DelayCheckedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelayCheckedListBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DelayCheckedListBox.FormattingEnabled = true;
            this.DelayCheckedListBox.Items.AddRange(new object[] {
            "1 Second",
            "2 Seconds",
            "3 Seconds",
            "5 Seconds",
            "10 Seconds",
            "Random (1-10 sec)"});
            this.DelayCheckedListBox.Location = new System.Drawing.Point(96, 36);
            this.DelayCheckedListBox.Margin = new System.Windows.Forms.Padding(5);
            this.DelayCheckedListBox.Name = "DelayCheckedListBox";
            this.DelayCheckedListBox.Size = new System.Drawing.Size(152, 130);
            this.DelayCheckedListBox.TabIndex = 1;
            this.DelayCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DelayCheckedListBox_ItemCheck);
            // 
            // DurationCheckedListBox
            // 
            this.DurationCheckedListBox.BackColor = System.Drawing.Color.Silver;
            this.DurationCheckedListBox.CheckOnClick = true;
            this.DurationCheckedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DurationCheckedListBox.FormattingEnabled = true;
            this.DurationCheckedListBox.Items.AddRange(new object[] {
            "1 Minute",
            "10 Minutes",
            "1 Hour"});
            this.DurationCheckedListBox.Location = new System.Drawing.Point(270, 36);
            this.DurationCheckedListBox.Margin = new System.Windows.Forms.Padding(5);
            this.DurationCheckedListBox.Name = "DurationCheckedListBox";
            this.DurationCheckedListBox.Size = new System.Drawing.Size(126, 79);
            this.DurationCheckedListBox.TabIndex = 2;
            this.DurationCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DurationCheckedListBox_ItemCheck);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(12, 182);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 45);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start(F1)";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Location = new System.Drawing.Point(122, 182);
            this.StopButton.Margin = new System.Windows.Forms.Padding(5);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(100, 45);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Stop(F2)";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CountdownLabel.Location = new System.Drawing.Point(12, 230);
            this.CountdownLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(71, 16);
            this.CountdownLabel.TabIndex = 5;
            this.CountdownLabel.Text = "Countdown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            // 
            // gotoMouse
            // 
            this.gotoMouse.BackColor = System.Drawing.Color.GhostWhite;
            this.gotoMouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoMouse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gotoMouse.Location = new System.Drawing.Point(328, 213);
            this.gotoMouse.Name = "gotoMouse";
            this.gotoMouse.Size = new System.Drawing.Size(70, 30);
            this.gotoMouse.TabIndex = 9;
            this.gotoMouse.Text = "Mouse";
            this.gotoMouse.UseVisualStyleBackColor = false;
            this.gotoMouse.Click += new System.EventHandler(this.gotoMouse_Click);
            // 
            // gotoProcess
            // 
            this.gotoProcess.Location = new System.Drawing.Point(294, 160);
            this.gotoProcess.Name = "gotoProcess";
            this.gotoProcess.Size = new System.Drawing.Size(102, 47);
            this.gotoProcess.TabIndex = 10;
            this.gotoProcess.Text = "Processes";
            this.gotoProcess.UseVisualStyleBackColor = true;
            this.gotoProcess.Click += new System.EventHandler(this.gotoProcess_Click);
            // 
            // Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(410, 255);
            this.Controls.Add(this.gotoProcess);
            this.Controls.Add(this.gotoMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DurationCheckedListBox);
            this.Controls.Add(this.DelayCheckedListBox);
            this.Controls.Add(this.KeyboardKeyCheckedListBox);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Keyboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Keyboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox KeyboardKeyCheckedListBox;
        private System.Windows.Forms.Timer Autoclicker;
        private System.Windows.Forms.CheckedListBox DelayCheckedListBox;
        private System.Windows.Forms.CheckedListBox DurationCheckedListBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gotoMouse;
        private System.Windows.Forms.Button gotoProcess;
    }
}