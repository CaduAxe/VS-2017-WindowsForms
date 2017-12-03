using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    class Linguagem
    {
        public static string[] Texto = File.ReadAllLines(Application.StartupPath.Replace(@"\bin\Debug", "") + @"\languages\" + ConfigurationManager.AppSettings["Language"] + ".txt");
        public static string Calculadora { get => Texto[0]; }
        public static string Calculo { get => Texto[1]; }
        public static string Calcular { get => Texto[2]; }
        public static string HelpCalculo { get => Texto[3].Replace("\\n", "\n"); }
        public static string SimboloInvalido { get => Texto[4]; }

    }
}
