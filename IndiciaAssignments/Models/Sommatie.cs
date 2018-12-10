using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiciaAssignments.Models
{
    public class Sommatie
    {
        private decimal number;
        public decimal DoSommatie()
        {
            
            object[] numbers = InputValues();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    number += Convert.ToDecimal(numbers[0]);
                }
                else if (i == 1)
                {
                    number += Decimal.Parse(numbers[1].ToString().Replace(",","."), System.Globalization.NumberStyles.Float);                  
                }
                else if(i == 3)
                {
                    number += Convert.ToDecimal(numbers[3]);
                }
                else if (i == 4)
                {
                    number += Convert.ToDecimal(numbers[4]) * 1000;
                    Math.Round(number);
                    number = number / 1000;
                }


            }

            return number;
        }
        private static object[] InputValues()

        {
            return new[]

            {
            "5",
            "1,2e2",
            null,
            "    -5555",
            "6.767"
            };

        }
    }
}