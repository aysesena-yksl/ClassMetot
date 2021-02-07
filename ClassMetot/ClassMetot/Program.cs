using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, name = "Ayşe Sena", lastname = "Yüksel", AccountNumber = 987654 };
            Customer customer2 = new Customer() { Id = 2, name = "İremnur", lastname = "Yüksel", AccountNumber = 98765524 };
            Customer customer3 = new Customer() { Id = 3, name = "Talha ", lastname = "Yüksel", AccountNumber = 127654 };


            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("*****Müşteriler Listelendi*****");
            Customer[] customers = new Customer[]
            { customer1, customer2,customer3};
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + ": " + customer.name + ": " + customer.lastname + ": " + customer.AccountNumber + ": ");
            }

            Console.WriteLine("*****Eklenen Müşteriler:******");
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);

            Console.WriteLine("*******Silinen Müşteriler:******");
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerDelete(customer3);

        }
    }
}
