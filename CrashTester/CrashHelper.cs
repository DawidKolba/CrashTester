
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CrashTester
{
    public static class CrashHelper
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetProcessWorkingSetSize(IntPtr process, IntPtr minimumWorkingSetSize, IntPtr maximumWorkingSetSize);
        private static List<Stream>? _openHandles = null;

        public static void DivideByZero()
        {
            var zero = 0;
            var test = 0 / zero;
        }

        public static async Task IncreaseMemoryUsage(int megabytes)
        {
            await Task.Run(() =>
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
            });
        }

        public static void ExceedMaxArray()
        {
            var tst = new int[10];
            for (int i = 0; i < 11; i++)
            {
                tst[i] = i;
            }
        }

        public static async Task SetProcessHandlesCountTo(int targetHandleCount)
        {
            if (_openHandles == null)
                _openHandles = new List<Stream>();
            else
            {
                foreach (var handle in _openHandles)
                {
                    handle.Dispose();
                }
                _openHandles.Clear();
            }
            await IncreaseProcessHandle(targetHandleCount);
        }

        private static async Task IncreaseProcessHandle(int targetHandleCount)
        {
            await Task.Run(() =>
            {
                var currentProcess = Process.GetCurrentProcess();
                int currentHandleCount = currentProcess.HandleCount;

                if (targetHandleCount <= currentHandleCount)
                {
                    return;
                }

                int handlesToCreate = targetHandleCount - currentHandleCount;

                try
                {
                    for (int i = 0; i < handlesToCreate; i++)
                    {
                        string fileName = Path.Combine(Path.GetTempPath(), $"tempHandleFile{i}.tmp");
                        var fs = File.Create(fileName);
                        _openHandles.Add(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            });
        }

        public static async Task IncreaseWorkingMemory(int megabytes)
        {
            await Task.Run(() =>
            {
                Process currentProcess = Process.GetCurrentProcess();
                long bytesToAllocate = megabytes * 1024L * 1024L; // przeliczenie na bajty
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
                    MessageBox.Show(ex.Message);
                }

            });
        }

        internal static void CloseWindowRemainProcess(Form activeForm)
        {
            Thread backgroundThread = new Thread(() =>
            {
                while (true)
                {
                    Task.Delay(1000).Wait();
                }
            });
            backgroundThread.Start();

            activeForm.Invoke(new MethodInvoker(() => activeForm.Close()));
        }
    }
}
