using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace shipment
{
    class Package
    {

        public delegate void PackageHandler(Package item);
        public event PackageHandler packageProcess;


        private string pkgName;
        private string id;
        private int pcs;
        private double price;

        private Timer timer;

        public Package(string name,string id, int pcs, double price, double arrivalTime)
        {
            this.pkgName = name;
            this.id = id;
            this.pcs = pcs;
            this.price = price;
        }

        public 

      

       


    }
}
