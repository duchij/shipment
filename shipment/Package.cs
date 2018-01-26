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

        public delegate void PackageHandler(string message);

        public event PackageHandler PackageArrived;

        public string pkgName
        {
            get; set;
        }

        public string trackId
        {
            get
            {
                return trackId;
            }
            set
            {
                // Console.WriteLine("tue");
                trackId = value;
                
                
            }
        }

        public string mail
        {
            get;set;
        }

        private int pcs;
        private double price;
        public string id
        {
            set;get;
        }

      //  private Timer timer;

        public Package(string name,int pcs, double price,string id)
        {
            this.pkgName = name;
            this.pcs = pcs;
            this.price = price;

            this.id = id;

            PackageArrived += packageArrived;
        }

        public void subPcs()
        {
            this.pcs--;
        }

        protected void packageArrived(string message)
        {

            onPackageArrived(string.Format("Prisiel tovar :{0},{1}", this.pkgName, this.trackId));
            // item.arrived += onPackageArrived;
        }

        protected void onPackageArrived(string message)
        {
            if (PackageArrived != null)
            {
                PackageArrived(message);
            }
        }





    }
}
