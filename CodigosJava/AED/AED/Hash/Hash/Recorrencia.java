package Hash;

/*
 * 
 * https://introcs.cs.princeton.edu/java/23recursion/
 *  
 * */

public class Recorrencia {

	public static long factorial(long n) {
		if (n == 0) 
			return 1;

		else {
			return n * factorial(n-1);
		}
	}

	public static int factorialIterative(int n) {

		int resultado = 1;
		for(int i = n;i > 0; i--){
			resultado = resultado * i;	
		}

		return resultado;
	}


	static double exponenciacao(double a, int n) {
		double an;
		if (n == 0) {
			return 1; /* caso base */
		} else {
			double aux = exponenciacao(a, n / 2);
			System.out.println(aux);
			an = aux * aux;
			//System.out.println(an);
			if (n % 2 == 1) {
				an = an * a;
				//System.out.println(an);
			}
			return an;
		}
	}

	public static double golden(int n) {
		if (n == 0) {
			return 1;
		}

		return 1.0 + 1.0 / golden(n-1);
	}

	public static void tree(int n, double x, double y, double a, double branchRadius) {

		double bendAngle   = Math.toRadians(15);
		double branchAngle = Math.toRadians(37);
		double branchRatio = 0.65;

		double cx = x + Math.cos(a) * branchRadius;
		double cy = y + Math.sin(a) * branchRadius;
		StdDraw.setPenRadius(0.001 * Math.pow(n, 1.2));
		StdDraw.line(x, y, cx, cy);
		if (n == 0) return;

		tree(n-1, cx, cy, a + bendAngle - branchAngle, branchRadius * branchRatio);
		tree(n-1, cx, cy, a + bendAngle + branchAngle, branchRadius * branchRatio);
		tree(n-1, cx, cy, a + bendAngle,               branchRadius * (1 - branchRatio));
		//tree(n-1, cx, cy, a - bendAngle,               branchRadius * (1 + branchRatio));
	}


	public static void print(String prefix, String remaining, int k) {

		if (k == 0) {
			System.out.println(prefix);
			return;
		}

		if (remaining.length() == 0) 
			return;
		
		//System.out.println(prefix + remaining.charAt(0));
		print(prefix + remaining.charAt(0), remaining.substring(1), k-1);//remove o primeiro caracter 
		
		//System.out.println(prefix);
		print(prefix, remaining.substring(1), k);
	}


	public int trib(int n)
	{
		if(n==1)
			return 0;
		else if(n==2)
			return 1;
		else if(n==3)
			return 1;
		else if(n>3)
			return (trib(n-1)+trib(n-2)+trib(n-3));
		else 
			return -1;
	}

	public static long fibonacci(int n) {
		if (n <= 1) return n;
		else return fibonacci(n-1) + fibonacci(n-2);
	}

	public int fibonacciIterative(int n) {
		if(n <= 1) {
			return n;
		}
		int fib = 1;
		int prevFib = 1;

		for(int i=2; i<n; i++) {
			int temp = fib;
			fib+= prevFib;
			prevFib = temp;
		}
		return fib;
	}

	public static void moves(int n, boolean left) {
		if (n == 0) return;
		moves(n-1, !left);
		if (left) System.out.println(n + " left");
		else      System.out.println(n + " right");
		moves(n-1, !left);
	}



	// recursive implementation
	public static int gcd(int p, int q) {
		if (q == 0) return p;
		else return gcd(q, p % q);
	}

	// non-recursive implementation
	public static int gcd2(int p, int q) {
		while (q != 0) {
			int temp = q;
			q = p % q;
			p = temp;
		}
		return p;
	}

	public static int somaPA(int primeirosNTermos){

		int resultado = 0;
		for(int i = 1; i <= primeirosNTermos;i++){
			resultado = resultado + i;
		}

		return resultado;
	}

	public static int somaPARec(int primeirosNTermos){

		if(primeirosNTermos == 1)
			return 1;
		else{

			return somaPARec(primeirosNTermos-1) + primeirosNTermos;
		}

	}


	public static int somaPAFormulaFechada(int N){

		return (N*(N+1)) / 2;
	}

	static int multr(int m, int n) {
		
		if(n == 0) {
			return 0;
		}
		else {
			return (m + multr(m, n-1));
		}
	}


	public static void main(String[] args) {

		//System.out.println(somaPARec(5));
		System.out.println(somaPAFormulaFechada(5));

		
		/*
		int resultado = factorialIterative(5);
		System.out.println(resultado);*/

		//		System.out.println(exponenciacao(2,3));
		//		
		//		System.out.println(1%2);

		
		 //teste arvore
		 int n = 10;//Integer.parseInt(args[0]);
	     StdDraw.enableDoubleBuffering();
	     tree(n, 0.5, 0, Math.PI/2, 0.3);
	     StdDraw.show();
		 

		//		 int n = 10;//Integer.parseInt(args[0]);
		//	     System.out.println(golden(n));

		//substrings de tamanho k
		String s = "abcd";
		int k = 3;
		print("", s, k);
		 
		 
		System.out.println("aabbccdd".substring(1));
		//fiboonacci
		/*int size = 100; 
		for(int i = 1; i<=size ;i++)
			System.out.println(fibonacci(i));
		 */

		//hanoi
		//moves(3, true);


		//System.out.println(gcd(10,5));

	}
}


