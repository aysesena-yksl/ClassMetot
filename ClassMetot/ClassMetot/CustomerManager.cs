using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.name + " " + customer.lastname + " " + customer.AccountNumber + "Müşteri Eklendi");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.name + " " + customer.lastname + " " + customer.AccountNumber + "Müşteri Silindi");
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + ": " + customer.name + ": " + customer.lastname + ": " + customer.AccountNumber + ": ");


            }
        }
    }
}
