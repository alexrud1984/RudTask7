using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackNQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            RunQueue();
            RunStack();
        }

        static void RunQueue()
        {
            string command;
            MyQueue <Something> queue = new MyQueue <Something>(5);
            do
            {
                Console.WriteLine("Put your command for queue");
                switch (command = Console.ReadLine())
                {
                    case "enq":
                        if (queue.IsFull())
                        {
                            Console.WriteLine("The queue is full");
                            break;
                        }
                        Console.WriteLine("Put the value for enqueue");
                        queue.Enqueue(new Something { Name = Console.ReadLine() });
                        break;
                    case "deq":
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("The queue is empty");
                            break;
                        }
                        Console.WriteLine(queue.Dequeue());
                        break;
                    case "isempty":
                        Console.WriteLine(queue.IsEmpty());
                        break;
                    case "isfull":
                        Console.WriteLine(queue.IsFull());
                        break;
                    case "print":
                        queue.Print();
                        break;
                    case "exit":
                        break;
                    case "help":
                        Console.WriteLine("Nobody can help you, all helpers are busy!");
                        break;
                    default:
                        Console.WriteLine("Unknown command see help");
                        break;
                }
            }
            while (command != "exit");
        }

        static void RunStack()
        {
            MyStack <Something> stack = new MyStack <Something>(5);
            string command;
            do
            {
                Console.WriteLine("Put your command for stack");
                switch (command = Console.ReadLine())
                {
                    case "push":
                        if (stack.IsFull())
                        {
                            Console.WriteLine("The stack is full");
                            break;
                        }
                        Console.WriteLine("Put the integer value for push");
                        stack.Push(new Something { Name = Console.ReadLine() });
                        break;
                    case "pop":
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine("The sthack is empty");
                            break;
                        }
                        Console.WriteLine(stack.Pop());
                        break;
                    case "isempty":
                        Console.WriteLine(stack.IsEmpty());
                        break;
                    case "isfull":
                        Console.WriteLine(stack.IsFull());
                        break;
                    case "peek":
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine("The sthack is empty");
                            break;
                        }
                        Console.WriteLine(stack.Peek());
                        break;
                    case "print":
                        stack.Print();
                        break;
                    case "exit":
                        break;
                    case "help":
                        Console.WriteLine("Nobody can help you, all helpers are busy!");
                        break;
                    default:
                        Console.WriteLine("Unknown command see help");
                        break;
                }
            }
            while (command != "exit");
        }

    }
}
