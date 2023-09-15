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
            if (txtNumero2.Text == "") { b = 0; }
            else
            {
                b = decimal.Parse(txtNumero2.Text);
            }
            txtNumero2.Enabled = true;
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
                case "ImparPar":
                    {
                        txtNumero2.Enabled = false;
                        var calc = new CalculadoraCientifica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResulatado.Text = calc.Par_Impar();
                        break;

                    }
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
