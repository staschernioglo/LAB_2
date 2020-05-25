using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicInShop.Web.Models
{
    public class InstrumentContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}