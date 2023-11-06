using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculradora_em_C_

    
{

    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "divisao";
            lblOperacao.Text = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (operacao){
                
                case "soma":
                    Soma calculadoraSoma = new Soma();
                    txtResultado.Text = Convert.ToString(calculadoraSoma.somar(valor1,
                        valor2));
                        break;
                case "subtracao":
                    Subtracao calculadoraSbtracao = new Subtracao();
                    txtResultado.Text = Convert.ToString(calculadoraSbtracao.subtrair(valor1,
                        valor2));
                        break;
                case "multiplicacao":
                    Multiplicacao calculadoraMultiplicacao = new Multiplicacao();
                    txtResultado.Text = Convert.ToString(calculadoraMultiplicacao.multiplicar(valor1,
                        valor2));
                        break;
                case "divisao":
                    Divisao calculadoraDivisao = new Divisao();
                    txtResultado.Text = Convert.ToString(calculadoraDivisao.dividir(valor1,
                        valor2));
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "subtracao";
            lblOperacao.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "multiplicacao";
            lblOperacao.Text = "X";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "soma";
            lblOperacao.Text = "+";
        }
    }

    public class Soma
    {
        public Soma()
        {
        }

        public decimal somar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }
    }

    public class Subtracao
    {
        public Subtracao()
        {
        }

        public decimal subtrair(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }
    }

    public class Multiplicacao
    {
        public Multiplicacao()
        {
        }

        public decimal multiplicar(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }
    }

    public class Divisao
    {
        public Divisao()
        {
        }

        public decimal dividir(decimal valor1, decimal valor2)
        {
            return valor1 / valor2;
        }
    }
}
