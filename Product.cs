using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankInventorySystem
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        [DisplayName("Product ID")]
        public int ProductID { get; set; }
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

        public Product(int productId, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public Part LookupAssociatedPart(int partID) 
        {
            return AssociatedParts.FirstOrDefault(p => p.PartID == partID);
        }

        public void AddAssociatedPart(Part part) 
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID) 
        {
            var part = AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            return AssociatedParts.Remove(part);
        } 
    }
}
