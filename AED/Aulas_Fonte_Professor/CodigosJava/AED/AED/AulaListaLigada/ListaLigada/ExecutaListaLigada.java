package ListaLigada;

public class ExecutaListaLigada {

	/* method to create a simple linked list with 3 nodes*/
	public static void main(String[] args)
	{
		/* Start with the empty list.*/
		SingleLinkedList llist = new SingleLinkedList();

		llist.head  = new Node(1);
		Node second = new Node(2);
		Node third  = new Node(3);

		llist.head.next = second; // Link first node with the second node
		second.next = third; 	  // Link second node with the third node

		//Print all elements of the list
		llist.printList();


		// Insert 6.  So linked list becomes 6->NUllist
		llist.append(6);

		// Insert 7 at the beginning. So linked list becomes
		// 7->6->NUllist
		llist.push(7);


		// Insert 1 at the beginning. So linked list becomes
		// 1->7->6->NUllist
		llist.push(1);

		// Insert 4 at the end. So linked list becomes
		// 1->7->6->4->NUllist
		llist.append(4);

		// Insert 8, after 7. So linked list becomes
		// 1->7->8->6->4->NUllist
		llist.insertAfter(llist.head.next, 8);

		System.out.println("\nCreated Linked list is: ");
		llist.printList();
	}
}


