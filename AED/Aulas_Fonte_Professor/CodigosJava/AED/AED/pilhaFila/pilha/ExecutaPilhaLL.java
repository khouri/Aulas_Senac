package pilha;

public class ExecutaPilhaLL {
	 public static void main(String args[])
	 {
		 PilhaLL s = new PilhaLL();
	     s.push(10);
	     s.push(20);
	     s.push(30);
	     System.out.println(s.pop() + " Popped from stack");
	 }	
}
