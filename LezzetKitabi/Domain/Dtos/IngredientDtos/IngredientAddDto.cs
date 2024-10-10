﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LezzetKitabi.Domain.Dtos.IngredientDtos
{
    public class IngredientAddDto
    {
        public string IngredientName { get; set; }
        public string TotalQuantity { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
    }
}