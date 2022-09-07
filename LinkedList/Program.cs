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

            // Displaying linked list
            linkedList.DisplayLinkedList();
        }
    }
}