using System.Diagnostics;
using System.Text;
using TerminalMonitoringService.ProcessMonitoring;

namespace CrashTester
{
    public partial class MainCrasthesterForm : Form
    {
        ProcessMonitoringLogic monitoringCurrentProcess;

        public MainCrasthesterForm()
        {
            InitializeComponent();
            monitoringCurrentProcess = new ProcessMonitoringLogic(Process.GetCurrentProcess(), 500);
            monitoringCurrentProcess.ProcessInfoUpdated += OnProcessInfoUpdated;

        }

        private void OnProcessInfoUpdated(ProcessInfo info)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnProcessInfoUpdated(info)));
                return;
            }

            try
            {
                var processInfo = new StringBuilder();
                processInfo.AppendLine("Current process information");
                processInfo.AppendLine($"Process name: {info.Process.ProcessName}");
                processInfo.AppendLine($"CPU: {info.CpuUsage}%");
                processInfo.AppendLine($"Private Virtual Memory: {info.PrivateVirtualMemory} MB");
                processInfo.AppendLine($"Working memory: {info.WorkinglMemory} MB");
                processInfo.AppendLine($"Handles: {info.HandleCount}");
                currentProcessInfoLb.Text = processInfo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void divByZeroBtn_Click(object sender, EventArgs e)
        {
            CrashHelper.DivideByZero();
        }

        private void increaseMemoryBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(increaseMemoryInMB_ValueTB.Text, out var memoryValue))
                CrashHelper.IncreaseMemoryUsage(memoryValue);
            else
                MessageBox.Show("The value you entered is incorrect. Change it and try again.");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(workingMemoryValueToIncrease.Text, out var memoryValue))
                await CrashHelper.IncreaseWorkingMemory(memoryValue);
            else
                MessageBox.Show("The value you entered is incorrect. Change it and try again.");

        }
    }
}