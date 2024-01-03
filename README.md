# Convert-Bat-to-exe

Quem nunca desenvolveu um programa em Batch e desejou executá-lo no formato executável (exe) para aumentar a complexidade do processo de engenharia reversa? Desenvolvi uma técnica especialmente para essas pessoas. No entanto, adotei uma abordagem única. Em vez de simplesmente converter o arquivo Batch para exe usando alguma ferramenta online, elaborei um programa simples que possibilita a execução de um arquivo .bat. Dessa forma, ao compilar o programa, ele se transforma em um executável.

Para desenvolver esse programa, basta criar um projeto do tipo Forms no Visual Studio C#. Em seguida, adicione o arquivo .bat aos recursos do projeto e insira o seguinte código:

﻿using System;
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
