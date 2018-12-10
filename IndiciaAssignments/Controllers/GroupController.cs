using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IndiciaAssignments.Models;
using Newtonsoft.Json;

namespace IndiciaAssignments.Controllers
{
    public class GroupController : ApiController
    {
        public Dictionary<int,int> GetPlain()
        {
            Plain plain = new Plain();
            Dictionary<int, int> numbers = plain.GeneratePlain();
            //numbers.Reverse().ToDictionary<>
                      
            return numbers; 
        }

        public string GetJson()
        {
            Json json = new Json();
            
            string values = json.GenerateJson();

            return values;
        }
    }
}
