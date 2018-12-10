using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiciaAssignments.Models
{
    public class Json
    {
        public string GenerateJson()
        {
            IEnumerable<int> numbers = RandomNumbers();
            var g = numbers.GroupBy(i => i).OrderByDescending(group => group.Count());
            List<Value> allValues = new List<Value>();
            foreach (var grp in g)
            {             
                allValues.Add(new Value(grp.Key, grp.Count()));
            }
            string json = JsonConvert.SerializeObject(allValues);
            return json;
        }
        private static IEnumerable<int> RandomNumbers(int seed = 123)

        {
            var random = new Random(seed);

            for (int i = 0; i < 1000; i++)

            {
                yield return random.Next(25);

            }
        }
    }
}