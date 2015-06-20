using BargeSurvey.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;


namespace BargeSurvey.Controllers
{
    public class DataController : ApiController
    {
        [HttpGet]
        public async Task<List<Customer>> Customers()
        {
            List<Customer> list = new List<Customer>();
            string loc = HttpContext.Current.Server.MapPath("~/App_Data/Customers.txt");
            string contents = File.ReadAllText(loc);
            list = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Customer>>(contents));
            list = list.OrderBy(i => i.Name).ToList<Customer>();
            return list;

        }

        [HttpGet]
        public async Task<List<Terminal>> Terminals()
        {
            List<Terminal> list = new List<Terminal>();
            string loc = HttpContext.Current.Server.MapPath("~/App_Data/Terminals.txt");
            string contents = File.ReadAllText(loc);
            list = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Terminal>>(contents));
            list = list.OrderBy(i => i.Name).ToList<Terminal>();
            return list;

        }

        [HttpGet]
        public async Task<List<Surveyor>> Surveyors()
        {
            List<Surveyor> list = new List<Surveyor>();
            string loc = HttpContext.Current.Server.MapPath("~/App_Data/Surveyors.txt");
            string contents = File.ReadAllText(loc);
            list = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Surveyor>>(contents));
            list = list.OrderBy(i => i.Name).ToList<Surveyor>();
            return list;

        }
    }
}
