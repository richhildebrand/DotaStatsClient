using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotaSite
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "PlayerDetails",
                url: "Player/{action}/{playerId}",
                defaults: new {controller = "Player",  playerId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MatchDetails",
                url: "Match/{action}/{matchId}",
                defaults: new {controller = "Match", matchId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ClanDetails",
                url: "Clan/{action}/{clanId}",
                defaults: new { controller = "Clan", matchId = UrlParameter.Optional }
            );

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}