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

            // Displaying linked list
            linkedList.DisplayLinkedList();
        }
    }
}