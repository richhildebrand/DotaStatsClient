using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.Helpers
{
    public class AffiliationHelper
    {
        public IEnumerable<Player> GetDirePlayers(IEnumerable<Player> players)
        {
            return players.Where(p => p.player_slot >= 5);
        }

        public IEnumerable<Player> GetRadiantPlayers(IEnumerable<Player> players)
        {
            return players.Where(p => p.player_slot < 5);
        }

        public bool PlayerWins(Player player, bool radiantWins)
        {
            return IsRadiant(player) && radiantWins || !IsRadiant(player) && !radiantWins;
        }

        public bool IsRadiant(Player player)
        {
            return player.player_slot < 5;
        }
    }
}