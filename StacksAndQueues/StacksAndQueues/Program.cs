using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedListStack = new LinkedList();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();
            Console.ReadKey();
        }
    }
}
