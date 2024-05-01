using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining new stack
            Stack<int> stack = new Stack<int>();
            // add elements to the stack using push()
            stack.Push(1);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}",stack.Peek());
            // add elements to the stack using push()
            stack.Push(2);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            // add elements to the stack using push()
            stack.Push(3);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            while (stack.Count > 0)
            {
                // Remove and return an element from the stack using pop()
                int myStackItem = stack.Pop();
                Console.WriteLine("The top value {0} was removed from the stack", myStackItem);
                // Print the stack count
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            // defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are : ");
            // foreach number in our array
            foreach (int number in numbers)
            {
                // print it
                Console.Write(number + " ");
                // push it into our stack(add)
                myStack.Push(number);
            }


            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse are : ");
            // as long as our stack is not empty
            while (myStack.Count > 0)
            {
                // pop it and store it in a variable
                int number = myStack.Pop();
                // print the value we popped
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
