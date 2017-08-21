using System;

namespace Linked_List
{
    public class Node
    {
        public int _data;
        public Node _next;

        public Node (int data): this (data,null)
        {}

        public Node(int data, Node next)
        {
            this._data = data;
            this._next = next;
        }
    }

    public class Singly_Linked_List
    {
        private Node _first;
        private int _size;

 
        public Singly_Linked_List()
        {
            this._first = null;
            this._size = 0;

        }

        public void InsertNodeFront(int num){
            Node _node = new Node(num, _first);
            _first = _node;
            _size++;
            
        }
        public int ReturnSize(){
            return _size;
            
        }

        public void printLList()
        {
            Node p;
            System.Console.Write("[");
            for (p = _first; p != null; p = p._next)
            {
                System.Console.Write(" " + p._data);
            }
            System.Console.Write(" ]");
            System.Console.WriteLine();
        }
        /*
         * Reverse linked list itterative
         */
        public void reverseList(){
            reverseList(_first);
            
        }
        /*
         * Helper Function for reversing linked list
         */
        public void reverseList(Node head){

            Node current = null;
            Node previous = null;

            while(head != null){
                current = head;
                head = head._next;
                current._next = previous;
                previous = current;
            }
            _first = current;
            
        }

        public void reverseListR()
        {
            reverseListR(_first);
        }

        public void reverseListR(Node head)
        {
            if (head == null) return;
            if (head._next == null) {
                _first = head;
                return;
            }
            reverseListR(head._next);
            head._next._next = head;
            head._next = null;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Singly_Linked_List myList = new Singly_Linked_List();
            myList.InsertNodeFront(9);
            myList.InsertNodeFront(8);
            myList.InsertNodeFront(7);
            myList.InsertNodeFront(6);
            myList.InsertNodeFront(5);
            myList.InsertNodeFront(4);
            myList.InsertNodeFront(3);
            myList.InsertNodeFront(2);
            myList.InsertNodeFront(1);
            myList.InsertNodeFront(0);
            System.Console.WriteLine(myList.ReturnSize());
            myList.printLList();
            myList.reverseList();
            myList.printLList();
            myList.reverseListR();
            myList.printLList();
        }
    }
}
