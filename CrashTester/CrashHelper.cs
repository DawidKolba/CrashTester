
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CrashTester
{
    public static class CrashHelper
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetProcessWorkingSetSize(IntPtr process, IntPtr minimumWorkingSetSize, IntPtr maximumWorkingSetSize);

        public static void DivideByZero()
        {
            var zero = 0;
            var test = 0 / zero;
        }

        public static void IncreaseMemoryUsage(int megabytes)
        {
            const int bytesPerMegabyte = 1024 * 1024;
            long totalBytes = megabytes * bytesPerMegabyte;
            var memoryList = new List<byte[]>();

            try
            {
                while (totalBytes > 0)
                {
                    int blockSize = (int)Math.Min(totalBytes, bytesPerMegabyte);
                    var block = new byte[blockSize];
                    memoryList.Add(block);
                    totalBytes -= blockSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static async Task IncreaseWorkingMemory(int megabytes)
        {
            await Task.Run(() =>
            {
                Process currentProcess = Process.GetCurrentProcess();
                long bytesToAllocate = megabytes * 1024L * 1024L; // Przeliczenie na bajty
                List<byte[]> memoryBlocks = new List<byte[]>();

                try
                {
                    while (currentProcess.WorkingSet64 < bytesToAllocate)
                    {
                        byte[] block = new byte[1024 * 1024];
                        new Random().NextBytes(block);
                        memoryBlocks.Add(block);

                        currentProcess.Refresh();
                    }
                }
                catch (Exception ex)
                {
                  MessageBox.Show ($"{ex.Message}");
                }
            });
        }
    }
}
