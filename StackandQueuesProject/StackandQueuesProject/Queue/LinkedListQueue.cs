﻿using System;
using System.Collections.Generic;
using StackandQueuesProject.LinkedList;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueuesProject.Queue
{
    internal class LinkedListQueue
    {
        //variable
        private Node front;
        /// <summary>
        /// Enqueues the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.front == null)
                this.front = node;
            else
            {
                Node rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = node;
            }
            Console.WriteLine("{0} Enqueued into Queue", value);
        }
        /// <summary>
        /// display the elements of Queue.
        /// </summary>
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine("Element in Queue:" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
