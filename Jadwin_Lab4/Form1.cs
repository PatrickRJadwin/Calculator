/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 11-19-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jadwin_Lab4
{
    public partial class CalcForm : Form
    {
        // Operators
        public decimal opr1;
        public decimal opr2;
        // Operation type
        public string operation;
        // Value to keep track of decimals
        public bool decCount = false;

        // Init class
        MemoryCalculator calc = new MemoryCalculator();

        public CalcForm()
        {
            InitializeComponent();
        }

        // Number click events
        private void zero_Click(object sender, EventArgs e)
        {
            text_Box_Change("0");
        }

        private void one_Click(object sender, EventArgs e)
        {
            text_Box_Change("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            text_Box_Change("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            text_Box_Change("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            text_Box_Change("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            text_Box_Change("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            text_Box_Change("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            text_Box_Change("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            text_Box_Change("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            text_Box_Change("9");
        }

        // Decimal event
        private void dec_Click(object sender, EventArgs e)
        {
            // Error checking to allow only one decimal
            if (decCount == false)
            {
                text_Box_Change(".");
                decCount = true;
            }
            else
            {
                MessageBox.Show("A number can only have one decimal place", "Too many decimals");
            }
        }

        // Operator events
        private void plus_Click(object sender, EventArgs e)
        {
            store_Op("add");
        }
        
        private void subtract_Click(object sender, EventArgs e)
        {
            store_Op("sub");
        }

        private void mult_Click(object sender, EventArgs e)
        {
            store_Op("mult");
        }

        private void div_Click(object sender, EventArgs e)
        {
            store_Op("div");
        }

        // Method to change text box when button is clicked
        private void text_Box_Change(string number)
        {
            calcTextBox.Text = calcTextBox.Text + number;
        }

        // Store the operator and number
        private void store_Op(string slctOperate)
        {
            operation = slctOperate;
            opr1 = decimal.Parse(calcTextBox.Text);
            calcTextBox.Clear();
            decCount = false;
        }

        // Equal button event
        private void equal_Click(object sender, EventArgs e)
        {
            // Check which operation to perform
            switch (operation)
            {
                case "add":
                    calc.Add(opr1);
                    break;
                case "sub":
                    calc.Subtract(opr1);
                    break;
                case "mult":
                    calc.Multiply(opr1);
                    break;
                case "div":
                    calc.Divide(opr1);
                    break;
            }
            // Check if number is entered and perform operation/print answer
            if (decimal.TryParse(calcTextBox.Text, out opr2))
            {
                decimal answer = calc.Equals(opr2);

                calcTextBox.Clear();
                calcTextBox.Text = answer.ToString();

                decCount = false;
            }
            else
            {
                MessageBox.Show("You need to enter a value", "Null value detected");
            }
        }

        // Clear button event
        private void Clear_Click(object sender, EventArgs e)
        {
            calcTextBox.Clear();
            calc.Clear();
            opr1 = 0;
            opr2 = 0;
            operation = null;
            decCount = false;
        }

        // Convert to Negative/Positive button event
        private void negPos_Click(object sender, EventArgs e)
        {
            decimal convNum = 0;
            if (decimal.TryParse(calcTextBox.Text, out convNum))
            {
                convNum *= -1;
                calcTextBox.Text = convNum.ToString();
            }
            else
            {
                MessageBox.Show("You need to enter a number", "No Number Found");
            }
        }

        // Reciprocal button event
        private void reciprocal_Click(object sender, EventArgs e)
        {
            decimal recNum = 0;
            if (decimal.TryParse(calcTextBox.Text, out recNum))
            {
                recNum = 1 / recNum;
                calcTextBox.Text = recNum.ToString();
            }
            else
            {
                MessageBox.Show("You need to enter a number", "No Number Found");
            }
        }

        // Square root button event
        private void sqroot_Click(object sender, EventArgs e)
        {
            double sqrNum = 0;
            if (double.TryParse(calcTextBox.Text, out sqrNum))
            {
                sqrNum = Math.Sqrt(sqrNum);
                calcTextBox.Text = sqrNum.ToString();
            }
            else
            {
                MessageBox.Show("You need to enter a number", "No Number Found");
            }
        }

        // Erase last digit event
        private void back_Click(object sender, EventArgs e)
        {
            string field = calcTextBox.Text;
            char period = '.';
            //Check if field is empty
            if (!string.IsNullOrEmpty(field))
            {
                if (field[field.Length - 1] == period)
                {
                    decCount = false;
                }

                field = field.Substring(0, field.Length - 1);
                
                calcTextBox.Text = field;
            }
            else
            {
                MessageBox.Show("Nothing to delete", "Null Field");
            }
        }

        // Clear memory action
        private void memClr_Click(object sender, EventArgs e)
        {
            calc.MemoryClear(mem);
        }

        // Recall memory action
        private void memRecall_Click(object sender, EventArgs e)
        {
            calc.MemoryRecall(calcTextBox);
        }

        // Store memory action
        private void memSave_Click(object sender, EventArgs e)
        {
            decimal num = 0;
            if (decimal.TryParse(calcTextBox.Text, out num))
            {
                calc.MemoryStore(num, mem);
            }
            else
            {
                MessageBox.Show("You need to enter a number", "No Number Found");
            }
        }

        // Add display val to memory
        private void memAdd_Click(object sender, EventArgs e)
        {
            decimal num = 0;
            if (decimal.TryParse(calcTextBox.Text, out num))
            {
                calc.MemoryAdd(num);
            }
            else
            {
                MessageBox.Show("You need to enter a number", "No Number Found");
            }
        }
    }
}
