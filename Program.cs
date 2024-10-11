using QueueClass;
using Singly_LinkedList;
using StackGenericClass;
using System;
namespace Week2Task
{
    class Program
    {
        /// <summary>
        /// The codes below are just some rough tests of my methods as written in their respective classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            QueueClass<int> myQueue = new QueueClass<int>();
            StackClass<int> myStack = new StackClass<int>();
            SinglyLinkedLists<int> newNode = new SinglyLinkedLists<int>();
            newNode.AddToTail(8);
            newNode.AddToTail(7);
            newNode.AddToTail(6);
            newNode.AddToTail(5);
            newNode.AddToTail(4);
            newNode.AddToTail(3);
            newNode.AddToTail(2);
            newNode.AddToTail(1);

            Console.WriteLine("\n");
            Console.WriteLine(newNode.ListSize());
            newNode.PrintList();
            Console.WriteLine("\n");

            Console.WriteLine(newNode.InList(5));

            newNode.RemoveNode(5);
            newNode.PrintList();

            Console.WriteLine("\n");
            newNode.RemoveNode(3);
            newNode.PrintList();

            Console.WriteLine(newNode.InList(5));

            Console.WriteLine(newNode.ListSize());

            Console.WriteLine("Stack");
            myStack.StackPush(5);
            myStack.StackPush(4);
            myStack.StackPush(3);
            myStack.StackPush(2);
            myStack.StackPush(1);
            myStack.StackPush(9);
            myStack.PrintStack();
            Console.WriteLine(myStack.StackPop());
            Console.WriteLine("         ");
            myStack.PrintStack();
            Console.WriteLine(myStack.StackPeep());


            Console.WriteLine("\n");
            Console.WriteLine(myStack.StackSize());
        
            Console.WriteLine("Queue");
            myQueue.EnQueue(4);
            myQueue.EnQueue(3);
            myQueue.EnQueue(2);
            myQueue.EnQueue(1);
            myQueue.EnQueue(9);
            myQueue.PrintQueue();
            Console.WriteLine("  \n");
            Console.WriteLine(myQueue.DeQueue());

            Console.WriteLine(myQueue.DeQueue());
            Console.WriteLine(myQueue.QueueSize());


        }
    }
}
