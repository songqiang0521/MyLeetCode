using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger_CS
{
    public class Solution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            str = str.Trim();

            bool negtive = str[0] == '-';
            bool active = str[0] == '+';
            if (negtive||active)
            {
                int endIndex = 1;
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]))
                    {
                        break;
                    }
                    endIndex++;
                }

                str = str.Substring(1, endIndex - 1);
            }
            else
            {
                int endIndex = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]))
                    {
                        break;
                    }
                    endIndex++;
                }
                str = str.Substring(0, endIndex);

            }

            //如果字符串的长度超过了long的范围，则直接返回
            if (negtive)
            {
                if (str.Length>int.MaxValue.ToString().Length)
                {
                    return int.MinValue;
                }
            }
            else
            {
                if (str.Length>int.MaxValue.ToString().Length)
                {
                    return int.MaxValue;
                }
            }


            long n = 0;
            for (int i = 0; i < str.Length; i++)
            {
                n = n * 10 + str[i] - '0';
            }

            if (negtive)
            {
                if (-n < int.MinValue)
                {
                    return int.MinValue;
                }
                return (int)-n;
            }
            else
            {
                if (n > int.MaxValue)
                {
                    return int.MaxValue;
                }

                  return (int)n;
            }

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int number = s.MyAtoi("21474836");
            int converted = Convert.ToInt32("21474836");
            Debug.Assert(number==converted);
        }
    }
}
