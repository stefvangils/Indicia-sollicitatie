using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiciaAssignments.Models
{
    public class Value
    {
        public int Key;
        public int Total;

        public Value(int key, int total)
        {
            Key = key;
            Total = total;
        }
    }
}