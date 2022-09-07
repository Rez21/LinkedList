using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!");

            // Initialising a linked list
            LinkedList<int> linkedList = new LinkedList<int>();

            // Adding elements to linkedlist
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);


            LinkedList<int> linkedListOne = new LinkedList<int>();
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);

            LinkedList<int> linkedListTwo = new LinkedList<int>();
            linkedListTwo.InsertAtLast(56);
            linkedListTwo.InsertAtLast(70);
            linkedListTwo.InsertBetween(56, 70, 30);

            linkedListTwo.DeleteAtFirst(); // delete  first 

            // Display
            linkedList.DisplayLinkedList();
            linkedListOne.DisplayLinkedList();
            linkedListTwo.DisplayLinkedList();
        }
    }
}