using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;

namespace IBOS_intern.Controllers
{
    public class empAttController : ApiController
    {
        [Route("api/report")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = attServices.Report();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/absentlist")]
        [HttpGet]
        public HttpResponseMessage absent()
        {
            var data = attServices.absentlist();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }


}