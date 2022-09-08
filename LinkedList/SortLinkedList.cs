using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortLinkedList<T> : LinkedList<T> where T : IComparable
    {
        /// <summary>
        /// UC 10 Inserts the element.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertElement(T data)
        {
            Node<T> tempNode;
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }

            int n = head.data.CompareTo(data);
            // If the first element is greater than given element
            if (head.data.CompareTo(data) > 0)
            {
                tempNode = new Node<T>(data);
                tempNode.next = head;
                head = tempNode;
                return;
            }

            if (head.next == null)
            {
                head.next = new Node<T>(data);
                return;
            }
            tempNode = this.head;

            // Continue the loop till the given data is greater than list elements
            while (tempNode.next.data.CompareTo(data) < 0)
            {
                if (tempNode.next.next != null)
                    tempNode = tempNode.next;
                else
                {
                    tempNode.next.next = new Node<T>(data);
                    return;
                }

            }

            // Insert element in between list
            Node<T> newNode = new Node<T>(data);
            newNode.next = tempNode.next;
            tempNode.next = newNode;
        }
    }
}
