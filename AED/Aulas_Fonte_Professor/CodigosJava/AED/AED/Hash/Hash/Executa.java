package Hash;

public class Executa {

	static double exponenciacao(double a, int n) {
		
		double an;
		if (n == 0) {
			return 1; /* caso base */
		} else {
			double aux = exponenciacao(a, n / 2);
			an = aux * aux;
			if (n % 2 == 1) {
				an = an * a;
			}
			return an;
		}
	}

	public static void main(String[] args) {

	System.out.println(exponenciacao(2,4));	
	}
}
