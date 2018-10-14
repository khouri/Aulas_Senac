using System;
using System.Collections.Generic;
using System.Text;

public class NodeDouble
{

    public int data;
    public NodeDouble prev;
    public NodeDouble next;

    // Constructor to create a new node
    // next and prev is by default initialized as null
    public NodeDouble(int d)
    {
        this.data = d;
        this.next = null;
        this.prev = null;
    }

}
