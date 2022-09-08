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
        public void Pop()
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("No elements in linked list");
                return;
            }

            // If linked list is not empty
            this.head = head.next;
        }
        public void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("No elements in linked list");
                return;
            }

            // If it has only one element
            if (head.next == null)
            {
                head = null;
                return;
            }

            // If the linked list is not empty
            Node<T> tempNode = this.head;

            // if next element is not equal to null
            while (tempNode.next.next != null)
                tempNode = tempNode.next;

            // Make the next of last but one element as null
            tempNode.next = null;
        }
        public int SearchElement(T data)
        {
            int elementNum = 1;
            Node<T> tempNode = this.head;
            // If the data of temp node is not equal to zero
            while (!tempNode.data.Equals(data))
            {
                if (tempNode.next != null)
                {
                    elementNum++;
                    tempNode = tempNode.next;
                }
                else
                {
                    Console.WriteLine("Element not found");
                    return 0;
                }
            }
            // Check the element number and return it
            Console.WriteLine($"Element found at {elementNum}");
            return elementNum;
        }
        public void InsertAfterElement(T afterData, T newData)
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If head is not null
            Node<T> tempNode = this.head;
            while (!tempNode.data.Equals(afterData))
            {
                if (tempNode.next != null)
                    tempNode = tempNode.next;
                else
                {
                    Console.WriteLine("\nElement not found");
                    return;
                }
            }
            Node<T> newElement = new Node<T>(newData);

            // If element is to be inserted in between
            if (tempNode.next != null)
                InsertBetween(tempNode.data, tempNode.next.data, newData);

            // If the element needs to be inserted at last
            else
                InsertAtLast(newData);

            Console.WriteLine("\nElement inserted");
        }
        public void PopElement(T data)
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If the searched element is first element
            if (head.data.Equals(data))
                this.head = head.next;

            // If the list has only one element
            else if (head.next == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            Node<T> tempNode = this.head;

            // If data in tempNode is not equal to user entry then go to next node
            while (!tempNode.next.data.Equals(data))
            {
                if (tempNode.next != null)
                    tempNode = tempNode.next;
                else
                {
                    Console.WriteLine("Element not found");
                    return;
                }
            }
            // If given element is last element
            if (tempNode.next.next == null)
                PopLast();

            // Delete the element in between list
            tempNode.next = tempNode.next.next;
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
