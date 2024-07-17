using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _45380011HePengCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "abcd123.456";
            string input2 = "abcd123";

            Console.WriteLine(ExtractNumber(input1)); // 输出 "123.45"  
            Console.WriteLine(ExtractNumber(input2)); // 输出 "123.00"  
        }

        public static string ExtractNumber(string input)
        {
            // 使用正则表达式提取数字部分  
            var match = Regex.Match(input, @"\d+(\.\d+)?");
            if (!match.Success)
            {
                return string.Empty;
            }

            // 使用小数点分隔整数部分和小数部分  
            var parts = match.Value.Split('.');
            // 保证小数部分有两位，不足补0，超出截取  
            string decimalPart = (parts.Length > 1 ? parts[1] : "").PadRight(2, '0').Substring(0, 2);

            return $"{parts[0]}.{decimalPart}";
        }
    }
}
