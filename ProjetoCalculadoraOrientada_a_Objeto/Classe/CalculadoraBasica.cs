using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadoraOrientada_a_Objeto.Classe
{
    public class CalculadoraBasica
    {
        decimal _Num1;
        decimal _Num2;
        decimal _Resultado;
        public decimal Num1 { get => _Num1; set => _Num1 = value; }
        public decimal Num2 { get => _Num2; set => _Num2 = value; }
        public decimal Resultado { get => _Resultado; set => _Resultado = value; }

        public void Somar()
        {
            _Resultado = _Num1 + _Num2;
        }

        public string Subtrair()
        {
            return (_Num1 - _Num2).ToString();
        }
        /// <summary>
        /// Calcula a multiplicação a partir de dois decimais 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>'
        public string Multiplicar(decimal n1, decimal n2)
        {
            return (n1 * n2).ToString();
        }
        public decimal Multiplicar()
        {
            return _Num1 * _Num2;
        }
        
        public string Dividir(decimal n1, decimal n2)
        {
            return (n1 / n2).ToString();
        }
    }
}
