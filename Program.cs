using System;
using System.Windows.Forms;

namespace SkillsInternational
{
    /// <summary>
    /// Application entry point.
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Start with the Login form
            Application.Run(new Form1());
        }
    }
}
