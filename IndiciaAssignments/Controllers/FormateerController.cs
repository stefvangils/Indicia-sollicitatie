using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IndiciaAssignments.Models;

namespace IndiciaAssignments.Controllers
{
    public class FormateerController : ApiController
    {
        public decimal GetSommatie()
        {
            Sommatie sommatie = new Sommatie();
            decimal number = sommatie.DoSommatie();

            return number;
        }
    }
}
