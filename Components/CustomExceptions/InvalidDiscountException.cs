﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.CustomExceptions
{
    public class InvalidDiscountException : Exception
    {
        public InvalidDiscountException(string message) : base(message) { }
    }
}
