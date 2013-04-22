using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotaSite.Models;
using Newtonsoft.Json;

namespace DotaSite.Controllers
{
    public class MatchController : Controller
    {
        private readonly DotaWebApi api = new DotaWebApi();

        public ActionResult Details(string matchId)
        {
            var matchJson = api.GetMatchDetails(matchId);
            var matchDetail = JsonConvert.DeserializeObject<MatchDetail>(matchJson);

            return View(matchDetail);
        }

        public ActionResult Recent()
        {
            var recentMatchesJson = api.GetRecentMatches();
            var matches = JsonConvert.DeserializeObject<List<MatchDetail>>(recentMatchesJson);
            return View(matches);
        }
    }
}
