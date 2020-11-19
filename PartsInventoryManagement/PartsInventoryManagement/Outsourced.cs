using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    class Outsourced : Part
    {
        // field for Inhouse class
        public string companyName;

        // 7-parameter constructor
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) 
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }

        // property for Inhouse class
        public string CompanyName
        {
            get;
        }
    }
}

