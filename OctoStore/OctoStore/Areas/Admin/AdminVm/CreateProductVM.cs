﻿using OctoStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OctoStore.Areas.Admin.AdminVm
{
    public class CreateProductVM
    {
        public Product Products { get; set; }

        public List<Category> Categories { get; set; }
    }
}
