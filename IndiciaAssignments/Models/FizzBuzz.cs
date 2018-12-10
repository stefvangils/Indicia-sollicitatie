using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiciaAssignments.Models
{
    public class FizzBuzz
    {
        public List<string> CheckNumbers(int from, int to)
        {
            List<string> fizzBuzzList = new List<string>();
           to++;
            for (int i = from; i < to; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzList.Add("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    fizzBuzzList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzList.Add("Buzz");
                }
                else if(i % 3 != 0 && i % 5 != 0)
                {
                    fizzBuzzList.Add(i.ToString());
                }
            }

            return fizzBuzzList;
        }
    }
}