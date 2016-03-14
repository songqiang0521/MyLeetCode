using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ExcelColumn_CS
{
    class Program
    {
        public static int TitleToNumber(string s)
        {
            int length = s.Length;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                char c = s[i];
                int number = c - 'A' + 1;
                result = (result << 5) - result - result - result - result - result - result + number;
                //result = result * 26 + number;
            }

            return result;
        }

        public static string NumberToTitle(int n)
        {
            string title = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";
            List<char> results = new List<char>(8);

            while (n > 0)
            {
                int index = (n - 1) % 26;
                results.Add(title[index]);
                n = (n - 1) / 26;
            }
            for (int i = 0; i < results.Count; i++)
            {
                result += results[results.Count - i - 1];
            }

            return result;
        }

        static void Main(string[] args)
        {

            for (int i = 1; i < 10000; i++)
            {
                var title = NumberToTitle(i);
                var number = TitleToNumber(title);
                Debug.Assert(number == i);
            }



        }
    }
}
