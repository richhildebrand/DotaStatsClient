using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.Helpers
{
    public class AbilityHelper
    {
        public string TryGetAbility(int level, List<MatchPlayerAbility> matchPlayerAbilities)
        {
            try
            {
                return matchPlayerAbilities.FirstOrDefault(mpa => mpa.level == level)
                                           .ability.ToString();
            }
            catch { return "---"; }
        }
    }
}