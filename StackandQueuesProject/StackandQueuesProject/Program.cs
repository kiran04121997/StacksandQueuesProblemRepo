using System;
using System.Collections.Generic;
using StackandQueuesProject.Stack;
using StackandQueuesProject.LinkedList;
using StackandQueuesProject.Queue;
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

            CallStackQueue();
            Console.ReadLine();
        }
        /// <summary>
        /// Calls the stack queue.
        /// </summary>
        public static void CallStackQueue()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("\nEnter your option!");
                Console.WriteLine("1=Stack , 2=Queue , 3=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("<---Creating A Stack---> \n");
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        Console.WriteLine("\n<---PeekOperationInStack--->\n");
                        linkedListStack.Peek();
                        linkedListStack.Display();
                        Console.WriteLine("\n<---PopOperation--->\n");
                        linkedListStack.Pop();
                        linkedListStack.Display();
                        Console.WriteLine("\n<---PopTillStackBecomesEmpty--->\n");
                        linkedListStack.IsEmpty();
                        linkedListStack.Display();
                        break;
                    case 2:
                        Console.WriteLine("<---Creating A Queue---> \n");
                        linkedListQueue.Enqueue(56);
                        linkedListQueue.Enqueue(30);
                        linkedListQueue.Enqueue(70);
                        linkedListQueue.Display();
                        Console.WriteLine("<---Dequeue from Queue---> \n");
                        linkedListQueue.Dequeue();
                        linkedListQueue.Display();
                        Console.WriteLine("<---Copy element from Queue into Stack---> \n");
                        linkedListQueue.CopyIntoStack();
                        break;
                    case 3:
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option!");
                        break;
                }
            }
        }
    }
}

