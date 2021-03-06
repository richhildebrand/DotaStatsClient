﻿using System;
using System.Linq;
using System.Net;
using System.Text;

namespace DotaSite.ApiAccessor
{
    public class DotaWebApi : WebClient
    {
        public string GetClanDetails(string clanId)
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/clans/getclandetails?clanId=";
            var fullUrl = this.BaseAddress + clanId;

            return Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

        public string GetClans()
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/clans/getclans";
            var fullUrl = this.BaseAddress;

            return Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

        public string GetPlayers()
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/players/getplayers";
            var fullUrl = this.BaseAddress;

            return Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

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

        //search features
        public string SearchMatches(string matchInfo)
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/matches/searchMatches?matchInfo=";
            var fullUrl = this.BaseAddress + matchInfo;
            return Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

        public string SearchClans(string clanInfo)
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/clans/searchClans?clanInfo=";
            var fullUrl = this.BaseAddress + clanInfo;
            return Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

        public string SearchPlayers(string playerInfo)
        {
            this.BaseAddress = "http://dotawebapi.apphb.com/api/players/searchPlayers?playerInfo=";
            var fullUrl = this.BaseAddress + playerInfo;
            return Encoding.Default.GetString(this.DownloadData(fullUrl));
        }

    }
}