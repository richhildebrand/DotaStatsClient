using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotaSite.ApiAccessor;
using DotaSite.Models;
using DotaSite.ViewModels;
using Newtonsoft.Json;

namespace DotaSite.Controllers
{
	public class HomeController : Controller
	{
        private readonly DotaWebApi api = new DotaWebApi();

		public ActionResult Index()
        {

			return View();
		}

        public ActionResult Search(string search)
        {
            var clanJson = api.SearchClans(search);
            var clans = JsonConvert.DeserializeObject<List<Clan>>(clanJson);

            var playersJson = api.SearchPlayers(search);
            var players = JsonConvert.DeserializeObject<List<Player>>(playersJson);

            var matchJson = api.SearchMatches(search);
            var match = JsonConvert.DeserializeObject<MatchDetail>(matchJson);

            var searchViewModel = new SearchViewModel();
            searchViewModel.clans = clans;
            searchViewModel.players = players;

            if (match != null) return RedirectToAction("Details", "Match", new {id = 1});
            else return View(searchViewModel);
        }
	}
}
