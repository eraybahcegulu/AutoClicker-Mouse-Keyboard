using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace AutoClicker
{
    public partial class ProcessId : Form
    {
        private const int SW_SHOWMAXIMIZED = 3;

        public int SelectedProcessId { get; private set; }

        public ProcessId()
        {
            InitializeComponent();
        }

        private void ProcessId_Load(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            foreach (Process process in Process.GetProcesses())
            {
                listBoxProcesses.Items.Add($"{process.ProcessName} (ID: {process.Id})");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex != -1)
            {
                string selectedProcessInfo = listBoxProcesses.SelectedItem.ToString();
                SelectedProcessId = GetProcessIdFromInfo(selectedProcessInfo);

                if (IsProcessValid(SelectedProcessId))
                {
                    SetForegroundWindowByProcessId(SelectedProcessId);
                }
                else
                {
                    MessageBox.Show("Invalid process ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetForegroundWindowByProcessId(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);

                if (process != null && process.MainWindowHandle != IntPtr.Zero)
                {
                    ShowWindow(process.MainWindowHandle, SW_SHOWMAXIMIZED);
                    SwitchToThisWindow(process.MainWindowHandle, true);
                }
                else
                {
                    Console.WriteLine($"Process with ID {processId} not found or main window handle is invalid.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error getting process by ID: {ex.Message}");
                MessageBox.Show("Invalid process ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetProcessIdFromInfo(string processInfo)
        {
            int start = processInfo.LastIndexOf("(") + 1;
            int end = processInfo.LastIndexOf(")");

            if (start >= 0 && end >= 0)
            {
                string processIdString = processInfo.Substring(start, end - start).Trim();
                processIdString = new string(processIdString.Where(char.IsDigit).ToArray());

                if (int.TryParse(processIdString, out int processId))
                {
                    return processId;
                }
                else
                {
                    Console.WriteLine($"Invalid process ID string: {processIdString}");
                }
            }
            else
            {
                Console.WriteLine($"Invalid process info format: {processInfo}");
            }

            return -1;
        }

        private bool IsProcessValid(int processId)
        {
            try
            {
                Process.GetProcessById(processId);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error checking process validity: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return false;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
    }
}
