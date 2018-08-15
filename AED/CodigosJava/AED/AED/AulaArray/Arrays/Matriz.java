package Arrays;

import java.util.Random;

public class Matriz {

	int [][]matriz;

	public Matriz(int linhas, int colunas){

		matriz = new int[linhas][colunas];
		Random random = new Random();
		random.setSeed(123L);

		for (int i = 0; i < matriz.length; i++) {
			for (int j = i; j < matriz[i].length; j++) {
				matriz[i][j] = random.nextInt();		
			}
		}
	}

	public int[][] addScalarValue(int scalar, int matriz[][]){

		for (int i = 0; i < matriz.length; i++) {
			for (int j = i; j < matriz[i].length; j++) {
				matriz[i][j] = matriz[i][j] + scalar;		
			}
		}

		return matriz;
	}

	//Há algum problema aqui???
	public int[][] sumTwoMatrix(int matrixA[][], int matrixB[][]){

		for (int i = 0; i < matrixA.length; i++) {
			for (int j = i; j < matrixA[i].length; j++) {
				matrixA[i][j] = matrixA[i][j] + matrixB[i][j];		
			}
		}
		return matrixA;
	}


	public int sumAllElements(int matrixA[][]){

		int soma = 0;
		for (int i = 0; i < matrixA.length; i++) {
			for (int j = i; j < matrixA[i].length; j++) {
				soma = soma + matrixA[i][j];		
			}
		}

		return soma;
	}

}
