using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace UserMessenger {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            bool createdNew;
            Mutex m = new Mutex(true, "UserMessager1.0", out createdNew);
            if (!createdNew) {
                MessageBox.Show("Instance already running.");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                using (UserMessengerIcon umi = new UserMessengerIcon()) {
                    umi.Display();
                    Application.Run();
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Program Terminated Unexpectedly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
