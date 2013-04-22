using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaSite.Helpers
{
    public class ImageUrlGenerator
    {
        public string GetHeroImageUrl(string heroName) {
            string imageUrlStart = "http://dotawebapi.apphb.com/content/HeroPortraits/";
            string imageUrlEnd = "_full.png";

            string imageUrlMiddle = heroName.Replace(' ', '_');

            return imageUrlStart + imageUrlMiddle + imageUrlEnd;
        }

    }
}