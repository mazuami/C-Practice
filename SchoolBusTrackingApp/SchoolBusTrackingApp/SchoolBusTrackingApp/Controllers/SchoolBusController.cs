using SchoolBusRepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolBusTrackingApp.Controllers
{
    public class SchoolBusController : ApiController
    {
        public IGetBusDetails busdetails;

        public SchoolBusController(IGetBusDetails p)
        {
            this.busdetails = p;
        }

        [Authorize]
        [HttpGet]


        public HttpResponseMessage GetBusDetails()
        {   try
                    { 
                    var data = busdetails.getBusDetails();
                    return this.Request.CreateResponse(HttpStatusCode.OK, data);
                    }
            catch(Exception e)
                    {
                    return this.Request.CreateResponse(HttpStatusCode.NotFound, e.Message);
                    }
        }
    }
}
