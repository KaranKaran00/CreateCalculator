using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCalculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            txtResult.Text = currentInput;
        }

        private void Evaluate()
        {
            if(operationPending)
            {
                double secoundNumber = double.Parse(currentInput);

                switch (operation)
                {
                    case "+":
                        result += secoundNumber;
                        break;
                    case "-":
                        result -= secoundNumber;
                        break;
                    case "*":
                        result *= secoundNumber;
                        break;
                    case "/":
                        if(secoundNumber != 0)
                        {
                            result /= secoundNumber;
                        }
                        else
                        {
                            txtResult.Text = "Error";
                            return;
                        }
                        break;
                }
                txtResult.Text = result.ToString();
                currentInput = "";
                operationPending = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void bntEqual_Click(object sender, EventArgs e)
        {
            Evaluate();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (operationPending)
            {
                Evaluate();
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            txtResult.Text = "";
        }
    }
}
