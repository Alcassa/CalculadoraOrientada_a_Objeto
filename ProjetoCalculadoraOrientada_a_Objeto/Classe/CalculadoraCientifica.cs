using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCalculadoraOrientada_a_Objeto;

namespace ProjetoCalculadoraOrientada_a_Objeto.Classe
{
    class CalculadoraCientifica: CalculadoraBasica
    {
        public void Comparar()
        {

        }
        public string Par_Impar()
        {
            string numero,num2;
            if(Num1%2==0)
            {
                return numero = "O primeiro é Par";
            }
            else { return numero = "O primeiro é Impar"; }
            
        }
        public decimal Potenciacao()
        {
            return 0;
        }
         
    }
}
