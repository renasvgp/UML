using System;
namespace UML
{
    public class Store
    {
        public void start()
        {

            Pizza p1 = new Pizza();
            Pizza p2 = new Pizza();
            Pizza p3 = new Pizza();

            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();

            Order o1 = new Order();
            Order o2 = new Order();
            Order o3 = new Order();

            Console.WriteLine(o1);
        }
    }
}
