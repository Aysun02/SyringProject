﻿using Core.Entities.Base;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OurVision :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Photo { get; set; }
    }
}