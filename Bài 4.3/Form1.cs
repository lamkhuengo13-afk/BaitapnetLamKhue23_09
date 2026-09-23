using System;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;       
        private string currentOperation = "";  
        private bool isNewEntry = true;       

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewEntry || txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
                isNewEntry = false; 
            }

            txtDisplay.Text += btn.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            double.TryParse(txtDisplay.Text, out currentValue);

            currentOperation = btn.Text;

            isNewEntry = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondValue;
            double.TryParse(txtDisplay.Text, out secondValue);
            double result = 0;

            switch (currentOperation)
            {
                case "+": result = currentValue + secondValue; break;
                case "-": result = currentValue - secondValue; break;
                case "*": result = currentValue * secondValue; break;
                case "/":
                    if (secondValue == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = currentValue / secondValue;
                    break;
            }

            txtDisplay.Text = result.ToString();

            currentOperation = "";
            isNewEntry = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            currentValue = 0;
            currentOperation = "";
            isNewEntry = true;
        }
    }
}