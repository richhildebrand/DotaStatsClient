using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.Helpers
{
    public class HeroHelper
    {
        public List<PlayerHeroViewModel> GetHeroListForOnePlayer(List<MatchDetail> matches, List<PlayerHeroViewModel> heroes)
        {
            var affiliationHelper = new AffiliationHelper();

            foreach (var match in matches)
            {
                var player = match.players.FirstOrDefault();
                var hero = heroes.Where(h => h.Name == player.hero_name).FirstOrDefault();
                if (hero != null)
                {
                    hero.GamesPlayed += 1;
                    hero.Kills += player.kills;
                    hero.Deaths += player.deaths;
                    hero.Assists += player.assists;
                    hero.GoldPerMinute += player.gold_per_min;
                    hero.XpPerMinute += player.xp_per_min;
                    if (affiliationHelper.PlayerWins(player, match.radiant_win)) { hero.Wins += 1; }
                    
                }
                else { heroes.Add(new PlayerHeroViewModel(player.hero.localized_name)); }
            }

            return heroes;
        }

        public List<PlayerHeroViewModel> GetHeroListForPlayerN(List<MatchDetail> matches, List<PlayerHeroViewModel> heroes, int playerIndex)
        {
            var affiliationHelper = new AffiliationHelper();

            foreach (var match in matches)
            {
                try
                {
                    var player = match.players[playerIndex];
                    var hero = heroes.Where(h => h.Name == player.hero_name).FirstOrDefault();
                    if (hero != null)
                    {
                        hero.GamesPlayed += 1;
                        hero.Kills += player.kills;
                        hero.Deaths += player.deaths;
                        hero.Assists += player.assists;
                        hero.GoldPerMinute += player.gold_per_min;
                        hero.XpPerMinute += player.xp_per_min;
                        if (affiliationHelper.PlayerWins(player, match.radiant_win)) { hero.Wins += 1; }

                    }
                    else { heroes.Add(new PlayerHeroViewModel(player.hero_name)); }
                }
                catch {}
            }
            return heroes;
        }
    }
}