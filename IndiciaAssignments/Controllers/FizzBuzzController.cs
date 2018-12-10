using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IndiciaAssignments.Models;

namespace IndiciaAssignments.Controllers
{
    public class FizzBuzzController : ApiController
    {
        //[HttpGet]
        public IEnumerable<String> GetFizzBuzz(int from, int to)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<string> fizzBuzzList = fizzBuzz.CheckNumbers(from, to);

            return fizzBuzzList;
        }
    }
}
