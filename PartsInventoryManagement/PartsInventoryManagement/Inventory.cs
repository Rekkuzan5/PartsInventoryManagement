using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    class Inventory
    {
        // binding list for products and parts
        BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        //// methods for Inventory class
        //public static void addProduct(Product)
        //{

        //}

        //public static bool removeProduct(int)
        //{

        //}

        //public static Product lookupProduct(int)
        //{

        //}

        //public static void updateProduct(int, Product)
        //{

        //}

        public static void addPart(Part part)
        {

            //AllParts = new BindingList<Part>();
            AllParts.Add(part);
            
        }

        //public static bool deletePart(Part)
        //{

        //}

        //public static Part lookupPart(int)
        //{

        //}

        //public static void updatePart(int, Part)
        //{

        //}
    }
}
