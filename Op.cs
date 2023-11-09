using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    internal static class Op
    {
        public static decimal Operate(List<decimal> nums, string op)
        {
            decimal resultado = 0;
            if (nums.Count > 0)
            {
                if (op == "+")
                {
                    resultado = nums.Aggregate((a, b) => a + b);
                    nums.Clear();
                    nums.Add(resultado);
                }
                else if (op == "-")
                {
                    resultado = nums.Aggregate((a, b) => a - b);
                    nums.Clear();
                    nums.Add(resultado);
                }
                else if (op == "x")
                {
                    resultado = nums.Aggregate((a, b) => a * b);
                    nums.Clear();
                    nums.Add(resultado);
                }
                else if (op == "÷")
                {
                    resultado = nums.Aggregate((a, b) => a / b);
                    nums.Clear();
                    nums.Add(resultado);
                }
                else
                {
                    return nums.FirstOrDefault();
                }
            }
            return nums[0];
        }

    }
}
