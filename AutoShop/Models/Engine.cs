﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoShop.Models
{
    public class Engine
    {
        public int Id { get; set; }
        public int Power { get; set; }
        public int? Volume { get; set; }

        public int? EngineTypeId { get; set; }
        public virtual EngineType EngineType { get; set; }

        public ICollection<Car> Cars { get; set; }

        public Engine()
        {
            Cars = new List<Car>();
        }
    }
}