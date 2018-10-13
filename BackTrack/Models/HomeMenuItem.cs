using System;
using System.Collections.Generic;
using System.Text;

namespace BackTrack.Models
{
    public enum MenuItemType
    {
        Settings,
        Home,
        About, 
        Browse
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
