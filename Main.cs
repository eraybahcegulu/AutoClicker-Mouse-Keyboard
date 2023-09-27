using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    (control as Button).TabStop = false;
                }
            }
        }

        private void Mouse_Click(object sender, EventArgs e)
        {
            Mouse Mouse = new Mouse();
            Mouse.Show();
            this.Hide();
        }

        private void Keyboard_Click(object sender, EventArgs e)
        {
            Keyboard Keyboard = new Keyboard();
            Keyboard.Show();
            this.Hide();
        }
    }
}
