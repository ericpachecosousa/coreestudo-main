using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIModelo.Domain.Entitys
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool IsDisponivel { get; set; }

    }
}
