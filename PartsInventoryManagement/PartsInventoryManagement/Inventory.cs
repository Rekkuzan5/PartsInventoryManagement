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
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();


        public static void PopulateList()
        {
            // add mach ids and comp names
            Part dummyPart1A = new InHouse(1, "Part 1.Abigail", 15.00m, 15, 30, 10, 9001);
            Part dummyPart1B = new InHouse(2, "Part 1.Bobby", 10.00m, 12, 25, 10, 9001);
            Part dummyPart2A = new InHouse(3, "Part 2.Anastasia", 12, 10, 25, 10, 9002);
            Part dummyPart2B = new InHouse(4, "Part 2.Brosnan", 15m, 5, 25, 10, 9002);
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

            //

            Product dummyProd1 = new Product(1, "Product 1", 10m, 12, 20, 5);
            Product dummyProd2 = new Product(2, "Product 2", 10m, 8, 25, 5);
            Product dummyProd3 = new Product(3, "Product 3", 10m, 5, 25, 5);
            Product dummyProd4 = new Product(4, "Product 4", 10m, 3, 25, 5);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);

        }
        //// methods for Inventory class
        //public static void addProduct(Product)
        //{

        //}

        //public static bool removeProduct(int)
        //{

        //}

        //public static Product lookupProduct(int )
        //{

        //}

        //public static void updateProduct(int, Product)
        //{

        //}

        public static void AddPart(Part part)
        {
            AllParts.Add(part);   
        }

        public static bool DeletePart(Part part)
        {
                AllParts.Remove(part);
                return true;
        }

        public static Part LookupPart(int partID)
        {
            //for (int i = 0; i < AllParts.Count; i++)
            //{
            //    if (AllParts[i].PartID.Equals(i))
            //    {
            //        return AllParts[i];
            //    }
            //}
            //return null;

            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;

            // Like this better

            //foreach (Part part in AllParts)
            //{
            //    if (part.PartID == partID)
            //    {
            //        return part;
            //    }
            //}
            //Part noPart = null;
            //return noPart;
        }

        public static void UpdatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(InHouse))
                {
                    InHouse newInhouse = (InHouse)AllParts[i];
                    if (newInhouse.PartID == partID)
                    {
                        newInhouse.PartID = part.PartID;
                        newInhouse.Name = part.Name;
                        newInhouse.Price = part.Price;
                        newInhouse.InStock = part.InStock;
                        newInhouse.Min = part.Min;
                        newInhouse.Max = part.Max;
                    }
                }
                else if (AllParts[i].GetType() == typeof(Outsourced))
                {
                    Outsourced newOutsource = (Outsourced)AllParts[i];
                    if (newOutsource.PartID == partID)
                    {
                        newOutsource.PartID = part.PartID;
                        newOutsource.Name = part.Name;
                        newOutsource.Price = part.Price;
                        newOutsource.InStock = part.InStock;
                        newOutsource.Min = part.Min;
                        newOutsource.Max = part.Max;
                    }
                }
            }
        }
    }
}
