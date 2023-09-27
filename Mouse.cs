using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Siticone.Desktop.UI.WinForms.Suite;
using System.Drawing;

namespace AutoClicker
{
    public partial class Mouse : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private bool isAutoClicking = false;
        private int clickInterval = 1000;
        private int clickTypeDown = 0x0002;
        private int clickTypeUp = 0x0004;
        private int clickDuration = 0;
        private DateTime clickStartTime;
        private Random random = new Random();
        public Mouse()
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
                    mouse_event(clickTypeDown, 0, 0, 0, 0);
                    mouse_event(clickTypeUp, 0, 0, 0, 0);

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

        private void StartAutoclick()
        {

            isAutoClicking = true;
            Autoclicker.Interval = clickInterval;
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
            MouseClickCheckedListBox.Enabled = true;
            TimeCheckedListBox.Enabled = true;
            gotoKeyboard.Enabled = true;
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
            MouseClickCheckedListBox.Enabled = true;
            TimeCheckedListBox.Enabled = true;
            gotoKeyboard.Enabled = true;
            CountdownLabel.Text = $"Countdown";
        }
        private void StartButton_Click(object sender, EventArgs e)
        {


            if (MouseClickCheckedListBox.CheckedItems.Count == 0)
            {


                MessageBox.Show("Please select a mouse button:\n" +

                "- Left Click\n" +
                "- Right Click\n",
                "Select Mouse Button",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            foreach (string item in MouseClickCheckedListBox.CheckedItems)
            {
                if (item == "Left Click")
                {
                    clickTypeDown = 0x0002;
                    clickTypeUp = 0x0004;
                }
                else if (item == "Right Click")
                {
                    clickTypeDown = 0x0008;
                    clickTypeUp = 0x0010;
                }
            }



            foreach (string item in TimeCheckedListBox.CheckedItems)
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

            if (TimeCheckedListBox.CheckedItems.Count == 0)
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
            MouseClickCheckedListBox.Enabled = false;
            TimeCheckedListBox.Enabled = false;
            gotoKeyboard.Enabled = false;


        }

        private void MouseClickCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.NewValue == CheckState.Checked && MouseClickCheckedListBox.GetItemChecked(1))
            {
                MouseClickCheckedListBox.SetItemChecked(1, false);
            }
            else if (e.Index == 1 && e.NewValue == CheckState.Checked && MouseClickCheckedListBox.GetItemChecked(0))
            {
                MouseClickCheckedListBox.SetItemChecked(0, false);
            }
        }

        private void TimeCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0 && e.NewValue == CheckState.Checked)
            {
                TimeCheckedListBox.SetItemChecked(1, false);
                TimeCheckedListBox.SetItemChecked(2, false);
            }

            else if (e.Index == 1 && e.NewValue == CheckState.Checked)
            {
                TimeCheckedListBox.SetItemChecked(0, false);
                TimeCheckedListBox.SetItemChecked(2, false);
            }

            else if (e.Index == 2 && e.NewValue == CheckState.Checked)
            {
                TimeCheckedListBox.SetItemChecked(0, false);
                TimeCheckedListBox.SetItemChecked(1, false);
            }

        }

        private void gotoKeyboard_Click(object sender, EventArgs e)
        {
            Keyboard Keyboard = new Keyboard();
            Keyboard.Show();
            this.Hide();
        }
    }
}