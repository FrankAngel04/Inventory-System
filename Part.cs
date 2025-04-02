using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankInventorySystem
{
    public abstract class Part
    {
        [DisplayName("Part ID")]
        public int PartID { get; set; }

        [DisplayName("Part Name")]
        public string Name { get; set; }

        [DisplayName("Inventory")]
        public int InStock { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Browsable(false)]
        public int Min { get; set; }

        [Browsable(false)]
        public int Max { get; set; }

        protected Part(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
