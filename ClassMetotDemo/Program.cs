using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101101,
                Balance = 500000,
                Name = "Enes",
                Surname = "Yılmaz"
            };

            Customer customer2 = new Customer()
            {
                Id = 101011,
                Balance = 1000000,
                Name = "Haktan",
                Surname = "Çınar"
            };


            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerList(customer1);




            Console.ReadLine();
        }
    }
}
