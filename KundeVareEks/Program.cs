using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeVareEks
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer kaj = new Customer();
            kaj.name = "Kaj";
            kaj.age = "42";
            kaj.address = "Kajvej 42m Kajby";

            ComputerProduct mac = new ComputerProduct();
            mac.antal = 2;
            mac.brand = "mac";
            mac.price = 7000;
            mac.name = "air";
            mac.ram = "MemoryV01";
            mac.cpu = "Intel";

            ComputerProduct pc = new ComputerProduct();
            pc.antal = 1;
            pc.brand = "HP";
            pc.price = 3000;
            pc.name = "HP MegaKlods 2";
            pc.ram = "MemoryV01";
            pc.cpu = "Intel";

            Basket basket1 = new Basket();
            basket1.GetSetCustomer = kaj;
            basket1.GetProducts.Add(new ComputerProduct
            {
            antal = 1,
            brand = "HP",
            price = 3000,
            name = "HP MegaKlods 2",
            ram = "MemoryV01",
            cpu = "Intel",
            });
            basket1.GetProducts.Add(mac);
            basket1.GetProducts.Add(pc);

            Faktura fak01 = new Faktura();
            fak01.printFaktura(basket1);
            Console.ReadLine();
        }
    }
}
