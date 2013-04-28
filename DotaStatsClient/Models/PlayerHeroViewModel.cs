using System;
using System.Linq;

namespace DotaSite.Models
{
    public class PlayerHeroViewModel
    {
        public String Name { get; set; }
        public int Wins { get; set; }
        public int GamesPlayed { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int GoldPerMinute { get; set; }
        public int XpPerMinute { get; set; }


        public PlayerHeroViewModel(string name)
        {
            Name = name;
        }

        public double GetWinPercent()
        { 
            return Math.Round((double)Wins / GamesPlayed * 100, 2);
        }


        public double GetKdaPercent()
        {
            double kaSum = Kills + Assists;
            return Deaths > 0 ? Math.Round(kaSum / Deaths, 2) : kaSum;
        }

        public double GetAverageGoldPerMinute()
        {
            return Math.Round((double)GoldPerMinute / GamesPlayed, 0);    
        }

        public double GetAverageXpPerMinute()
        {
            return Math.Round((double)XpPerMinute / GamesPlayed, 0);
        }
    }
}