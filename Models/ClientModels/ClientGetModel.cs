﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ClientModels
{
    public class ClientGetModel
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Names { get; set; }
        public string Lastnames { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}