using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tempLastNode;
        public void InsertAtLast(T data)
        {
            // If the linked list is empty
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                tempLastNode = head;
                return;
            }

            // If the head is already full
            tempLastNode.next = new Node<T>(data);
            tempLastNode = tempLastNode.next;
        }
        public void InsertAtFirst(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                tempLastNode = head;
                return;
            }
            Node<T> tempNode = this.head;
            this.head = new Node<T>(data);
            head.next = tempNode;
        }
        public void InsertBetween(T dataOne, T dataTwo, T data)
        {
            if (this.head == null)
            {
                Console.WriteLine("The specified order of elements not found");
                return;
            }
            Node<T> tempNode = this.head;
            while (!(tempNode.data.Equals(dataOne) && tempNode.next.data.Equals(dataTwo) && tempNode.next != null))
            {
                tempNode = tempNode.next;
            }
            if (tempNode.next == null)
                return;
            Node<T> tempNextNode = tempNode.next;

            tempNode.next = new Node<T>(data);

            tempNode.next.next = tempNextNode;
        }

        public void DisplayLinkedList()
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("No elements in linked list");
                return;
            }
            // If linked list has elements then iterate till the next of a node is null
            Node<T> tempNode = this.head;
            Console.WriteLine("The elements are : ");
            while (tempNode != null)
            {
                Console.Write(tempNode.data + "\t");
                tempNode = tempNode.next;
            }
        }
    }
}
