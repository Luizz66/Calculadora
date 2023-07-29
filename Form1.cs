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
using static Calculadora.Op;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private string entrada = "";
        private string operacao = "";

        private List<decimal> numeros = new();
        public Calculadora()
        {
            InitializeComponent();
            Campo.ReadOnly = true;
            Campo.BackColor = Color.White;
            label1.BackColor = Color.White;
        }

        private void Campo_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)//+
        {
            if (Campo.Text != "")
            {
                numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
                label1.Text = "+";
                operacao = "soma";
                Campo.Text = "";
            }
            else { MessageBox.Show("Digite um valor para efetuar a operação"); }
        }

        private void button11_Click(object sender, EventArgs e)//-
        {
            if (Campo.Text != "")
            {
                numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
                label1.Text = "-";
                operacao = "sub";
                Campo.Text = "";
            }
            else { MessageBox.Show("Digite um valor para efetuar a operação"); }
        }

        private void button14_Click(object sender, EventArgs e)//x
        {
            if (Campo.Text != "")
            {
                numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
                label1.Text = "x";
                operacao = "mult";
                Campo.Text = "";
            }
            else { MessageBox.Show("Digite um valor para efetuar a operação"); }
        }

        private void button15_Click(object sender, EventArgs e)//÷
        {
            if (Campo.Text != "")
            {
                numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
                label1.Text = "÷";
                operacao = "div";
                Campo.Text = "";
            }
            else { MessageBox.Show("Digite um valor para efetuar a operação"); }
        }

        private void button18_Click(object sender, EventArgs e)//=
        {
            if (Campo.Text != "")
            {
                numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
                Campo.Text = Operação(numeros, operacao).ToString();
                numeros.Clear();
                label1.Text = "=";
            }
            else { MessageBox.Show("Digite um valor para efetuar a operação"); }
        }

        private void button13_Click(object sender, EventArgs e) { Campo.Text += "0"; Operação(numeros, operacao); }
        private void button1_Click(object sender, EventArgs e) => Campo.Text += "1";
        private void button2_Click(object sender, EventArgs e) => Campo.Text += "2";
        private void button3_Click(object sender, EventArgs e) => Campo.Text += "3";
        private void button4_Click(object sender, EventArgs e) => Campo.Text += "4";
        private void button5_Click(object sender, EventArgs e) => Campo.Text += "5";
        private void button6_Click(object sender, EventArgs e) => Campo.Text += "6";
        private void button7_Click(object sender, EventArgs e) => Campo.Text += "7";
        private void button8_Click(object sender, EventArgs e) => Campo.Text += "8";
        private void button9_Click(object sender, EventArgs e) => Campo.Text += "9";
        private void button10_Click(object sender, EventArgs e) => Campo.Text += ".";

        private void button16_Click(object sender, EventArgs e)
        {//C
            Campo.Text = "";
            label1.Text = "";
            operacao = "";
            numeros.Clear();
            entrada = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {//CE
            Campo.Text = "";
        }

    }
}
