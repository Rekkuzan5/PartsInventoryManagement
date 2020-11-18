using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    abstract class Part
    {

        // fields for abstract Part class
        public int partID;
        public string name;
        public decimal price;
        public int inStock;
        public int min;
        public int max;

        // properties for abstract Part class
        public int PartID
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

    }
}
