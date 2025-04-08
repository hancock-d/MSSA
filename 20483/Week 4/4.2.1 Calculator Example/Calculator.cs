using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private double? _currentValue; // Stores the current value in operation
        private string _currentOperation; // Stores the current operation (+, -, *, /)

        public Calculator()
        {
            InitializeComponent();
        }


        private void buttonZero_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            AddDigit(".");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear the current values and reset the operation
            _currentValue = null;
            _currentOperation = null;
            textBoxCurrentOps.Text = "";
            textBoxResults.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            // Perform the calculation when the equal button is clicked
            PerformCalculation();
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            // Set the operation to addition
            SetOperation("+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            // Set the operation to subtraction
            SetOperation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // Set the operation to multiplication
            SetOperation("x");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            // Set the operation to division
            SetOperation("/");
        }

        private void AddDigit(string digit)
        {
            // Append digit to the current operation text box
            if (textBoxResults.Text == "0" && digit != ".")
            {
                textBoxResults.Text = digit;
            }
            else
            {
                textBoxResults.Text += digit;
            }

            textBoxCurrentOps.Text += digit;
        }
        private void SetOperation(string operation)
        {
            if (_currentValue == null)
            {
                // If there is no current value, parse it from the results text box and display it with the operation
                _currentValue = double.Parse(textBoxResults.Text);
                textBoxCurrentOps.Text = $"{_currentValue} {operation} ";
            }
            else
            {
                // Perform the previous calculation and set the result as the current value
                PerformCalculation();
                _currentValue = double.Parse(textBoxResults.Text);
                textBoxCurrentOps.Text = $"{_currentValue} {operation} ";
            }
            _currentOperation = operation;
            textBoxResults.Text = "0";
        }

        private void PerformCalculation()
        {
            if (_currentOperation == null) return;

            double newValue = double.Parse(textBoxResults.Text);
            double result = 0;

            // Perform the appropriate calculation based on the current operation
            switch (_currentOperation)
            {
                case "+":
                    result = _currentValue.Value + newValue;
                    break;
                case "-":
                    result = _currentValue.Value - newValue;
                    break;
                case "x":
                    result = _currentValue.Value * newValue;
                    break;
                case "/":
                    result = _currentValue.Value / newValue;
                    break;
            }

            // Display the result and reset the current operation
            textBoxResults.Text = result.ToString();
            _currentValue = result;
            _currentOperation = null;
        }
    }
}