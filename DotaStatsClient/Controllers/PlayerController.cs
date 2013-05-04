using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotaSite.ApiAccessor;
using DotaSite.Models;
using Newtonsoft.Json;

namespace DotaSite.Controllers
{
    public class PlayerController : Controller
    {
        private readonly DotaWebApi api = new DotaWebApi();

        public PartialViewResult PlayerNavigation(string playerId)
        {
            return PartialView();
        }

        public ActionResult Overview(string playerId)
        {
            var playerJson = api.GetPlayerOverview(playerId);
            var playerMatches = JsonConvert.DeserializeObject<List<MatchDetail>>(playerJson);

            return View(playerMatches);
        }

        public ActionResult Matches(string playerId)
        {
            var playerJson = api.GetPlayerOverview(playerId);
            var playerMatches = JsonConvert.DeserializeObject<List<MatchDetail>>(playerJson);

            return View(playerMatches);
        }

        public ActionResult Heroes(string playerId)
        {
            var playerJson = api.GetPlayerOverview(playerId);
            var playerMatches = JsonConvert.DeserializeObject<List<MatchDetail>>(playerJson);

            return View(playerMatches);
        }
    }
}
