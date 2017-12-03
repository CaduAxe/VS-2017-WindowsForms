using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Formula
    {
        public string Texto { get; private set; }
        public string Resultado
        {
            get { return Search(); }
            internal set { }
        }

        public Formula(string Texto)
        {
            this.Texto = Texto + "+".Replace(" ", "");
        }

        private string Search()
        {
            double result = 0;
            int sinal = -1;

            SubstituicaoComplexa();

            for (int i = 0; i < Texto.Length; i++)
            {
                if (Simbolos.Medio.Contains(Texto[i]))
                {
                    PrioridadeUm(sinal, i, Texto[i]);
                    i = sinal + 1;
                }
                else if (Simbolos.Basico.Contains(Texto[i]))
                {
                    if (i != 0)
                        result = Calcular(result,
                            (sinal == -1) ? '+' : Texto[sinal],
                            double.Parse(Texto.Substring(sinal + 1, i - sinal - 1)));
                    sinal = i;
                }
            }
            return Math.Round(result,7).ToString();
        }

        private void SubstituicaoComplexa()
        {
            int sinal = -1;
            for (int i = 0; i < Texto.Length; i++)
            {
                if (Simbolos.OperacoesBasicas.Contains(Texto[i]))
                    sinal = i;
                else if (Simbolos.Especial.Contains(Texto[i]))
                    PrioridadeUm(sinal, i, Texto[i]);
            }
        }

        private double Calcular(double v1, char action, double v3)
        {
            if (Simbolos.Adicao.Contains(action))
                return v1 + v3;
            else if (Simbolos.Subtracao.Contains(action))
                return v1 - v3;
            else if (Simbolos.Multiplicacao.Contains(action))
                return v1 * v3;
            else if (Simbolos.Divisao.Contains(action))
                return v1 / v3;
            else if (Simbolos.Fatorial.Contains(action))
            {
                double Fatorial = 1;
                for (double i = v1; i > 1; i--)
                {
                    Fatorial *= i;
                }
                return Fatorial;
            }
            else if (Simbolos.Exponenciacao.Contains(action))
                return Math.Pow(v1, v3);
            else if (Simbolos.Radiciacao.Contains(action))
                return Math.Sqrt(v3);
            else
                throw new Exception(Linguagem.SimboloInvalido);
        }

        private int GetNextSymbol(int i)
        {
            return Texto.IndexOfAny(Simbolos.Todos, i + 1);
        }

        private void PrioridadeUm(int sinal, int i, char action)
        {
            string preTexto = Texto.Substring(0, sinal + 1);
            string posTexto = Texto.Substring(GetNextSymbol(i));

            double v1;
            #region v1 atribuicoes
            if (Simbolos.Radiciacao.Contains(action))
                v1 = 0;
            else
                v1 = double.Parse(Texto.Substring(sinal + 1, i - sinal - 1));
            #endregion
            double v2;
            #region v2 atribuicoes
            if (Simbolos.Fatorial.Contains(action))
                v2 = 0;
            else
                v2 = double.Parse(Texto.Substring(i + 1, GetNextSymbol(i) - i - 1));
            #endregion

            Texto = preTexto + Calcular(v1, action, v2) + posTexto;
        }
    }
}