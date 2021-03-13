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
            Part examplePart1 = new InHouse(1, "Spark Plug", 4.99m, 76, 16, 100, 9001);
            Part examplePart2 = new InHouse(2, "Air Filter", 18.99m, 12, 10, 30, 9002);
            Part examplePart3 = new InHouse(3, "Oil Filter", 6.99m, 39, 10, 50, 9003);
            Part examplePart4 = new InHouse(4, "Plug Wire", 3.99m, 41, 16, 50, 9004);
            Part examplePart5 = new Outsourced(7, "Intake Manifold", 249.99m, 11, 3, 20, "Edelbrock");
            Part examplePart6 = new Outsourced(8, "Carburetor", 399.99m, 5, 3, 20, "Holley");

            AllParts.Add(examplePart1);
            AllParts.Add(examplePart2);
            AllParts.Add(examplePart3);
            AllParts.Add(examplePart4);
            AllParts.Add(examplePart5);
            AllParts.Add(examplePart6);

            Product ExampleProduct1 = new Product(1, "8 Spark Plug Wire Kit", 30.99m, 12, 5, 30);
            Product ExampleProduct2 = new Product(2, "6 Spark Plug Wire Kit", 23.99m, 8, 5, 30);
            Product ExampleProduct3 = new Product(3, "4 Spark Plug Wire Kit", 15.99m, 5, 5, 30);
            Product ExampleProduct4 = new Product(4, "4 Cylinder Tune Up Kit", 35.99m, 15, 5, 30);

            // Add parts to products
            for (int i = 0; i < 8; i++)
            {
                ExampleProduct1.AddAssociatedPart(examplePart1);
            }
            for (int i = 0; i < 6; i++)
            {
                ExampleProduct2.AddAssociatedPart(examplePart1);
            }
            for (int i = 0; i < 4; i++)
            {
                ExampleProduct3.AddAssociatedPart(examplePart1);
            }

            ExampleProduct4.AddAssociatedPart(examplePart1);
            ExampleProduct4.AddAssociatedPart(examplePart1);
            ExampleProduct4.AddAssociatedPart(examplePart1);
            ExampleProduct4.AddAssociatedPart(examplePart1);
            ExampleProduct4.AddAssociatedPart(examplePart2);
            ExampleProduct4.AddAssociatedPart(examplePart3);

            Products.Add(ExampleProduct1);
            Products.Add(ExampleProduct2);
            Products.Add(ExampleProduct3);
            Products.Add(ExampleProduct4);

        }

        // Products Methods //

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
