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
    public class empController :ApiController
    {
        [Route("api/employees")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = empServices.All();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/basedonsalary")]
        [HttpGet]
        public HttpResponseMessage bos()
        {
            var data = empServices.salary();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/codeupdate")]
        [HttpPost]
        public HttpResponseMessage update (empDTO emp)
        {
            if (empServices.update(emp))
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated", data = emp });
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}