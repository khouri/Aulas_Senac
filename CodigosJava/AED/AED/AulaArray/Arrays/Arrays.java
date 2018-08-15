package Arrays;

import java.util.Random;

public class Arrays {

	int [] meuArray;
	
	public Arrays(int tamanho){
		
		meuArray = new int[tamanho];
		Random random = new Random();
		random.setSeed(123L);
		
		int i = 0;
		int sizeArray = meuArray.length;
		while(i < sizeArray){
			
			meuArray[i] = random.nextInt(100);
			i++;
		}
	}
	
	public void printArray(int arrayToPrint[]){
	
		for (int i = 0; i < arrayToPrint.length; i++) {
			System.out.print(arrayToPrint[i] + " , ");
		}
	}
	
	public int[] addScalarValue(int scalar, int array[]){
		
 		for (int i = 0; i < array.length; i++) {
			array[i] = array[i] + scalar;
		}
		
		return array;
	}
	
	//Há algum problema aqui???
	public int[] sumTwoArrays(int arrayA[], int arrayB[]){
		
 		for (int i = 0; i < arrayA.length; i++) {
			arrayA[i] = arrayA[i] + arrayB[i];
		}
		
		return arrayA;
	}
	
	
	public int sumAllElements(int arrayA[]){
		
		int resultado = arrayA[0];
 		for (int i = 1; i < arrayA.length; i++) {
 			resultado += arrayA[i];
		}
		
		return resultado;
	}
	

	public int encontraMinimo(int arrayA[]){
		
		int minimo = arrayA[0];
 		for (int i = 1; i < arrayA.length; i++) {
 				
 			if(minimo < arrayA[i]){
 				minimo = arrayA[i];
 			}
		}
		
		return minimo;
	}
	
	//Busca seq
	public int sequencialSearch(int arrayA[], int key){
		
		int minimo = -1;
 		for (int i = 0; i < arrayA.length; i++) {
 				
 			if(key ==  arrayA[i]){
 				minimo = i;
 				break;
 			}
		}
		
		return minimo;
	}
	
	 int binarySearch(int arr[], int l, int r, int x)
	    {
	        if (r>=l)
	        {
	            int mid = l + (r - l)/2;
	 
	            // If the element is present at the 
	            // middle itself
	            if (arr[mid] == x)
	               return mid;
	 
	            // If element is smaller than mid, then 
	            // it can only be present in left subarray
	            if (arr[mid] > x)
	               return binarySearch(arr, l, mid-1, x);
	 
	            // Else the element can only be present
	            // in right subarray
	            return binarySearch(arr, mid+1, r, x);
	        }
	 
	        // We reach here when element is not present
	        //  in array
	        return -1;
	    }
	
}
