using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.ViewModels
{
    public class SearchViewModel
    {
        public List<Clan> clans { get; set; }
        public List<Player> players { get; set; }
    }
}