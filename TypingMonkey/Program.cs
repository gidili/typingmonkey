using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TypingMonkey
{
    static class Program
    {
        //Win32 API calls necesary to raise an unowned processs main window
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        private static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsThisProcessAlreadyRunning())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else 
            {
                BringOnFront();
            }
        }

        public static bool IsThisProcessAlreadyRunning()
        {
            bool createdNew;
            mutex = new Mutex(false, Application.ProductName, out createdNew);
            return !createdNew;
        }

        public static void BringOnFront()
        {
            Process myProcess = Process.GetCurrentProcess();

            string myAsseblyName = Assembly.GetExecutingAssembly().GetName().Name;

            foreach (Process processId in Process.GetProcessesByName(myAsseblyName))
            {
                if (myProcess.Id != processId.Id)
                {
                    IntPtr hWnd = processId.MainWindowHandle;

                    if (IsIconic(hWnd))
                    {
                        ShowWindowAsync(hWnd, SW_RESTORE);
                    }

                    SetForegroundWindow(hWnd);

                    break;
                }
            }
        }
    }
}
