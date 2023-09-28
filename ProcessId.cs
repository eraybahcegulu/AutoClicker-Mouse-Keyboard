using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
using System.Management;

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
            ListInputDevices();
        }
        private void KeyboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            ListInputDevices();
        }


        private void ListInputDevices()
        {
            listBoxDevices.Items.Clear();

            try
            {
                if (KeyboardCheckBox.Checked)
                {
                    ManagementObjectSearcher keyboardSearcher = new ManagementObjectSearcher(@"Select * From Win32_Keyboard");
                    foreach (ManagementObject keyboard in keyboardSearcher.Get())
                    {
                        string deviceName = keyboard["Description"] as string;
                        string deviceId = keyboard["DeviceID"] as string;
                        listBoxDevices.Items.Add($"Keyboard: {deviceName} (ID: {deviceId})");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
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

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        private const int INPUT_KEYBOARD = 1;
        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_KEYUP = 0x0002;

        [StructLayout(LayoutKind.Sequential)]
        private struct INPUT
        {
            public uint type;
            public InputUnion U;
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct InputUnion
        {
            [FieldOffset(0)]
            public MOUSEINPUT mi;
            [FieldOffset(0)]
            public KEYBDINPUT ki;
            [FieldOffset(0)]
            public HARDWAREINPUT hi;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct HARDWAREINPUT
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        private void btnSendKey_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex != -1 && listBoxDevices.SelectedIndex != -1)
            {
                string selectedProcessInfo = listBoxProcesses.SelectedItem.ToString();
                int selectedProcessId = GetProcessIdFromInfo(selectedProcessInfo);

                if (IsProcessValid(selectedProcessId))
                {

                    SetForegroundWindowByProcessId(selectedProcessId);

                    string selectedDeviceId = GetSelectedDeviceId();
                    ushort keyCode = 0x57;
                    SendKeyPressToDevice(selectedDeviceId, keyCode);
                }
                else
                {
                    MessageBox.Show("Invalid process ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both a process and a keyboard device.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendKeyPressToDevice(string deviceId, ushort keyCode)
        {
            try
            {
                INPUT[] inputs = new INPUT[1];


                inputs[0].type = INPUT_KEYBOARD;
                inputs[0].U.ki.wVk = keyCode;
                inputs[0].U.ki.dwFlags = KEYEVENTF_KEYDOWN;


                if (SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT))) == 0)
                {
                    int error = Marshal.GetLastWin32Error();
                    Console.WriteLine("SendInput failed with error code: " + error);
                    MessageBox.Show($"Failed to send key. Error code: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Console.WriteLine("Key press sent successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string GetSelectedDeviceId()
        {
            string selectedDeviceInfo = listBoxDevices.SelectedItem.ToString();
            int start = selectedDeviceInfo.LastIndexOf("(ID: ") + 5;
            int end = selectedDeviceInfo.LastIndexOf(")");

            return selectedDeviceInfo.Substring(start, end - start);
        }

        private void RefreshProcesses()
        {
            listBoxProcesses.Items.Clear();

            foreach (Process process in Process.GetProcesses())
            {
                listBoxProcesses.Items.Add($"{process.ProcessName} (ID: {process.Id})");
            }
        }

        private void btnRefreshProcesses_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }
    }



}