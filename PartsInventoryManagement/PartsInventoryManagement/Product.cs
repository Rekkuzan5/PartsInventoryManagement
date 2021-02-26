using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    public class Product
    {
        // fields for Product class
        public static BindingList<Part> AssociatedParts = new BindingList<Part>();

        //public int productID;
        //public string name;
        //public decimal price;
        //public int inStock;
        //public int min;
        //public int max;

        // properties for Product class
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // constructors for product object
        public Product() { }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
      

        // methods for Products class
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public static bool RemoveAssociatedPart(int partID)
        {
            bool checkSuccess = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    checkSuccess = true;
                    break;
                }
            }
            return checkSuccess;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
