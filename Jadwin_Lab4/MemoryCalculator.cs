/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 11-19-2018      *
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
    class MemoryCalculator : Calculator
    {
        // Store memory value
        private decimal memoryValue;

        // Constructor
        public MemoryCalculator() {}
        
        // Store memory
        public void MemoryStore(decimal displayValue, Label txtbx)
        {
            memoryValue = displayValue;
            // Change memory label to show value stored
            if (memoryValue != 0)
            {
                txtbx.Text = "M";
            }
        }
        
        // Recall value in memory
        public void MemoryRecall(TextBox txtbx)
        {
            txtbx.Text = memoryValue.ToString();
        }

        // Add display val to memory value
        public void MemoryAdd(decimal displayValue)
        {
            memoryValue += displayValue;
        }

        // Clear memory
        public void MemoryClear(Label txtbx)
        {
            memoryValue = 0;
            txtbx.Text = "";
        }
    }
}
