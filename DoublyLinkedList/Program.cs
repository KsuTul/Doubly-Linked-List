using DoublyLnkedList;
using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node()
            {
                Prev = null,
                Data = 1,
                Next = null,
            };

            var list = new DoublLinkedList();
            list.Head = first;
            list.Tail = first;
            list.Count++;
            list.PushFront(2);
            Console.WriteLine(list.Tail.Data);//1
            list.PushBack(7);
            Console.WriteLine(list.Tail.Data);//7
            list.InsertIn(2,8);
            var newList = list.Copy();
            var result = newList.PrintList();
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
