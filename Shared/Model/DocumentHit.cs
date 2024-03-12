﻿using System;
using System.Collections.Generic;
using Shared.Model;

namespace Core.Model
{
    public class DocumentHit
    { 

        public BEDocument Document { get; set; }

        public int NoOfHits { get; set; }

        public List<string> Missing { get; set; }
    }
}
