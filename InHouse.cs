using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankInventorySystem
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        public Inhouse(int partID, string name, int inStock, decimal price, int min, int max, int machineID)
            : base(partID, name, inStock, price, min, max)
        {
            MachineID = machineID;
        }
    }
}
