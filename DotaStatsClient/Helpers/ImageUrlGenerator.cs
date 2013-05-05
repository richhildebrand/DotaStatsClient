using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaSite.Helpers
{
    public class ImageUrlGenerator
    {
        public string GetHeroImageUrl(string heroName) {
            string imageUrlStart = "https://raw.github.com/richhildebrand/DotaWebApi/master/DotaStatsWebApi/DotaStatsWebApi/Content/HeroPortraits/";
            string imageUrlEnd = "_full.png";

            string imageUrlMiddle = heroName.Replace(' ', '_');

            return imageUrlStart + imageUrlMiddle + imageUrlEnd;
        }

    }
}