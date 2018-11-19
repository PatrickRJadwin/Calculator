using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadwin_Lab4
{
    class MemoryCalculator : Calculator
    {
        private decimal memoryValue;

        public decimal MemoryStore(decimal displayValue)
        {
            memoryValue = displayValue;
            return displayValue;
        }
        
        public void MemoryRecall(Textbox txtbx)
        {
            txtbx.Text = memoryValue.ToString;
        }

        public decimal MemoryAdd(decimal displayValue)
        {
            memoryValue += displayValue;
            return displayValue;
        }

        public void MemoryClear()
        {
            memoryValue = 0;
        }
    }
}
