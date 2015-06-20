using BargeSurvey.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.IO;
using System.Web;

namespace BargeSurvey.Controllers
{
    public class SurveyController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> Add(Survey survey)
        {
            if ( ! ModelState.IsValid || survey == null)
            {
                Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "You must submit a valid survey");
            }
            var loc = HttpContext.Current.Server.MapPath("~/App_Data/Surveys.txt");
            List<Survey> list;
            string items = File.ReadAllText(loc);
            list = JsonConvert.DeserializeObject<List<Survey>>(items);
            list.Add(survey);
            string json = JsonConvert.SerializeObject(list);
          
            File.WriteAllText(loc, json);
            
            return Request.CreateResponse(HttpStatusCode.OK);

        }

        [HttpGet]
        public async Task<HttpResponseMessage> List()
        {
            var loc = HttpContext.Current.Server.MapPath("~/App_Data/Surveys.txt");
            var list =  await Task.Factory.StartNew<List<Survey>>( () =>
            {
                string items = File.ReadAllText(loc);
                return JsonConvert.DeserializeObject<List<Survey>>(items);
            });
           
            return Request.CreateResponse<List<Survey>>(HttpStatusCode.OK, list);
        }
    }
}
