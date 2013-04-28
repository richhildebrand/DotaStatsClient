using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.Helpers
{
    public class PlayerInformationHelper
    {
        public string GetPlayerName(Player player)
        {
            if (player.playerInformation != null)
            {
                return player.playerInformation.personaname;
            }
            else
            {
                return player.account_id;
            }
        }

        public string GetPlayerDetailsLink(Player player)
        {
            if (player.playerInformation != null)
                return player.account_id;
            else
                return "";
        }
    }
}