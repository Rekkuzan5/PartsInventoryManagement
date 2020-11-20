using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInventoryManagement
{
    class InHouse : Part
    {
        // field for Inhouse class
        private int machineID;

        // 7-parameter constructor
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) 
            : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }

        // property for Inhouse class
        public int MachineID
        {
            get
            {
                return machineID;
            }
            set
            {
                machineID = value;
            }
        }
    }
}
