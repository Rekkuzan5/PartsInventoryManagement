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
            Part dummyPart1A = new InHouse(1, "Part 1.Abigail", 15.00m, 15, 10, 30, 9001);
            Part dummyPart1B = new InHouse(2, "Part 1.Bobby", 10.00m, 12, 10, 30, 9001);
            Part dummyPart2A = new InHouse(3, "Part 2.Anastasia", 12, 10, 10, 30, 9002);
            Part dummyPart2B = new InHouse(4, "Part 2.Brosnan", 15m, 5, 10, 30, 9002);
            Part dummyPart3A = new Outsourced(5, "Part 3.A", 15m, 15, 10, 30, "ShopCorp");
            Part dummyPart3B = new Outsourced(6, "Part 3.B", 10m, 12, 10, 30, "ShopCorp");
            Part dummyPart4A = new Outsourced(7, "Part 4.A", 12m, 10, 10, 30, "PPI, LLC");
            Part dummyPart4B = new Outsourced(8, "Part 4.B", 15m, 5, 10, 30, "PPI, LLC");

            AllParts.Add(dummyPart1A);
            AllParts.Add(dummyPart1B);
            AllParts.Add(dummyPart2A);
            AllParts.Add(dummyPart2B);
            AllParts.Add(dummyPart3A);
            AllParts.Add(dummyPart3B);
            AllParts.Add(dummyPart4A);
            AllParts.Add(dummyPart4B);

            //

            Product dummyProd1 = new Product(1, "Product 1", 10m, 12, 5, 30);
            Product dummyProd2 = new Product(2, "Product 2", 10m, 8, 5, 30);
            Product dummyProd3 = new Product(3, "Product 3", 10m, 5, 5, 30);
            Product dummyProd4 = new Product(4, "Product 4", 10m, 3, 5, 30);

            Products.Add(dummyProd1);
            Products.Add(dummyProd2);
            Products.Add(dummyProd3);
            Products.Add(dummyProd4);

        }

        // ** Products Methods ** //

        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        public static bool RemoveProduct(int productID)
        {
            bool found = false;
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    Products.Remove(prod);
                    found = true;
                    return found;
                }
            }
            return found;
        }

        // Look for product within Product Binding List
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static int AssignProductID()
        {
            int productID = 0;

            foreach (Product product in Products)
            {
                if (product.ProductID > productID)
                {
                    productID = product.ProductID;
                }
            }
            return productID + 1;
        }

        public static void UpdateProduct(int productID, Product moddedProduct)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    prod.Name = moddedProduct.Name;
                    prod.Price = moddedProduct.Price;
                    prod.InStock = moddedProduct.InStock;
                    prod.Min = moddedProduct.Min;
                    prod.Max = moddedProduct.Max;
                    return;
                }
            }

        }

        // ** End of Products Methods ** //

        // ** Parts Methods ** //

        public static void AddPart(Part part)
        {
            AllParts.Add(part);   
        }

        public static bool DeletePart(int partID)
        {
            bool found = false;
            foreach (Part part in AllParts)
            {
                if (partID == part.PartID)
                {
                    AllParts.Remove(part);
                    found = true;
                    return found;
                }   
            }
            return found;
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
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

        public static int AssignPartID()
        {
            int partID = 0;

            foreach (Part part in AllParts)
            {
                if (part.PartID > partID)
                {
                    partID = part.PartID;
                }
            }
            return partID + 1;
        }
          //** End of Parts Methods ** //
    }
}
