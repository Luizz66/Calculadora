using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Calculadora
{
    internal static class Op
    {       
        public static decimal Operate(List<decimal> nums, string op)
        {
            decimal result = 0;
            if (nums.Count > 0)
            {
                if (op == "+")
                {
                    result = nums.Aggregate((a, b) => a + b);
                    nums.Clear();
                    nums.Add(result);
                }
                else if (op == "-")
                {
                    result = nums.Aggregate((a, b) => a - b);
                    nums.Clear();
                    nums.Add(result);
                }
                else if (op == "x")
                {
                    result = nums.Aggregate((a, b) => a * b);
                    nums.Clear();
                    nums.Add(result);
                }
                else if (op == "÷")
                {
                    result = nums.Aggregate((a, b) => a / b);
                    nums.Clear();
                    nums.Add(result);
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
