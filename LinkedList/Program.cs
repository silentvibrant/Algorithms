using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node {Value = 3};
            var second = new Node { Value = 5 };
            var third = new Node { Value = 7 };

            first.Next = second;
            second.Next = third;

            PrintList(first);
        }

        public static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
