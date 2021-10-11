using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GetLoanStatusTypeCreditor.Controllers
{
    [Route("GetLoanStatusTypeCreditor/[controller]")]
    [ApiController]
    public class LoanStatusController : ControllerBase
    {
        // GET: api/LoanStatus
        [HttpGet]
        public List<LoanStatus> Get()
        {
            this.Response.ContentType = "application/json";
            this.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            List<LoanStatus> values = new List<LoanStatus>();
            foreach (var itemType in Enum.GetValues(typeof(CreditorLoanStaus)))
            {
                //For each value of this enumeration, add a new EnumValue instance
                values.Add(new LoanStatus()
                {
                    Status_ID = Enum.GetName(typeof(CreditorLoanStaus), itemType),
                    Status = (int)itemType
                });
            }

            return values;
        }

        // POST: api/LoanStatus
        [HttpPost]
        public JsonResult Post([FromBody] string value)
        {
            try
            {
                HttpResponseMessage res = new HttpResponseMessage();

                this.Response.ContentType = "application/json";
                this.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return new JsonResult(res, new JsonSerializerSettings { Formatting = Formatting.Indented });
            }
            catch (Exception ex)
            {
                this.Response.StatusCode = 400;
                return new JsonResult(ex.Message);
            }
        }

        // PUT: api/LoanStatus/5
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] string value)
        {
            try
            {
                HttpResponseMessage res = new HttpResponseMessage();

                this.Response.ContentType = "application/json";
                this.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return new JsonResult(res, new JsonSerializerSettings { Formatting = Formatting.Indented });
            }
            catch (Exception ex)
            {
                this.Response.StatusCode = 400;
                return new JsonResult(ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            try
            {
                HttpResponseMessage res = new HttpResponseMessage();

                this.Response.ContentType = "application/json";
                this.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return new JsonResult(res, new JsonSerializerSettings { Formatting = Formatting.Indented });
            }
            catch (Exception ex)
            {
                this.Response.StatusCode = 400;
                return new JsonResult(ex.Message);
            }
        }

        // Options: GetLoanStatusTypeCreditor/ApiWithActions/5
        [HttpDelete("{id}")]
        public JsonResult Options(int id)
        {
            try
            {
                HttpResponseMessage res = new HttpResponseMessage();

                this.Response.ContentType = "application/json";
                this.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return new JsonResult(res, new JsonSerializerSettings { Formatting = Formatting.Indented });
            }
            catch (Exception ex)
            {
                this.Response.StatusCode = 400;
                return new JsonResult(ex.Message);
            }

        }
    }
}
