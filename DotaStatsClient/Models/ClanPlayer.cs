using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaSite.Models
{
    public class ClanPlayer
    {
        public string AccountId { get; set; }
        public string ClanId { get; set; }

        public PlayerInformation player { get; set; }
    }
}