using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaSite.Models;

namespace DotaSite.Helpers
{
    public class ItemHelper
    {
        public string TryGetItemId(int itemSlot, Player matchPlayer)
        {
            try
            {
                return matchPlayer.items.FirstOrDefault(i => i.ItemSlot == itemSlot).Id.ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}