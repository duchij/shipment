using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Net.Mail;

namespace shipment
{
    class Notification
    {

        public Notification()
        {

        }

        public void sendInfo(Package item, string message)
        {
            Console.WriteLine(string.Format("Prisiel Tovar {0} s id: {1} Sprava pre klienta {2}",item.pkgName,item.trackId,message));
        }

        public void sendMail(Package item, string message)
        {


            string msg = string.Format("{0} Vam po zaplateni posielame tovar {1}", message, item.pkgName);

          //  if cb


            System.Console.Write("password: ");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
            }


            Console.WriteLine();

            SmtpClient mailClient = new SmtpClient();

            mailClient.Port = 587;
            mailClient.Host = "smtp.mail.google";
            mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            mailClient.UseDefaultCredentials = false;
           // mailClient.Port = 
            //mailClient.
        }
    }
}
