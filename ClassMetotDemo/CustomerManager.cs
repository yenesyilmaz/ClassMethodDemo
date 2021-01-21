using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
        Console.WriteLine("Sayın {0} {1} {2} ID numaralı hesabınız eklenmiştir",customer.Name,customer.Surname,customer.Id);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Sayın {0} {1} {2} ID numaralı hesabınız silinmiştir", customer.Name, customer.Surname, customer.Id);
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine("ID: {0}\nAdı:{1}\nSoyadı:{2}\nBakiye:{3}\n", customer.Id, customer.Name, customer.Surname, customer.Balance);
        }

    }
}
