using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomAdd(Customer customer)
        {
            Console.WriteLine("Added new customer");
            Console.WriteLine("Customer's Id : "+customer.id+",Customer's name : "+customer.name+",Cusromer's surname : "+customer.surname+",Customer's age : "+customer.age);
        }
        public void CustomList(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer's Id : " + customer.id);
                Console.WriteLine("Customer's name : " + customer.name);
                Console.WriteLine("Cusromer's surname : " + customer.surname);
                Console.WriteLine("Customer's age : " + customer.age);
                Console.WriteLine("*************************************");
            }
          
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("DELETED");
            Console.WriteLine("Customer's Id : " + customer.id + ",Customer's name : " + customer.name + ",Cusromer's surname : " + customer.surname + ",Customer's age : " + customer.age);
        }
    }
}
