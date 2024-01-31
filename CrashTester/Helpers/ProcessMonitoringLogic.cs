using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Timers;

namespace TerminalMonitoringService.ProcessMonitoring
{
    public class ProcessMonitoringLogic : IDisposable
    {
        private string _processName;
        private static System.ComponentModel.IContainer _components = null;
        private static SafeHandle _resource;
        public Process? ProcessToCheck { get; set; }
        private System.Timers.Timer _processCheckingTimer = new System.Timers.Timer();
        private Dictionary<int, (DateTime lastCheck, TimeSpan lastTotalProcessorTime)> cpuUsageInfo = new Dictionary<int, (DateTime, TimeSpan)>();

        public delegate void ProcessInfoHandler(ProcessInfo info);
        public event ProcessInfoHandler ProcessInfoUpdated;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                if (_resource != null) _resource.Dispose();
            }
        }

        public void Dispose()
        {
            _processCheckingTimer.Stop();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public ProcessMonitoringLogic(Process process, double checkingIntervalInMs)
        {
            try
            {
                ProcessToCheck = process;
                _processName = process.ProcessName;
                _processCheckingTimer.Elapsed += new ElapsedEventHandler(ProcessMonitoring);
                _processCheckingTimer.Interval = checkingIntervalInMs;
                _processCheckingTimer.Start();
            }
            catch (Exception ex)
            {
                ProcessToCheck = null;
            }
        }

        public void StopMonitoringProcess()
        {
            Dispose();
        }

        private void ProcessMonitoring(object sender, EventArgs e)
        {
            try
            {               
                if (ProcessToCheck is null || ProcessToCheck.HasExited)
                {
                    ProcessToCheck = null;
                    return;
                }
                ProcessToCheck.Refresh();

                var cpuUsageTask = _getCpuUsage();
                cpuUsageTask.Wait();

                var cpuUsage = cpuUsageTask.Result;
                string cpuUsageString = cpuUsage == 105.0 ? "Access Denied"
                                    : cpuUsage == 101.0 ? "Error"
                                    : cpuUsage.ToString("N2");

                double PrivateMemoryMB = Math.Round(ProcessToCheck.PrivateMemorySize64 / 1024d / 1024d, 2);
                double WorkingMemoryMB = Math.Round(ProcessToCheck.WorkingSet64 / 1024d / 1024d, 2);
               
                var output = new ProcessInfo
                {
                    CpuUsage = cpuUsage,
                    HandleCount = ProcessToCheck.HandleCount,
                    PrivateVirtualMemory = PrivateMemoryMB,
                    Process = ProcessToCheck,
                    WorkinglMemory = WorkingMemoryMB
                };

                ProcessInfoUpdated?.Invoke(output);
            }
            catch (Exception ex)
            {
                _processCheckingTimer.Stop();
                ProcessToCheck = null;
            }
        }

        private async Task<double> _getCpuUsage()
        {
            try
            {
                double cpuUsage = 0.0;

                if (cpuUsageInfo.TryGetValue(ProcessToCheck.Id, out var lastCheck))
                {
                    var newCheckTime = DateTime.UtcNow;
                    var newTotalProcessorTime = ProcessToCheck.TotalProcessorTime;
                    var oldCheckTime = lastCheck.lastCheck;
                    var oldTotalProcessorTime = lastCheck.lastTotalProcessorTime;

                    double totalUsedTime = (newTotalProcessorTime - oldTotalProcessorTime).TotalMilliseconds;
                    double timeInterval = (newCheckTime - oldCheckTime).TotalMilliseconds;

                    cpuUsage = totalUsedTime / timeInterval / Environment.ProcessorCount * 100;
                }
                else
                {
                    cpuUsageInfo[ProcessToCheck.Id] = (DateTime.UtcNow, ProcessToCheck.TotalProcessorTime);
                    await Task.Delay(500);
                    return await _getCpuUsage();
                }

                return Math.Round(cpuUsage, 2);
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 5)  // 5 = Access Denied
            {
                return 105.0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return 101.0;
            }
        }
    }
}
