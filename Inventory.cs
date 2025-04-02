using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FrankInventorySystem
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public Part LookupPart(int partID)
        {
            return AllParts.FirstOrDefault(p => p.PartID == partID);
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public void UpdatePart(int partID, Part part)
        {
            var index = AllParts.IndexOf(AllParts.FirstOrDefault(p => p.PartID == partID));
            AllParts[index] = part;
        }

        public bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        public Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public void AddProduct(Product product) 
        {
            Products.Add(product);
        }

        public void UpdateProduct(int productID, Product product)
        {
            var index = Products.IndexOf(Products.FirstOrDefault(p => p.ProductID == productID));
            Products[index] = product;
        }

        public bool RemoveProduct(int productID) 
        {
            var product = Products.FirstOrDefault(p => p.ProductID == productID);
            return product != null && Products.Remove(product);
        }
    }
}
