using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipment
{
    class Package :Shipment 
    {

        public delegate void PackageHandler(Package item);
        public event PackageHandler packageProcess;


        private string name;
        private string id;
        private int pcs;
        private double price;

        public Package(string name,string id, int pcs, double price)
        {
            this.name = name;
            this.id = id;
            this.pcs = pcs;
            this.price = price;

        }

        public void packageArrived(Package pkg)
        {
            this.
        }


    }
}
