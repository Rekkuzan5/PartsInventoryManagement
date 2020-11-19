using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    abstract class Part
    {

        // properties for abstract Part class
        public int PartID { get; }

        public string Name { get; }

        public decimal Price { get; }

        public int InStock { get; }
 
        public int Min { get; }

        public int Max { get; }
  
        // 6-parameter constructor
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        // return string for Part object using properties
        public override string ToString() => $"{PartID} {Name} {Price} {InStock} {Min} {Max}";
    }
}
