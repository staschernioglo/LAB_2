﻿using MusicInShop.Domain.Entities.User;
using System;
using System.Data.Entity;

namespace MusicInShop.BusinessLogic.Core
{
    internal class UserContext : DbContext
    {
        public UserContext() :
            base("name=eUseControl") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}