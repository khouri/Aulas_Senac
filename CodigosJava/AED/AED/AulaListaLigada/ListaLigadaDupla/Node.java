package ListaLigadaDupla;

public class Node {

	int data;
	Node prev;
	Node next;

	// Constructor to create a new node
	// next and prev is by default initialized as null
	public Node(int d){
		
		this.data = d;
		this.next = null;
		this.prev = null;
	} 

}
