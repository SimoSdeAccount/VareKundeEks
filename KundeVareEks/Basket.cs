using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundeVareEks
{
    class Basket
    {
        private Customer customer;
        private List<Product> product = new List<Product>();
        public Customer GetSetCustomer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }
        public List<Product> GetProducts 
        {
            get
            {
                return product;
            }
        }
        public Product SetProducts
        {
            set
            {
                product.Add(value);
            }
        }
    }
}
