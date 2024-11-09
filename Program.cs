using System;

namespace KASDLab16
{
    internal class Program
    {
        static void Main()
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();

            myLinkedList.AddLast(1);
            myLinkedList.AddLast(2);
            myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);

            myLinkedList.Print();

            myLinkedList.RemoveValue(2);

            myLinkedList.Print();

            Console.WriteLine(myLinkedList.Get(1));

            myLinkedList.Add(1, 5);
            myLinkedList.Print();

            int[] a = { 11, 3 };

            myLinkedList.AddAll(1, a);
            myLinkedList.Print();

            Console.WriteLine(myLinkedList.IndexOf(3));
            Console.WriteLine(myLinkedList.LastIndexOf(3));

            Console.WriteLine(myLinkedList.Remove(2));
            myLinkedList.Print();

            Console.WriteLine(string.Join(" ", myLinkedList.SubList(2, 4)));

            Console.WriteLine(myLinkedList.Pull());
            myLinkedList.Print();

            myLinkedList.AddFirst(55);
            myLinkedList.Print();

            Console.ReadKey();

        }
    }
}
