using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaSite.Models
{
    public class MatchPlayerAbility
    {
        public long match_id { get; set; }
        public string account_id { get; set; }
        public int player_slot { get; set; }
        public int ability { get; set; }
        public int level { get; set; }
        public int time { get; set; }
    }
}