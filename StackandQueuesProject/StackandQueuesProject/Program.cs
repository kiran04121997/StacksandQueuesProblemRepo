using System;
using System.Collections.Generic;
using StackandQueuesProject.Stack;
using StackandQueuesProject.LinkedList;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueuesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Stack And Que problem");
            /// <summary>
            /// Defines the entry point of the application.
            /// </summary>
            /// <param name="args">The arguments.</param>

            CallStackQueue();

        }
        /// <summary>
        /// Calls the stack queue.
        /// </summary>
        public static void CallStackQueue()
        {
           LinkedListStack linkedListStack = new LinkedListStack();
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("\nEnter your option!");
                Console.WriteLine("1=Stack , 2=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("<---Creating A Stack--->");
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        break;
                    case 2:
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
