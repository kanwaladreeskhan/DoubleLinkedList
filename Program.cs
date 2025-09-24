using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLL dLL = new DLL();
            dLL.head = new Node(1);
            Node second=new Node(2);
            dLL.head.next = second;
            second.prev = dLL.head;
            dLL.DisplayForward(dLL.head);
            Console.WriteLine("Insertion At the end of list:");
            dLL.AddAtEnd(3);
            dLL.AddAtEnd(4);
            dLL.AddAtEnd(5);
            dLL.DisplayForward(dLL.head);
            Console.WriteLine("Insertion At the start of list:");
            dLL.AddAtFront(0);
            dLL.DisplayForward(dLL.head);
            Console.WriteLine("Insertion After a node of list:");
            dLL.AddAfter(9, second);
            dLL.DisplayForward(dLL.head);
            Console.WriteLine("Deletion of node:");
            dLL.delete(5);
            dLL.DisplayForward(dLL.head);
            dLL.DisplayBackward(dLL.head);
        }
    }
}
