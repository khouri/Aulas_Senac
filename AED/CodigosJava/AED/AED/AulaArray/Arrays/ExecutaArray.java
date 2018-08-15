package Arrays;

public class ExecutaArray {
	
	public static void main(String[] args) {
		
		Arrays classeDeArrays = new Arrays(1000);
		Arrays classeDeArraysB = new Arrays(1000);

		classeDeArrays.printArray(classeDeArrays.meuArray);
		
		classeDeArrays.addScalarValue(100, classeDeArrays.meuArray);
		System.out.println("");
		classeDeArrays.printArray(classeDeArrays.meuArray);
		
		int [] ArraysSomados = classeDeArrays.sumTwoArrays(classeDeArrays.meuArray, classeDeArraysB.meuArray);
		System.out.println("");
		classeDeArrays.printArray(ArraysSomados);
		
	}
}
