using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    partial class Simbolos
    {
        public static char[] Adicao =          "+"     .ToCharArray();
        public static char[] Subtracao =       "-"     .ToCharArray();
        public static char[] Multiplicacao =   "*xX"   .ToCharArray();
        public static char[] Divisao =         "/"     .ToCharArray();
        public static char[] Radiciacao =      "rq√RQ"   .ToCharArray();
        public static char[] Exponenciacao =   "^e"    .ToCharArray();
        public static char[] Fatorial =        "!"     .ToCharArray();

        public static char[] Basico { get => Adicao.Concat(Subtracao).ToArray(); }
        public static char[] Medio { get => Multiplicacao.Concat(Divisao).ToArray(); }

        public static char[] OperacoesBasicas { get => Basico.Concat(Medio).ToArray(); }

        public static char[] Especial { get => Radiciacao.Concat(Exponenciacao).Concat(Fatorial).ToArray(); }

        public static char[] Todos { get => OperacoesBasicas.Concat(Especial).ToArray(); }
    }
}
