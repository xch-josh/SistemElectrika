﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProviderModels
{
    public class ProviderEditModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Provider { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
    }
}
