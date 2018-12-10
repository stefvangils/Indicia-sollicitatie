using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndiciaAssignments.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IndiciaAssignments.Tests
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<string> fizzBuzzList = fizzBuzz.CheckNumbers(15, 30);
            Assert.AreEqual("Buzz", fizzBuzzList[5]);
            Assert.AreEqual(16, fizzBuzzList.Count);

        }

        [TestMethod]
        public void TestSommatie()
        {
            Sommatie sommatie = new Sommatie();
            decimal number = sommatie.DoSommatie();
            Assert.AreEqual(1.337, Convert.ToDouble(number));
        }

        [TestMethod]
        public void TestPlain()
        {
            Plain plain = new Plain();
            Dictionary<int, int> numbers = plain.GeneratePlain();
            int value = 0;
            foreach (var grp in numbers)
            {
                if(grp.Key == 12)
                {
                    value = grp.Value;
                }
            }
            Assert.AreEqual(44, value);
        }

        [TestMethod]
        public void TestJson()
        {
            Json json = new Json();
            string values = json.GenerateJson();
            List<Value> allValues = new List<Value>();
            allValues = JsonConvert.DeserializeObject<List<Value>>(values);
            int value = 0;
            foreach (Value grp in allValues)
            {
                if (grp.Key == 12)
                {
                    value = grp.Total;
                }
            }
            Assert.AreEqual(44, value);


        }
    }
}
