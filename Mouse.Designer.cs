namespace AutoClicker
{
    partial class Mouse
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.MouseClickCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DelayCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TimeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gotoKeyboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Autoclicker
            // 
            this.Autoclicker.Interval = 1000;
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartButton.Location = new System.Drawing.Point(12, 182);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 45);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start(F1)";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Location = new System.Drawing.Point(122, 182);
            this.StopButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
            // MouseClickCheckedListBox
            // 
            this.MouseClickCheckedListBox.BackColor = System.Drawing.Color.Silver;
            this.MouseClickCheckedListBox.CheckOnClick = true;
            this.MouseClickCheckedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseClickCheckedListBox.FormattingEnabled = true;
            this.MouseClickCheckedListBox.Items.AddRange(new object[] {
            "Left Click",
            "Right Click"});
            this.MouseClickCheckedListBox.Location = new System.Drawing.Point(12, 36);
            this.MouseClickCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MouseClickCheckedListBox.Name = "MouseClickCheckedListBox";
            this.MouseClickCheckedListBox.Size = new System.Drawing.Size(113, 54);
            this.MouseClickCheckedListBox.TabIndex = 0;
            this.MouseClickCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.MouseClickCheckedListBox_ItemCheck);
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
            this.DelayCheckedListBox.Location = new System.Drawing.Point(144, 36);
            this.DelayCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DelayCheckedListBox.Name = "DelayCheckedListBox";
            this.DelayCheckedListBox.Size = new System.Drawing.Size(151, 130);
            this.DelayCheckedListBox.TabIndex = 3;
            this.DelayCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DelayCheckedListBox_ItemCheck);
            // 
            // TimeCheckedListBox
            // 
            this.TimeCheckedListBox.BackColor = System.Drawing.Color.Silver;
            this.TimeCheckedListBox.CheckOnClick = true;
            this.TimeCheckedListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeCheckedListBox.FormattingEnabled = true;
            this.TimeCheckedListBox.Items.AddRange(new object[] {
            "1 Minute",
            "10 Minutes",
            "1 Hour"});
            this.TimeCheckedListBox.Location = new System.Drawing.Point(314, 36);
            this.TimeCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TimeCheckedListBox.Name = "TimeCheckedListBox";
            this.TimeCheckedListBox.Size = new System.Drawing.Size(123, 79);
            this.TimeCheckedListBox.TabIndex = 2;
            this.TimeCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TimeCheckedListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time";
            // 
            // gotoKeyboard
            // 
            this.gotoKeyboard.BackColor = System.Drawing.Color.GhostWhite;
            this.gotoKeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoKeyboard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gotoKeyboard.Location = new System.Drawing.Point(369, 214);
            this.gotoKeyboard.Name = "gotoKeyboard";
            this.gotoKeyboard.Size = new System.Drawing.Size(70, 30);
            this.gotoKeyboard.TabIndex = 9;
            this.gotoKeyboard.Text = "Keyboard";
            this.gotoKeyboard.UseVisualStyleBackColor = false;
            this.gotoKeyboard.Click += new System.EventHandler(this.gotoKeyboard_Click);
            // 
            // Mouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(451, 256);
            this.Controls.Add(this.gotoKeyboard);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.TimeCheckedListBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MouseClickCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayCheckedListBox);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Mouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Mouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Autoclicker;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.CheckedListBox MouseClickCheckedListBox;
        private System.Windows.Forms.CheckedListBox DelayCheckedListBox;
        private System.Windows.Forms.CheckedListBox TimeCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gotoKeyboard;
    }
}

