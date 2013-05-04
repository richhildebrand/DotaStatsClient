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
    public class ClanController : Controller
    {
        //
        // GET: /Clan/
        private readonly DotaWebApi api = new DotaWebApi();

        public ActionResult List()
        {
            var clansJson = api.GetClans();
            var clans = JsonConvert.DeserializeObject<List<Clan>>(clansJson);
            return View(clans);
        }

        public ActionResult Details(string clanId)
        {
            var clanJson = api.GetClanDetails(clanId);
            var clan = JsonConvert.DeserializeObject<Clan>(clanJson);
            return View(clan);
        }
    }
}
