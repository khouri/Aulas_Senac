package ListaLigadaDupla;

public class ExecutaListaLigadaDupla {

	 /* Drier program to test above functions*/
    public static void main(String[] args) 
    {
        /* Start with the empty list */
        DoubleLinkedList dll = new DoubleLinkedList();
          
        // Insert 6. So linked list becomes 6->NULL
        dll.append(6);
         
        // Insert 7 at the beginning. So linked list becomes 7->6->NULL
        dll.push(7);
         
        // Insert 1 at the beginning. So linked list becomes 1->7->6->NULL
        dll.push(1);
         
        // Insert 4 at the end. So linked list becomes 1->7->6->4->NULL
        dll.append(4);
         
        // Insert 8, after 7. So linked list becomes 1->7->8->6->4->NULL
        dll.InsertAfter(dll.head.next, 8);
         
         
        System.out.println("Created DLL is: ");
        dll.printlist(dll.head);
    }
}
