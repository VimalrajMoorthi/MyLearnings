using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining a queue of integers
            Queue<int> queue = new Queue<int>();
            // add elements to the queue using Enqueue()
            queue.Enqueue(1);
            // printing the element at the front of the queue
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            // add elements to the queue using Enqueue()
            queue.Enqueue(2);
            // printing the element at the front of the queue
            Console.WriteLine("Top value in the queue is : {0}", queue.Peek());
            // add elements to the queue using Enqueue()
            queue.Enqueue(3);
            // printing the element at the front of the queue
            Console.WriteLine("Top value in the queue is : {0}", queue.Peek());

            while (queue.Count > 0)
            {
                // Remove elements from the queue using Dequeue()
                int queueItem = queue.Dequeue();
                // printing the element at the front of the queue
                Console.WriteLine("The front value {0} was removed from the queue", queueItem);
                // print the queue count
                Console.WriteLine("Current queue count is : {0}", queue.Count);
            }
            

            Queue<Order> ordersQueue = new Queue<Order>();
            foreach (Order order in ReceiveOrdersFromBranch1())
            {
                // add each order  to the queue
                ordersQueue.Enqueue(order);
            }

            foreach (Order order in ReceiveOrdersFromBranch2())
            {
                // add each order  to the queue
                ordersQueue.Enqueue(order);
            }

            // as long as the queue is not emepty
            while (ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue
                // and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                // process the order
                currentOrder.ProcessOrder();
            }

            Console.ReadLine();
        }

        // this method will create an array of orders and return it
        static Order[] ReceiveOrdersFromBranch1()
        {
            // creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            // creating new orders array
            Order[] orders = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };
            return orders;
        }
    }

    // a class named order we will use it to store instances of it inside a queue
    class Order
    {
        // order ID
        public int OrderID { get; set; }

        // quantity of the order
        public int OrderQuantity { get; set; }

        // simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderID = id;
            this.OrderQuantity = orderQuantity;
        }

        // print message on the screen that the order was processed
        public void ProcessOrder()
        {
            // print the message
            Console.WriteLine($"Order {OrderID} processed!.");
        }
    }
}
