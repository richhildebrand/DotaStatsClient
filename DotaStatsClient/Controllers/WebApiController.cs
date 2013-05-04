using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotaSite.ApiAccessor;

namespace DotaSite.Controllers
{
    public class WebApiController : Controller
    {
        //
        // GET: /WebAPI/

        public ActionResult MatchDetails(string matchId)
        {
            var api = new DotaWebApi();
            var matchJson = api.GetMatchDetails(matchId);
            return Content(matchJson, "application/json");
        }

    }
}
