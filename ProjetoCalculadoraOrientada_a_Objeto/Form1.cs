using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCalculadoraOrientada_a_Objeto.Classe;

namespace ProjetoCalculadoraOrientada_a_Objeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a, b;
            a = decimal.Parse(txtNumero1.Text);
            b = decimal.Parse(txtNumero2.Text);

            switch (cmbFunc.Text)
            {
                case "Somar":
                    {
                        CalculadoraBasica calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        calc.Somar();
                        lblResulatado.Text = calc.Resultado.ToString();
                        break;
                    }
                case "Subtrair":
                    {
                        CalculadoraBasica calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResulatado.Text = calc.Subtrair();
                        break;
                    }
                case "Multiplicar":
                    {
                        CalculadoraBasica calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResulatado.Text = calc.Multiplicar().ToString();
                        MessageBox.Show("Confirmar");
                        break;
                    }
                case "Dividir1":
                    {
                        CalculadoraBasica calc = new CalculadoraBasica();
                        lblResulatado.Text = calc.Dividir(a, b);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
