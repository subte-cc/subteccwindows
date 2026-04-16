using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subte.cc
{
    internal static class Program
    {
        // Use a unique name for your application
        static Mutex mutex = new Mutex(true, "subte.ccupdater");

        [STAThread]
        static void Main()
        {
            // Try to acquire the mutex
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

                // Release at the end
                mutex.ReleaseMutex();
            }
            else
            {
                // Another instance is running, exit
                MessageBox.Show("Another instance is already running.");
            }
        }
    }
}