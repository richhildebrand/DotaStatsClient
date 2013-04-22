﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotaSite.Models;
using Newtonsoft.Json;
using DotaSite.ViewModels;

namespace DotaSite.Controllers
{
    public class HeroController : Controller
    {
		private readonly DotaWebApi api = new DotaWebApi();

        //
        // GET: /Hero/
        public PartialViewResult HeroNavigation()
        {
            return PartialView();
        }

        public ActionResult WinRate()
        {
			string matchesJson = api.GetAllMatches();
			var matches = JsonConvert.DeserializeObject<List<MatchDetail>>(matchesJson);

            return View(matches);
        }

        public ActionResult MostPlayed()
        {
            string matchesJson = api.GetAllMatches();
            var matches = JsonConvert.DeserializeObject<List<MatchDetail>>(matchesJson);

            return View(matches);
        }

        public ActionResult GameImpact()
        {
            string matchesJson = api.GetAllMatches();
            var matches = JsonConvert.DeserializeObject<List<MatchDetail>>(matchesJson);

            return View(matches);
        }

        public ActionResult Economy()
        {
            string matchesJson = api.GetAllMatches();
            var matches = JsonConvert.DeserializeObject<List<MatchDetail>>(matchesJson);

            return View(matches);
        }

    }
}
