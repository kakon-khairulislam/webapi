using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapifinal.Models;

namespace webapifinal.Controllers
{
     
    public class NewapiController : ApiController
    {
        practice_webapiEntities3 db = new practice_webapiEntities3();
       
        
        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<datawebt> obj = db.datawebts.ToList();
            return Ok(obj);
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult Action(string id)
        {

            var obj = db.datawebts.Where(model => model.st_ID == id).FirstOrDefault();
            return Ok(obj);
        }

    }
}
