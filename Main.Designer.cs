namespace AutoClicker
{
    partial class Main
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
            this.Mouse = new System.Windows.Forms.Button();
            this.Keyboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mouse
            // 
            this.Mouse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Mouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mouse.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mouse.Location = new System.Drawing.Point(12, 12);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(262, 132);
            this.Mouse.TabIndex = 0;
            this.Mouse.Text = "Mouse";
            this.Mouse.UseVisualStyleBackColor = false;
            this.Mouse.Click += new System.EventHandler(this.Mouse_Click);
            // 
            // Keyboard
            // 
            this.Keyboard.BackColor = System.Drawing.Color.Thistle;
            this.Keyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Keyboard.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Keyboard.Location = new System.Drawing.Point(280, 12);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Size = new System.Drawing.Size(262, 132);
            this.Keyboard.TabIndex = 0;
            this.Keyboard.Text = "Keyboard";
            this.Keyboard.UseVisualStyleBackColor = false;
            this.Keyboard.Click += new System.EventHandler(this.Keyboard_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(558, 154);
            this.Controls.Add(this.Keyboard);
            this.Controls.Add(this.Mouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mouse;
        private System.Windows.Forms.Button Keyboard;
    }
}