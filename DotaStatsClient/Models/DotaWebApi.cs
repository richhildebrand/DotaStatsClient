using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace DotaSite.Models
{
    public class DotaWebApi : WebClient
    {
        public string GetPlayerOverview(string playerId)
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/players/getmatchhistory?steamid32=";
            var fullUrl = this.BaseAddress + playerId;

            return System.Text.Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

        public string GetMatchDetails(string matchId)
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/matches/GetMatchDetails?matchId=";
            var fullUrl = this.BaseAddress + matchId;

            return System.Text.Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

        public string GetRecentMatches()
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/matches/GetRecentMatches";

            return System.Text.Encoding.Default.GetString(this.DownloadData(this.BaseAddress));
        }

		public string GetHeroes()
		{
			this.BaseAddress = "http://dotawebapi.apphb.com/api/heroes/GetAllHeroes";

			return System.Text.Encoding.Default.GetString(this.DownloadData(this.BaseAddress));
		}

		public string GetAllMatches()
		{
			this.BaseAddress = "http://dotawebapi.apphb.com/api/matches/GetAllMatches";

			return System.Text.Encoding.Default.GetString(this.DownloadData(this.BaseAddress));
		}
    }
}