using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerTest
{
    public class Product
    {
        public int ProductId { get => ProductId; set => ProductId = value; }
        public string ProductName { get => ProductName; set => ProductName = value; }
        public double Price { get => Price; set => Price = value; }
        public CategoryType Category { get => Category; set => Category = value; }
        public string Description { get => Description; set => Description = value; }

        public override string ToString()
        {
            return "{"+ProductId+", "+ProductName+", "+Price+", "+Category+", "+Description+"}";
        }
    }
}
