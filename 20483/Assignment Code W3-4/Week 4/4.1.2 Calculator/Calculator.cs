namespace _4._1._2_Calculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }


        //Method to input the number pressed into the txtInput.text box
        private void InputNumber(string number)
        {
            txtInput.Text += number;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            InputNumber(".");
        }

        private void btnClear_Click(object sender, EventArgs e) //only clears txtInput block
        {
            txtInput.Clear();

        }
        private void btnMemoryClear_Click(object sender, EventArgs e) //clears everything
        {
            txtInput.Clear();
            txtHistory.Clear();
            num1 = 0;
            num2 = 0;
            operation = "";
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1);
            }
        }

        double num1 = 0; //assigns num1
        double num2 = 0; //assigns num2
        string operation = ""; //assigns operation (+-*/)

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "") //if no input(is empty), stores the operation and returns/exits to main event loop to wait for next action
            {
                operation = "+";
                return;
            }
            if (double.TryParse(txtInput.Text, out num1)) //converts txtInput.text to a number. If it doesn't, it won't use the + operation because num1 can't be assigned
            {
                operation = "+";
                txtInput.Clear();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                operation = "-";
                return;
            }
            if (double.TryParse(txtInput.Text, out num1)) //out num1 reassigns num1 from 0 to the txtInput value
            {
                operation = "-";
                txtInput.Clear();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                operation = "*";
                return;
            }
            if (double.TryParse(txtInput.Text, out num1))
            {
                operation = "*";
                txtInput.Clear();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                operation = "/";
                return;
            }
            if (double.TryParse(txtInput.Text, out num1))
            {
                operation = "/";
                txtInput.Clear();
            }
        }

        //Create an instance of ICalculator
        public ICalculator myCalculator = new Calculations();

        double result; //declares result
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out num2)) //take input for num2, re-assign to num2
            {
                switch (operation)
                {
                    case "+":
                        result = myCalculator.Add(num1, num2);
                        break;
                    case "-":
                        result = myCalculator.Subtract(num1, num2);
                        break;
                    case "*":
                        result = myCalculator.Multiply(num1, num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero");
                            txtInput.Clear();
                            return;
                        }
                        result = myCalculator.Divide(num1, num2);
                        break;
                }
            }
            txtInput.Text = result.ToString();
            txtHistory.Text = ($"{num1} {operation} {num2} = {result}");  //resets txtHistory from the calculation to the calculation just done
            num1 = result; //reassign num1 so it can carry-over into the next operation
            txtInput.Clear();
        }


    }
}
