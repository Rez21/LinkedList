using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!");

            // Initialising a linked list
            UnsortedLinkedList<int> linkedList = new UnsortedLinkedList<int>();

            // UC 1 and UC 3 Adding elements to linkedlist
            linkedList.InsertAtLast(56);
            linkedList.InsertAtLast(30);
            linkedList.InsertAtLast(70);
            Console.WriteLine("\nAdded elements to last in linkedList");
            linkedList.DisplayLinkedList();


            // UC 2 Adding elements at first
            UnsortedLinkedList<int> linkedListOne = new UnsortedLinkedList<int>();
            linkedListOne.InsertAtFirst(70);
            linkedListOne.InsertAtFirst(30);
            linkedListOne.InsertAtFirst(56);
            Console.WriteLine("\nAdded elements to first in linkedlist one");
            linkedListOne.DisplayLinkedList();

            // UC 4 Adding elements in between two given values
            UnsortedLinkedList<int> linkedListTwo = new UnsortedLinkedList<int>();
            linkedListTwo.InsertAtLast(56);
            linkedListTwo.InsertAtLast(70);
            linkedListTwo.InsertBetween(56, 70, 30);
            Console.WriteLine("\nAdded elements in between in linked list two");
            linkedListTwo.DisplayLinkedList();

            // UC 5 Delete at beginning
            linkedListTwo.Pop();
            linkedListOne.PopLast();

            // UC 6 Displaying linked list
            linkedList.DisplayLinkedList();
            Console.Write("\n\nPopped last element");
            linkedListOne.DisplayLinkedList();
            Console.Write("\n\nPopped first element");
            linkedListTwo.DisplayLinkedList();


            linkedList.SearchElement(30);

            
            linkedList.InsertAfterElement(30, 40);
            linkedList.DisplayLinkedList();

           
            linkedList.PopElement(40);
            linkedList.DisplayLinkedList();

            SortLinkedList<int> sortedLinkedList = new SortLinkedList<int>();
            sortedLinkedList.InsertElement(56);
            sortedLinkedList.InsertElement(30);
            sortedLinkedList.InsertElement(40);
            sortedLinkedList.InsertElement(70);
            Console.WriteLine("\nElements of sorted list are : ");
            sortedLinkedList.DisplayLinkedList();
        }
    }
}