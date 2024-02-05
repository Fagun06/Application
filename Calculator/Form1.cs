using System.Linq.Expressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1=0;
        double num2=0;
        double ans = 0;
        string operation;


        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "+";
            try
            {
                num1 = int.Parse(DisplayTextBox.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            DisplayTextBox.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = "-";
            try{
                num1 = int.Parse(DisplayTextBox.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            DisplayTextBox.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operation = "*";
            try
            {
                num1 = int.Parse(DisplayTextBox.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            DisplayTextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "/";
            try
            {
                num1 = int.Parse(DisplayTextBox.Text);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            DisplayTextBox.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try {
                num2 = int.Parse(DisplayTextBox.Text);

                if (operation == "+")
                    ans = num1 + num2;

                if (operation == "-")
                    ans = num1 - num2;

                if (operation == "*")
                    ans = num1 * num2;

                if (operation == "/")
                    ans = num1 / num2;

                DisplayTextBox.Text = ans + "";
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Clear();
        }
    }
}
