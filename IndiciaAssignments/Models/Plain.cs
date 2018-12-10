using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndiciaAssignments.Models
{
    public class Plain
    {
        public Dictionary<int, int> GeneratePlain()
        {
            IEnumerable<int> numbers = RandomNumbers();
            var g = numbers.GroupBy(i => i).OrderByDescending(group => group.Count());
            Dictionary<int, int> GroupedValues = new Dictionary<int, int>();
            foreach (var grp in g)
            {
                GroupedValues.Add(grp.Key, grp.Count());
            }
            return GroupedValues;
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