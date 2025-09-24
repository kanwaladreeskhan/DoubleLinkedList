using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class DLL
    {
       public Node head;
        public void AddAtEnd(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next=newnode;
            newnode.prev = temp;
        }
        public void AddAtFront(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return;
            }
            newnode.next = head;
            head.prev= newnode;
            head = newnode;
            
        }
        public void AddAfter(int data,Node node)
        {
            Node newnode = new Node(data);
            if (node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");
                return;
            }
            newnode.next = node.next;
            node.next = newnode;
            newnode.prev= node;
            if ( newnode.next != null)
            {
                newnode.next.prev = newnode;
             }
        }
        public void delete(int data)
        {
            Node temp = head;
            while(temp.data != data)
            {
                temp = temp.next;
            }
            temp.prev.next = temp.next;
        }
        public void DisplayForward(Node head)
        {
            Console.WriteLine("Forward Traversing: ");
            while (head != null)
            {
                Console.Write(head.data + "  ");
                head = head.next;
            }
            Console.WriteLine();
        }
        public void DisplayBackward(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            while (head.next!= null)
            {  
                head = head.next;
            }
            Console.WriteLine("Backward Traversing: ");
            while (head != null)
            {
                Console.Write(head.data + "  ");
                head = head.prev;
            }
            Console.WriteLine() ;
            }

    }
   
}
