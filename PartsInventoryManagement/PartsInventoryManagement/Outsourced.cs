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

        // property for Inhouse class
        public string CompanyName
        {
            get;
        }
    }
}

