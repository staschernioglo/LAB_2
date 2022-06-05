﻿using MusicInShop.BusinessLogic.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicInShop.Web.Models
{
    public class OrganizationProjectModel : NavbarModel
    {
        public IEnumerable<ProjectDTO> Projects { get; set; }
    }
}