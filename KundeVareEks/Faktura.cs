using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeVareEks
{
    class Faktura
    {
        public void printFaktura(Basket bas)
        {
            Console.WriteLine( bas.GetSetCustomer.name);
            Console.WriteLine( bas.GetSetCustomer.address);
            for (int i = 0; i < bas.GetProducts.Count; i++)
            {
                Console.Write(bas.GetProducts[i].antal + " ");
                Console.Write(bas.GetProducts[i].name + " ");
                Console.Write(bas.GetProducts[i].price + " ");
                Console.Write('\n');
            }
        }
    }
}
