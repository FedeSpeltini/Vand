﻿using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class Creator
    {
        public abstract ICopia FactoryMethod();
    }
}

