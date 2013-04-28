using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.Helpers
{
    public class HeroHelper
    {
        private AffiliationHelper _affiliationHelper;

        public HeroHelper()
        {
            _affiliationHelper = new AffiliationHelper();
        }

        public List<PlayerHeroViewModel> GetHeroListForOnePlayer(List<MatchDetail> matches, List<PlayerHeroViewModel> heroes)
        {
            foreach (var match in matches)
            {
                var player = match.players.FirstOrDefault();
                var hero = heroes.Where(h => h.Name == player.hero.localized_name).FirstOrDefault();
                if (hero != null)
                {
                    ModifyHeroStatsBasedOnGame(match, player, hero);
                }
                else { 
                    hero = new PlayerHeroViewModel(player.hero.localized_name);
                    ModifyHeroStatsBasedOnGame(match, player, hero);           
                    heroes.Add(hero);
                }
            }

            return heroes;
        }

        private void ModifyHeroStatsBasedOnGame(MatchDetail match, Player player, PlayerHeroViewModel hero)
        {
            hero.GamesPlayed += 1;
            hero.Kills += player.kills;
            hero.Deaths += player.deaths;
            hero.Assists += player.assists;
            hero.GoldPerMinute += player.gold_per_min;
            hero.XpPerMinute += player.xp_per_min;
            if (_affiliationHelper.PlayerWins(player, match.radiant_win)) { hero.Wins += 1; }
        }

        public List<PlayerHeroViewModel> GetHeroListForPlayerN(List<MatchDetail> matches, List<PlayerHeroViewModel> heroes, int playerIndex)
        {
            var affiliationHelper = new AffiliationHelper();

            foreach (var match in matches)
            {
                try
                {
                    var player = match.players[playerIndex];
                    var hero = heroes.Where(h => h.Name == player.hero.localized_name).FirstOrDefault();
                    if (hero != null)
                    {
                        ModifyHeroStatsBasedOnGame(match, player, hero);

                    }
                    else
                    {
                        hero = new PlayerHeroViewModel(player.hero.localized_name);
                        ModifyHeroStatsBasedOnGame(match, player, hero);
                        heroes.Add(hero);
                    }
                }
                catch {}
            }
            return heroes;
        }
    }
}