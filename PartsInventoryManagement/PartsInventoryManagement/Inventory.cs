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


        public static void PopulateList()
        {
            // add mach ids and comp names
            Part dummyPart1A = new InHouse(1, "Part 1.A", 15.00m, 15, 30, 10, 9001);
            Part dummyPart1B = new InHouse(2, "Part 1.B", 10.00m, 12, 25, 10, 9001);
            Part dummyPart2A = new InHouse(3, "Part 2.A", 12, 10, 25, 10, 9002);
            Part dummyPart2B = new InHouse(4, "Part 2.B", 15m, 5, 25, 10, 9002);
            Part dummyPart3A = new Outsourced(5, "Part 3.A", 15m, 15, 30, 10, "ShopCorp");
            Part dummyPart3B = new Outsourced(6, "Part 3.B", 10m, 12, 25, 10, "ShopCorp");
            Part dummyPart4A = new Outsourced(7, "Part 4.A", 12m, 10, 25, 10, "PPI, LLC");
            Part dummyPart4B = new Outsourced(8, "Part 4.B", 15m, 5, 25, 10, "PPI, LLC");

            AllParts.Add(dummyPart1A);
            AllParts.Add(dummyPart1B);
            AllParts.Add(dummyPart2A);
            AllParts.Add(dummyPart2B);
            AllParts.Add(dummyPart3A);
            AllParts.Add(dummyPart3B);
            AllParts.Add(dummyPart4A);
            AllParts.Add(dummyPart4B);
        }
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
