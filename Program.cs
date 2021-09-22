using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList < int > list= new LinkedList<int>();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.InsertFront(70);
            customLinkedList.InsertFront(30);
            customLinkedList.InsertFront(56);
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}