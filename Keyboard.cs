using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Siticone.Desktop.UI.WinForms.Suite;
using System.Drawing;

namespace AutoClicker
{
    public partial class Keyboard : Form
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(int bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const int KEYEVENTF_KEYUP = 0x0002;
        private int clickType = 0x0002;
        private const int VK_W = 0x57;
        private const int VK_A = 0x41;
        private const int VK_S = 0x53;
        private const int VK_D = 0x44;
        private const int VK_SPACE = 0x20;
        private const int VK_ENTER = 0x0D;
        private const int VK_F3 = 0x72;
        private const int VK_F4 = 0x73;

        private bool isAutoClicking = false;
        private int clickInterval = 1000;
        private int clickDuration = 0;
        private DateTime clickStartTime;
        private Random random = new Random();

        public Keyboard()
        {
            InitializeComponent();
            StopButton.Enabled = false;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    (control as Button).TabStop = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                StartButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                StopButton_Click(sender, e);
            }
        }

        private void DelayCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.Index == 0 && e.NewValue == CheckState.Checked)
            {
                DelayCheckedListBox.SetItemChecked(1, false);
                DelayCheckedListBox.SetItemChecked(2, false);
                DelayCheckedListBox.SetItemChecked(3, false);
                DelayCheckedListBox.SetItemChecked(4, false);
                DelayCheckedListBox.SetItemChecked(5, false);
            }
            else if (e.Index == 1 && e.NewValue == CheckState.Checked)
            {
                DelayCheckedListBox.SetItemChecked(0, false);
                DelayCheckedListBox.SetItemChecked(2, false);
                DelayCheckedListBox.SetItemChecked(3, false);
                DelayCheckedListBox.SetItemChecked(4, false);
                DelayCheckedListBox.SetItemChecked(5, false);
            }
            else if (e.Index == 2 && e.NewValue == CheckState.Checked)
            {
                DelayCheckedListBox.SetItemChecked(0, false);
                DelayCheckedListBox.SetItemChecked(1, false);
                DelayCheckedListBox.SetItemChecked(3, false);
                DelayCheckedListBox.SetItemChecked(4, false);
                DelayCheckedListBox.SetItemChecked(5, false);
            }
            else if (e.Index == 3 && e.NewValue == CheckState.Checked)
            {
                DelayCheckedListBox.SetItemChecked(0, false);
                DelayCheckedListBox.SetItemChecked(1, false);
                DelayCheckedListBox.SetItemChecked(2, false);
                DelayCheckedListBox.SetItemChecked(4, false);
                DelayCheckedListBox.SetItemChecked(5, false);
            }
            else if (e.Index == 4 && e.NewValue == CheckState.Checked)
            {
                DelayCheckedListBox.SetItemChecked(0, false);
                DelayCheckedListBox.SetItemChecked(1, false);
                DelayCheckedListBox.SetItemChecked(2, false);
                DelayCheckedListBox.SetItemChecked(3, false);
                DelayCheckedListBox.SetItemChecked(5, false);
            }
            else if (e.Index == 5 && e.NewValue == CheckState.Checked)
            {
                DelayCheckedListBox.SetItemChecked(0, false);
                DelayCheckedListBox.SetItemChecked(1, false);
                DelayCheckedListBox.SetItemChecked(2, false);
                DelayCheckedListBox.SetItemChecked(3, false);
                DelayCheckedListBox.SetItemChecked(4, false);
            }

            if (e.NewValue == CheckState.Checked)
            {
                string selectedItem = DelayCheckedListBox.Items[e.Index].ToString();
                switch (selectedItem)
                {
                    case "1 Second":
                        clickInterval = 1000;
                        break;
                    case "2 Seconds":
                        clickInterval = 2000;
                        break;
                    case "3 Seconds":
                        clickInterval = 3000;
                        break;
                    case "5 Seconds":
                        clickInterval = 5000;
                        break;
                    case "10 Seconds":
                        clickInterval = 10000;
                        break;
                }
            }
        }

        private void Autoclicker_Tick(object sender, EventArgs e)
        {
            if (isAutoClicking)
            {
                DateTime currentTime = DateTime.Now;

                TimeSpan elapsed = currentTime - clickStartTime;

                if (clickDuration > 0 && elapsed.TotalMilliseconds >= clickDuration)
                {
                    StopAutoclick();
                }
                else
                {
                    keybd_event(clickType, 0, 0, UIntPtr.Zero);
                    keybd_event(clickType, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);

                    foreach (string item in DelayCheckedListBox.CheckedItems)
                    {
                        if (item == "Random (1-10 sec)")
                        {
                            clickInterval = random.Next(1, 11) * 1000;
                            System.Threading.Thread.Sleep(clickInterval);
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(clickInterval);
                        }
                    }

                    int remainingSeconds = (int)((clickDuration - elapsed.TotalMilliseconds) / 1000);
                    CountdownLabel.Text = $"Remaining Time: {remainingSeconds} seconds";

                    if (remainingSeconds == 0)
                    {
                        CountdownLabel.Text = $"Countdown";
                    }
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (KeyboardKeyCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a keyboard key:\n" +

                "- W\n" +
                "- A\n" +
                "- S\n" +
                "- D\n" +
                "- F3\n" +
                "- F4\n" +
                "- Space\n" +
                "- Enter\n",
                "Select Keyboard Key",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            foreach (string item in KeyboardKeyCheckedListBox.CheckedItems)
            {
                if (item == "W")
                {
                    clickType = 0x57;
                }
                else if (item == "A")
                {
                    clickType = 0x41;
                }
                else if (item == "S")
                {
                    clickType = 0x53;
                }
                else if (item == "D")
                {
                    clickType = 0x44;
                }
                else if (item == "F3")
                {
                    clickType = 0x72;
                }
                else if (item == "F4")
                {
                    clickType = 0x73;
                }
                else if (item == "Space")
                {
                    clickType = 0x20;
                }
                else if (item == "Enter")
                {
                    clickType = 0x0D;
                }
            }

            foreach (string item in DurationCheckedListBox.CheckedItems)
            {
                if (item == "1 Minute")
                {
                    clickDuration = 60000;
                }
                else if (item == "10 Minutes")
                {
                    clickDuration = 600000;
                }
                else if (item == "1 Hour")
                {
                    clickDuration = 3600000;
                }
            }

            if (DelayCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select click delay:\n" +
                                "- 1 Second\n" +
                                "- 2 Seconds\n" +
                                "- 3 Seconds\n" +
                                "- 5 Seconds\n" +
                                "- 10 Seconds",
                                "Select Click Delay",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (DurationCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a duration:\n" +

                "- 1 Minute\n" +
                "- 10 Minutes\n" +
                "- 1 Hour\n",
                "Select Duration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            StartAutoclick();
            StopButton.BackColor = Color.Red;
            DelayCheckedListBox.Enabled = false;
            KeyboardKeyCheckedListBox.Enabled = false;
            DurationCheckedListBox.Enabled = false;
            gotoMouse.Enabled = false;

        }
        
        private void StartAutoclick()
        {

            isAutoClicking = true;
            Autoclicker.Start();
            clickStartTime = DateTime.Now;
            StopButton.Enabled = true;
            StartButton.BackColor = Color.AntiqueWhite;
            StartButton.Enabled = false;

        }

        private void StopAutoclick()
        {
            isAutoClicking = false;
            Autoclicker.Stop();
            StartButton.Enabled = true;
            StartButton.BackColor = Color.RoyalBlue;
            StopButton.Enabled = false;
            StopButton.BackColor = Color.AntiqueWhite;
            DelayCheckedListBox.Enabled = true;
            KeyboardKeyCheckedListBox.Enabled = true;
            DurationCheckedListBox.Enabled = true;
            gotoMouse.Enabled = true;
            clickStartTime = DateTime.MinValue;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isAutoClicking = false;
            Autoclicker.Stop();
            StartButton.Enabled = true;
            StartButton.BackColor = Color.RoyalBlue;
            StopButton.Enabled = false;
            StopButton.BackColor = Color.AntiqueWhite;
            DelayCheckedListBox.Enabled = true;
            KeyboardKeyCheckedListBox.Enabled = true;
            DurationCheckedListBox.Enabled = true;
            gotoMouse.Enabled = true;
            CountdownLabel.Text = $"Countdown";
        }
        
        private void KeyboardKeyCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 1 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 2 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 3 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 4 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 5 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 6 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(7, false);
            }
            else if (e.Index == 7 && e.NewValue == CheckState.Checked)
            {
                KeyboardKeyCheckedListBox.SetItemChecked(0, false);
                KeyboardKeyCheckedListBox.SetItemChecked(1, false);
                KeyboardKeyCheckedListBox.SetItemChecked(2, false);
                KeyboardKeyCheckedListBox.SetItemChecked(3, false);
                KeyboardKeyCheckedListBox.SetItemChecked(4, false);
                KeyboardKeyCheckedListBox.SetItemChecked(5, false);
                KeyboardKeyCheckedListBox.SetItemChecked(6, false);
            }
        }

        private void DurationCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.NewValue == CheckState.Checked)
            {
                DurationCheckedListBox.SetItemChecked(1, false);
                DurationCheckedListBox.SetItemChecked(2, false);
            }

            else if (e.Index == 1 && e.NewValue == CheckState.Checked)
            {
                DurationCheckedListBox.SetItemChecked(0, false);
                DurationCheckedListBox.SetItemChecked(2, false);
            }

            else if (e.Index == 2 && e.NewValue == CheckState.Checked)
            {
                DurationCheckedListBox.SetItemChecked(0, false);
                DurationCheckedListBox.SetItemChecked(1, false);
            }

        }

        private void gotoMouse_Click(object sender, EventArgs e)
        {
            Mouse Mouse = new Mouse();
            Mouse.Show();
            this.Hide();
        }
    }
}
