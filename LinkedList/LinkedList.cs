using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> where T : IComparable
    {
        public Node<T> head;
        public void Pop()
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return;
            }

            // If linked list is not empty
            this.head = head.next;
        }
        public void PopLast()
        {
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
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
            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return 0;
            }

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
            Console.WriteLine($"\nElement found at {elementNum}");
            return elementNum;
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
        public int ImplementSize()
        {
            int count = 1;

            // If linked list is empty
            if (this.head == null)
            {
                Console.WriteLine("\nNo elements in linked list");
                return 0;
            }
            Node<T> tempNode = this.head;
            while (tempNode.next != null)
            {
                count++;
                tempNode = tempNode.next;
            }
            Console.WriteLine("\n The number of elements in linked list are : {0}", count);
            return count;
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
            Console.WriteLine("\nThe elements are : ");
            while (tempNode != null)
            {
                Console.Write(tempNode.data + "\t");
                tempNode = tempNode.next;
            }
        }
    }
}
