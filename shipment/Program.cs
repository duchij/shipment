using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipment ship = new Shipment();

            ship.addPkg(new Package("auto",15,2000,"1A"));
            ship.addPkg(new Package("bus", 30, 3000,"1B"));
            ship.addPkg(new Package("elekricka", 10, 5000, "1C"));

          //  Notification notif = new Notification();

            //ship.PackageArrived += new Shipment.PackageHandler(notif.sendInfo);
            //ship.PackageArrived += new Shipment.PackageHandler(notif.sendMail);


            Package pkgClient = ship.GetPackageForClient("1B");

           //if (pkgClient != null)
            //{
            pkgClient.trackId = "AA22BB";
                //ship.packageArrived(pkgClient, "Tovar prisiel prosim zaplate sumu");
            //}

            
            //ship.packageArrived(pkg,"Prisiel Tovar pre Vas");

            Console.WriteLine("Cakam na balik....");
            Console.ReadLine();


        }
    }
}
