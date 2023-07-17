using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Op
    {
        public static decimal Operação(List<decimal> nums, string op)
        {         
            decimal resultado = 0;
            if (op == "soma")
            {
                return nums.Aggregate((a, b) => a + b);                          
            }
            else if (op == "sub")
            {
                return nums.Aggregate((a, b) => a - b);               
            }
            else if (op == "mult")
            {
                return nums.Aggregate((a, b) => a * b);              
            }
            else if (op == "div")
            {
                return nums.Aggregate((a, b) => a / b);               
            }
            else
            {
                return 0;              
            }
        }

        
    }
}
