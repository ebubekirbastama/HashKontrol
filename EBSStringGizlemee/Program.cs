using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EBSStringGizlemee
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            hashkontrol.CalculateFileHash(Process.GetCurrentProcess().MainModule.FileName, "56b9e36cc489520586327821ab190f9937893b0a3f4ec81fc8f5ffcb154fd45b", "561dwsf31wefwef");
            
        }
    }
}
