﻿using System;
using System.Linq;

namespace DotaSite.Models
{
	public class Hero
	{
		public int id { get; set; }
		public string name { get; set; }
		public string localized_name { get; set; }
        public string image_url { get; set; }
	}
}