using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = 1;
            customer1.name = "Yusif";
            customer1.surname = "Mamedov";
            customer1.age = 10;

            Customer customer2 = new Customer();
            customer2.id = 2;
            customer2.name = "Zahid";
            customer2.surname = "Mamedov";
            customer2.age = 21;

            Customer customer3 = new Customer();
            customer3.id = 3;
            customer3.name ="Cefer";
            customer3.surname = "Babayev";
            customer3.age = 25;

            Customer customer4 = new Customer();
            customer4.id = 4;
            customer4.name = "Minaye";
            customer4.surname = "Ehmedova";
            customer4.age = 19;

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4};

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomAdd(customer4);
           

            Console.WriteLine("-------------------------");
            customerManager.CustomList(customers);
            Console.WriteLine("-------------------------");
            customerManager.Delete(customer3);

        }
    }
}
