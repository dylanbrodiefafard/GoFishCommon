﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishCommon.Exceptions
{
    class HandLimitException : Exception
    {
        public HandLimitException(string message) : base(message)
        {
        }
    }
}
