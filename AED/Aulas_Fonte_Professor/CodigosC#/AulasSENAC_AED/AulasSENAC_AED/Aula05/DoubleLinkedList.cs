﻿using System;
using System.Collections.Generic;
using System.Text;

public class DoubleLinkedList
{

    NodeDouble head; // head of list

    //Adding a node at the front of the list
    public void push(int new_data)
    {
        /* 1. allocate node 
	    * 2. put in the data */
        NodeDouble new_Node = new NodeDouble(new_data);

        /* 3. Make next of new node as head and previous as NULL */
        new_Node.next = head;
        new_Node.prev = null;

        /* 4. change prev of head node to new node */
        if (head != null)
            head.prev = new_Node;

        /* 5. move the head to point to the new node */
        head = new_Node;
    }

    /* Given a node as prev_node, insert a new node after the given node */
    public void InsertAfter(NodeDouble prev_Node, int new_data)
    {

        /*1. check if the given prev_node is NULL */
        if (prev_Node == null)
        {
            Console.WriteLine("The given previous node cannot be NULL ");
            return;
        }

        /* 2. allocate node 
	    * 3. put in the data */
        NodeDouble new_node = new NodeDouble(new_data);

        /* 4. Make next of new node as next of prev_node */
        new_node.next = prev_Node.next;


        /* 5. Make the next of prev_node as new_node */
        prev_Node.next = new_node;


        /* 6. Make prev_node as previous of new_node */
        new_node.prev = prev_Node;

        /* 7. Change previous of new_node's next node */
        if (new_node.next != null)
            new_node.next.prev = new_node;
    }

    //Add a node at the end of the list
    void append(int new_data)
    {
        /* 1. allocate node 
	     * 2. put in the data */
        NodeDouble new_node = new NodeDouble(new_data);

        NodeDouble last = head;/* used in step 5*/

        /* 3. This new node is going to be the last node, so
	     * make next of it as NULL*/
        new_node.next = null;

        /* 4. If the Linked List is empty, then make the new
	     * node as head */
        if (head == null)
        {
            new_node.prev = null;
            head = new_node;
            return;
        }

        /* 5. Else traverse till the last node */
        while (last.next != null)
            last = last.next;

        /* 6. Change the next of last node */
        last.next = new_node;

        /* 7. Make last node as previous of new node */
        new_node.prev = last;
    }

    // This function prints contents of linked list starting from the given node
    public void printlist(NodeDouble node)
    {
        NodeDouble last = null;
        Console.WriteLine("Traversal in forward Direction");
        while (node != null)
        {
            Console.WriteLine(node.data + " ");
            last = node;
            node = node.next;
        }
        Console.WriteLine();
        Console.WriteLine("Traversal in reverse direction");
        while (last != null)
        {
            Console.WriteLine(last.data + " ");
            last = last.prev;
        }
    }

    /*Function to delete a node in a Doubly Linked List.
    head_ref --> pointer to head node pointer.
    del  -->  pointer to node to be deleted. */
    void deleteNode(NodeDouble head_ref, NodeDouble del)
    {

        /* base case */
        if (head == null || del == null)
        {
            return;
        }

        /* If node to be deleted is head node */
        if (head == del)
        {
            head = del.next;
        }

        /* Change next only if node to be deleted is NOT the last node */
        if (del.next != null)
        {
            del.next.prev = del.prev;
        }

        /* Change prev only if node to be deleted is NOT the first node */
        if (del.prev != null)
        {
            del.prev.next = del.next;
        }

        /* Finally, free the memory occupied by del*/
        return;
    }

    /* UTILITY FUNCTIONS */
    /* Function to insert a node at the beginning of the Doubly Linked List */
    void push(NodeDouble head_ref, int new_data)
    {

        /* allocate node */
        NodeDouble new_node = new NodeDouble(new_data);

        /* since we are adding at the begining,
         prev is always NULL */
        new_node.prev = null;

        /* link the old list off the new node */
        new_node.next = (head);

        /* change prev of head node to new node */
        if ((head) != null)
        {
            (head).prev = new_node;
        }

        /* move the head to point to the new node */
        (head) = new_node;
    }

    /*Function to print nodes in a given doubly linked list
    This function is same as printList() of singly linked lsit */
    void printList(Node node)
    {
        while (node != null)
        {
            Console.WriteLine(node.data + " ");
            node = node.next;
        }
    }

    /* Function to reverse a Doubly Linked List */
    void reverse()
    {
        NodeDouble temp = null;
        NodeDouble current = head;

        /* swap next and prev for all nodes of 
         doubly linked list */
        while (current != null)
        {
            temp = current.prev;
            current.prev = current.next;
            current.next = temp;
            current = current.prev;
        }

        /* Before changing head, check for the cases like empty 
         list and list with only one node */
        if (temp != null)
        {
            head = temp.prev;
        }
    }

}

