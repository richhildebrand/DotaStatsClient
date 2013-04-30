using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaSite.Helpers
{
    public class CssClassHelper
    {

        private int _rowCount;

        public CssClassHelper()
        {
            _rowCount = 0;
        }

        public string GetRowColorClass()
        {
            _rowCount++;
            return _rowCount % 2 != 0 ? "even-row" : "";
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