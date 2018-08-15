package pilha;

import java.util.LinkedList;


/* Java program to implement basic stack
operations */
public class PilhaLL 
{
 static final int MAX = 1000;
 int top;
 
 LinkedList<Integer> a = new LinkedList<Integer>();
 
 boolean isEmpty() {
     return (top < 0);
 }
 
 public  PilhaLL()
 {
     top = -1;
 }

 boolean push(int x)
 {   
     a.add(x);
     return true;
 }

 int pop()
 {        
     return a.removeLast();
 }
}
