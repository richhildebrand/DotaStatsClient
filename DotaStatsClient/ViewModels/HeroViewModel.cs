using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.ViewModels
{
	public class HeroViewModel
	{
		public List<Hero> heroes { get; set; }
		public List<MatchDetail> matches { get; set; }
	}
}