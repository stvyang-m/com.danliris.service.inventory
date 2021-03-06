﻿using Com.Danliris.Service.Inventory.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Inventory.Lib.ViewModels
{
    public class UnitViewModel : BasicViewModel
    {
        public string _id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
}
