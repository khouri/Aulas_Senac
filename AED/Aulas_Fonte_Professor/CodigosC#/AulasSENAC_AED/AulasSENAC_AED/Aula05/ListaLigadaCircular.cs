using System;
using System.Collections.Generic;
using System.Text;

public class ListaLigadaCircular
{

    public int size = 0;
    public NodeCircular head = null;
    public NodeCircular tail = null;

    //add a new node at the start of the linked list
    public void addNodeAtStart(int data)
    {
        Console.WriteLine("Adding node " + data + " at start");
        NodeCircular n = new NodeCircular(data);
        if (size == 0)
        {
            head = n;
            tail = n;
            n.next = head;
        }
        else
        {
            NodeCircular temp = head;
            n.next = temp;
            head = n;
            tail.next = head;
        }
        size++;
    }

    public void addNodeAtEnd(int data)
    {
        if (size == 0)
        {
            addNodeAtStart(data);
        }
        else
        {
            NodeCircular n = new NodeCircular(data);
            tail.next = n;
            tail = n;
            tail.next = head;
            size++;
        }
        Console.WriteLine("\nNode " + data + " is added at the end of the list");
    }

    public void deleteNodeFromStart()
    {
        if (size == 0)
        {
            Console.WriteLine("\nList is Empty");
        }
        else
        {
            Console.WriteLine("\ndeleting node " + head.data + " from start");
            head = head.next;
            tail.next = head;
            size--;
        }
    }

    public int elementAt(int index)
    {
        if (index > size)
        {
            return -1;
        }
        NodeCircular n = head;
        while (index - 1 != 0)
        {
            n = n.next;
            index--;
        }
        return n.data;
    }

    //print the linked list
    public void print()
    {
        Console.WriteLine("Circular Linked List:");
        NodeCircular temp = head;
        if (size <= 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            do
            {
                Console.WriteLine(" " + temp.data);
                temp = temp.next;
            }
            while (temp != head);
        }
        Console.WriteLine();
    }

    //get Size
    public int getSize()
    {
        return size;
    }

}
