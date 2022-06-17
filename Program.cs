using System;
using System.Collections.Generic;
using System.Text;

namespace TEsting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SanoqSistema.DecimalToBinary(200));
            Console.WriteLine(SanoqSistema.DecimalToOctal(200));
            Console.WriteLine(SanoqSistema.DecimalToHexDecimal(200));

        }
    }

    public static class SanoqSistema
    {
        public static string DecimalToHexDecimal(int number)
        {
            int quotient;
            int i = 1, j;
            char[] hexadecimalNumber = new char[100];
            char temp1;

            quotient = number;
            while (quotient != 0)
            {
                int temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                quotient = quotient / 16;
            }

            StringBuilder value = new StringBuilder();

            for (j = i - 1; j > 0; j--)
                value.Append(hexadecimalNumber[j]);

            return value.ToString();
        }

        public static string DecimalToBinary(int num)
        {
            string result;

            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;

            return result;
        }

        public static long DecimalToOctal(int number)
        {
            int i, j, octal = 0;
            i = 1;

            for (j = number; j > 0; j = j / 8)
            {
                octal = octal + (j % 8) * i;
                i = i * 10;
                number = number / 8;
            }

            return octal;
        }

    }

}


