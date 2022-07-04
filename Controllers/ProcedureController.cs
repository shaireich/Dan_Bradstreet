using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dan_Bradstreet.Models;
using System.Text.Json;

namespace Dan_Bradstreet.Controllers
{
    public class ProcedureController : Controller
    {
        private DanBEntities db = new DanBEntities();

        public string Index()
        {
            return "Please Enter One Of Get Request Template";
        }

        public string GetOneProcedure(int year)
        {
            var json = JsonSerializer.Serialize(db.One(year));
            return @"{""AGENT_CODE"":" + @"" + json.Substring(1, json.Length - 2) + @"}";
        }

        public string GetTwoProcedure(string listAgentCode, int numOfLine)
        {
            var json = JsonSerializer.Serialize(db.Two(listAgentCode, numOfLine));
            return json.Substring(1, json.Length - 2);
        }

        public string GetThreeProcedure(int year, int numOfOrders)
        {
            var json = JsonSerializer.Serialize(db.Three(year, numOfOrders));
            return json.Substring(1, json.Length - 2);
        }
    }
}