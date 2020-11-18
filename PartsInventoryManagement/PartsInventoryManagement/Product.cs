using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    class Product
    {
        // fields for Product class
        // Associated parts binding list 
        public int productID;
        public string name;
        public decimal price;
        public int inStock;
        public int min;
        public int max;

        // properties for Product class
        public int ProductID
        {
            get;
        }
        public string Name
        {
            get;
        }
        public decimal Price
        {
            get;
        }
        public int InStock
        {
            get;
        }
        public int Min
        {
            get;
        }
        public int Max
        {
            get;
        }

        // methods for Products class
        public static void addAssociatepart(Part)
        {

        }

        public static bool removeAssociatedPart(int)
        {

        }

        public static Part lookupAssociatedpart(int)
        {

        }
    }
}
