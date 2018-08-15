using System;
using System.Collections.Generic;
using System.Text;


public class Arrays
{

    public int[] meuArray;

    public Arrays(int tamanho)
    {

        meuArray = new int[tamanho];
        Random random = new Random(123);

        int i = 0;
        int sizeArray = meuArray.Length;
        while (i < sizeArray)
        {
            meuArray[i] = random.Next();
            i++;
        }
    }

    public void printArray(int []arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i] + " , ");
        }
    }

    public void printArray(char[] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i] + " , ");
        }
    }

    public int[] addScalarValue(int scalar, int [] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] + scalar;
        }

        return array;
    }

    //Ha algum problema aqui???
    public int[] sumTwoArrays(int [] arrayA, int [] arrayB)
    {

        for (int i = 0; i < arrayA.Length; i++)
        {
            arrayA[i] = arrayA[i] + arrayB[i];
        }

        return arrayA;
    }


    public int sumAllElements(int []arrayA)
    {

        int resultado = arrayA[0];
        for (int i = 1; i < arrayA.Length; i++)
        {
            resultado += arrayA[i];
        }

        return resultado;
    }


    public int encontraMinimo(int [] arrayA)
    {

        int minimo = arrayA[0];
        for (int i = 1; i < arrayA.Length; i++)
        {

            if (minimo < arrayA[i])
            {
                minimo = arrayA[i];
            }
        }

        return minimo;
    }

    //Busca seq
    public int sequencialSearch(int [] arrayA, int chave)
    {

        int indice = -1;
        for (int i = 0; i < arrayA.Length; i++)
        {

            if (chave == arrayA[i])
            {
                indice = i;
                break;
            }
        }

        return indice;
    }

    int binarySearch(int []arr, int l, int r, int x)
    {
        if (r >= l)
        {
            int mid = l + (r - l) / 2;

            // If the element is present at the 
            // middle itself
            if (arr[mid] == x)
                return mid;

            // If element is smaller than mid, then 
            // it can only be present in left subarray
            if (arr[mid] > x)
                return binarySearch(arr, l, mid - 1, x);

            // Else the element can only be present
            // in right subarray
            return binarySearch(arr, mid + 1, r, x);
        }

        // We reach here when element is not present
        //  in array
        return -1;
    }

    public int [] inverteOrdem(int[]array) {

        int[] novoArray = new int[array.Length];
        int j = 0;
        for (int i = array.Length; i >= 0; i--) { 

            novoArray[j] = array[i];
            j++; 
        }
        
        return novoArray;
    }


    public int[] contaDuplicados(int[] array)
    {
        int[] novoArray = new int[array.Length];
        for (int i = 0; i >= 0; i++)
        {
            int j = 0;
            for (int x = 0; x >= 0; x++)
            {
                if (array[x] == array[i]) {

                    j++;
                }

            }
            novoArray[i] = j;
        }

        return novoArray;
    }

}
