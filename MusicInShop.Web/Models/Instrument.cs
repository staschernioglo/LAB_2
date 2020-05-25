using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicInShop.Web.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}