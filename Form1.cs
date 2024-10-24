using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static Calculadora.Op;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            Campo.ReadOnly = true;
            Campo.BackColor = Color.White;
            CampoCima.ReadOnly = true;
            CampoCima.BackColor = Color.White;
        }

        private string operador;
        private readonly List<decimal> numeros = new();

        private void Sum(object sender, EventArgs e)
        {
            Action("+");
        }

        private void Sub(object sender, EventArgs e)
        {
            Action("-");
        }

        private void Mult(object sender, EventArgs e)
        {
            Action("x");
        }

        private void Div(object sender, EventArgs e)
        {
            Action("÷");
        }

        private void Equal(object sender, EventArgs e)
        {
            if (Campo.Text != "" && numeros.Count > 0)
            {
                numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
                CampoCima.Text = numeros[0].ToString() + " " + operador + " " + numeros[1].ToString() + " " + "=";
                Campo.Text = Operate(numeros, operador).ToString();

                numeros.Clear();
            }
            else if (numeros.Count == 0) { }
            else { CampoCimaOperation("="); }
        }

        private void Button0(object sender, EventArgs e) => Campo.Text += "0";
        private void Button1(object sender, EventArgs e) => Campo.Text += "1";
        private void Button2(object sender, EventArgs e) => Campo.Text += "2";
        private void Button3(object sender, EventArgs e) => Campo.Text += "3";
        private void Button4(object sender, EventArgs e) => Campo.Text += "4";
        private void Button5(object sender, EventArgs e) => Campo.Text += "5";
        private void Button6(object sender, EventArgs e) => Campo.Text += "6";
        private void Button7(object sender, EventArgs e) => Campo.Text += "7";
        private void Button8(object sender, EventArgs e) => Campo.Text += "8";
        private void Button9(object sender, EventArgs e) => Campo.Text += "9";
        private void ButtonPoint(object sender, EventArgs e) => Campo.Text += ".";
        private void ClearEntry(object sender, EventArgs e) => Campo.Text = "";
        private void Clear(object sender, EventArgs e)
        {
            Campo.Text = "";
            CampoCima.Text = "";
            operador = "";
            numeros.Clear();
        }

        public string CampoCimaOperation(string input = "")
        {
            string operation = CampoCima.Text = Operate(numeros, operador).ToString() + " " + operador + " ";
            operation = input == "=" ? operation + "=" : operation;
            return operation;
        }

        public void Calculate()
        {
            numeros.Add(decimal.Parse(Campo.Text, CultureInfo.InvariantCulture));
            CampoCima.Text = Operate(numeros, operador).ToString() + " " + operador + " ";
            Campo.Text = "";
        }

        public void Action(string op)
        {
            if (Campo.Text != "" && CampoCima.Text != "")
            {
                Calculate();
            }
            operador = op;
            if (Campo.Text != "")
            {
                Calculate();
            }
            else if (Campo.Text == "") { }
            else { CampoCimaOperation(); }
        }

    }
}
