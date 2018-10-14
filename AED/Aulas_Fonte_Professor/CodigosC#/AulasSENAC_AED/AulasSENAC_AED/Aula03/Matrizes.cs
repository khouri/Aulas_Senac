using System;
using System.Collections.Generic;
using System.Text;

public class Matriz
{

    int[][] matriz;

    public Matriz(int linhas, int colunas)
    {

        matriz = new int[linhas][];
        Random random = new Random(123);

        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = i; j < matriz[i].Length; j++)
            {
                matriz[i][j] = random.Next();
            }
        }
    }

    public int[][] addScalarValue(int scalar, int[][] matriz)
    {

        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = i; j < matriz[i].Length; j++)
            {
                matriz[i][j] = matriz[i][j] + scalar;
            }
        }

        return matriz;
    }

    //HÃ¡ algum problema aqui???
    public int[][] sumTwoMatrix(int[][] matrixA, int[][]  matrixB)
    {

        for (int i = 0; i < matrixA.Length; i++)
        {
            for (int j = i; j < matrixA[i].Length; j++)
            {
                matrixA[i][j] = matrixA[i][j] + matrixB[i][j];
            }
        }
        return matrixA;
    }


    public int sumAllElements(int[][] matrixA)
    {

        int soma = 0;
        for (int i = 0; i < matrixA.Length; i++)
        {
            for (int j = i; j < matrixA[i].Length; j++)
            {
                soma = soma + matrixA[i][j];
            }
        }

        return soma;
    }

    
}
