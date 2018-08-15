package ListaLigadaCircular;

public class ExecutaListaLigadaCircular {

	public static void main(String[] args) {
		
		ListaLigadaCircular c = new ListaLigadaCircular();
		
		c.addNodeAtStart(3);
		c.addNodeAtStart(2);
		c.addNodeAtStart(1);
		c.print();
		c.deleteNodeFromStart();
		c.print();
		c.addNodeAtEnd(4);
		c.print();
		System.out.println("Size of linked list: "+ c.getSize());
		System.out.println("Element at 2nd position: "+ c.elementAt(2));
	}
}
