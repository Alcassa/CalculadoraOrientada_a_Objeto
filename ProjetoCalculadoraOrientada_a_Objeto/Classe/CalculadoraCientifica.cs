using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCalculadoraOrientada_a_Objeto;

namespace ProjetoCalculadoraOrientada_a_Objeto.Classe
{
    class CalculadoraCientifica : CalculadoraBasica
    {
        public string Comparar()
        {
            if (Num1 > Num2)
            {
                return Num1 + " é maior " + Num2;
            }
            else if (Num1 < Num2)
            {
                return Num1 + " é menor " + Num2;
            }
            else
            {
                return Num1 + " é igual " + Num2;
            }
        }
        public string Par_Impar()
        {
            if (Num1 % 2 == 0)
            {
                return "É Par";
            }
            else { return "É Impar"; }

        }
        public double Potenciacao()
        {
            double result;
            Convert.ToDouble(Num1);
            Convert.ToDouble(Num2);
            result=Math.Pow((double)Num1,(double)Num2);
            return result;
        }

    }
}
