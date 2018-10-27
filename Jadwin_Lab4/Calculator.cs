/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 10-26-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jadwin_Lab4
{
    class Calculator
    {
        // Private fields
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        // Operator type to store enum
        private Operator op;
        // Enum for operation
        private enum Operator
        {
            None = 0,
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4
        }
        // Constructor
        public Calculator()
        {
            op = Operator.None;
        }
        // Getter and setter to get display value
        public decimal CurrentValue
        {
            get 
            {
                return currentValue;
            }
            set 
            {
                currentValue = value;
            }
        }
        // Operator selector
        public void Add(decimal displayValue)
        {
            Operation(Operator.Add, displayValue);
        }
        
        public void Subtract(decimal displayValue)
        {
            Operation(Operator.Subtract, displayValue);
        }

        public void Multiply(decimal displayValue)
        {
            Operation(Operator.Multiply, displayValue);
        }

        public void Divide(decimal displayValue)
        {
            Operation(Operator.Divide, displayValue);
        }
        
        private void Operation(Operator oper, decimal displayValue)
        {
            op = oper;
            operand1 = displayValue;
            currentValue = displayValue;
        }
        // Method to perform operation and get answer
        private void Equals()
        {
            try { 
                switch (op)
                {
                    case Operator.Add:
                        operand1 = operand1 + operand2;
                        break;
                    case Operator.Subtract:
                        operand1 = operand1 - operand2;
                        break;
                    case Operator.Multiply:
                        operand1 = operand1 * operand2;
                        break;
                    case Operator.Divide:
                        operand1 = operand1 / operand2;
                        break;
                }
            // Prevent division by 0
            } catch (DivideByZeroException) {
                MessageBox.Show("Divide by 0? That's a big n/0", "Divide by Zero Error");
            } catch (Exception) {
                MessageBox.Show("It's broke ¯\\_(ツ)_/¯", "Error");
            }
        }
        // Accessible method to get answer
        public decimal Equals(decimal displayValue)
        {
            operand2 = displayValue;
            Equals();
            return operand1;
        }
        // Clear calculator
        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = Operator.None;
        }
    }
}
