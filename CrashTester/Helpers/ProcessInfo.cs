using System.Diagnostics;

namespace TerminalMonitoringService.ProcessMonitoring
{
    public class ProcessInfo
    {
        public Process Process { get; set; }
        public double CpuUsage { get; set; }
        public double PrivateVirtualMemory { get; set; }
        public double WorkinglMemory { get; set; }
        public int HandleCount { get; set; }
    }
}
