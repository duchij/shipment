using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipment
{

    class Shipment
    {

       

        public ArrayList shipCollection;

        public Shipment()
        {
            this.shipCollection = new ArrayList();
        }

        public void addPkg(Package item)
        {
            this.shipCollection.Add(item);
        }

        public Package GetPackageForClient(string id)
        {
            foreach (Package item in this.shipCollection)
            {
                if (item.id == id)
                {
                    item.subPcs();
                    return item;
                }
            }
            return null;
        }


       


    }
}
