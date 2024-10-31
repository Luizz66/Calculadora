namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            MainField.ReadOnly = true;
            SmallField.ReadOnly = true;
        }

        private static double? value = null;
        private static string op;

        private void Sum_Click(object sender, EventArgs e)
        {
            if (MainField.Text != "" && SmallField.Text == "")
            {
                op = "+";
                value = Double.Parse(MainField.Text);
                SmallField.Text = $"{value}{op}";
                MainField.Text = "";
            }
            if (MainField.Text != "" && SmallField.Text != "")
            {
                Operate("+");
            }
            if (op == "=")
            {
                Operate("+");
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (MainField.Text != "" && SmallField.Text == "")
            {
                op = "-";
                value = Double.Parse(MainField.Text);
                SmallField.Text = $"{value}{op}";
                MainField.Text = "";
            }
            if (MainField.Text != "" && SmallField.Text != "")
            {
                Operate("-");
            }
            if (op == "=")
            {
                Operate("-");
            }

        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (MainField.Text != "" && SmallField.Text == "")
            {
                op = "x";
                value = Double.Parse(MainField.Text);
                SmallField.Text = $"{value}{op}";
                MainField.Text = "";
            }
            if (MainField.Text != "" && SmallField.Text != "")
            {
                Operate("x");
            }
            if (op == "=")
            {
                Operate("x");
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (MainField.Text != "" && SmallField.Text == "")
            {
                op = "÷";
                value = Double.Parse(MainField.Text);
                SmallField.Text = $"{value}{op}";
                MainField.Text = "";
            }
            if (MainField.Text != "" && SmallField.Text != "")
            {
                Operate("÷");
            }
            if (op == "=")
            {
                Operate("÷");
            }

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void btn0_Click(object sender, EventArgs e) => MainField.Text += "0";

        private void btn1_Click(object sender, EventArgs e) => MainField.Text += "1";

        private void btn2_Click(object sender, EventArgs e) => MainField.Text += "2";

        private void btn3_Click(object sender, EventArgs e) => MainField.Text += "3";

        private void btn4_Click(object sender, EventArgs e) => MainField.Text += "4";

        private void btn5_Click(object sender, EventArgs e) => MainField.Text += "5";

        private void btn6_Click(object sender, EventArgs e) => MainField.Text += "6";

        private void btn7_Click(object sender, EventArgs e) => MainField.Text += "7";

        private void btn8_Click(object sender, EventArgs e) => MainField.Text += "8";

        private void btn9_Click(object sender, EventArgs e) => MainField.Text += "9";

        private void Point_Click(object sender, EventArgs e) => MainField.Text += ".";

        private void ClearEntry_Click(object sender, EventArgs e) => MainField.Text = "";

        private void Clear_Click(object sender, EventArgs e)
        {
            value = null;
            op = null;
            MainField.Text = "";
            SmallField.Text = "";
        }

        public void Operate(string opInput)
        {
            if (op == "=")
            {
                Result();
                op = opInput;
                SmallField.Text = $"{value}{op}";
            }
            else
            {
                double currentValue = Double.Parse(MainField.Text);
                value = Calculate(value.GetValueOrDefault(), currentValue, op);

                op = opInput;
                SmallField.Text = $"{value}{op}";
                MainField.Text = "";
            }
        }

        public void Result()
        {
            if (MainField.Text == "" && op != "=")
            {
                SmallField.Text = $"{Calculate(value.GetValueOrDefault(), value.GetValueOrDefault(), op)}";

            }
            if (MainField.Text == "") { }
            else
            {
                double currentValue = Double.Parse(MainField.Text);
                value = Calculate(value.GetValueOrDefault(), currentValue, op);
                op = "=";
                SmallField.Text = $"{op}{value}";
                MainField.Text = "";
            }
        }

        private double Calculate(double value, double currentValue, string currentOp)
        {
            return currentOp switch
            {
                "+" => value + currentValue,
                "-" => value - currentValue,
                "x" => value * currentValue,
                "÷" => value / currentValue,
                _ => value
            };
        }
    }
}
