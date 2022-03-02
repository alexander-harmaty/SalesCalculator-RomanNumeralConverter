using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab3
{
    public static class Extensions
    {
        public static string toRoman(this int num)
        {
            int temp = num;
            String roman = "";

            while (temp > 0)
            {
                if (temp >= 1000)
                {
                    roman = roman + "M";
                    temp = temp - 1000;
                }
                else if (temp >= 900)
                {
                    roman = roman + "CM";
                    temp = temp - 900;
                }
                else if (temp >= 500)
                {
                    roman = roman + "D";
                    temp = temp - 500;
                }
                else if (temp >= 400)
                {
                    roman = roman + "CD";
                    temp = temp - 400;
                }
                else if (temp >= 100)
                {
                    roman = roman + "C";
                    temp = temp - 100;
                }
                else if (temp >= 90)
                {
                    roman = roman + "XC";
                    temp = temp - 90;
                }
                else if (temp >= 50)
                {
                    roman = roman + "L";
                    temp = temp - 50;
                }
                else if (temp >= 40)
                {
                    roman = roman + "XL";
                    temp = temp - 40;
                }
                else if (temp >= 10)
                {
                    roman = roman + "X";
                    temp = temp - 10;
                }
                else if (temp >= 9)
                {
                    roman = roman + "IX";
                    temp = temp - 9;
                }
                else if (temp >= 5)
                {
                    roman = roman + "V";
                    temp = temp - 5;
                }
                else if (temp >= 4)
                {
                    roman = roman + "IV";
                    temp = temp - 4;
                }
                else if (temp >= 1)
                {
                    roman = roman + "I";
                    temp = temp - 1;
                }
            }

            return roman;
        }
    }
}
