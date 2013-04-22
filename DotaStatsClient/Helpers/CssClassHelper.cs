using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaSite.Helpers
{
    public class CssClassHelper
    {
        public string GetEvenRowClass(int rowNumber)
        {
            return rowNumber % 2 != 0 ? "even-row" : "";
        }

        public string GetDireVictoryOrDefeatClass(bool raidiantVictory)
        {
            return raidiantVictory ? "defeat" : "victory";
        }

        public string GetRadiantVictoryOrDefeatClass(bool raidiantVictory)
        {
            return raidiantVictory ? "victory" : "defeat";
        }
    }
}