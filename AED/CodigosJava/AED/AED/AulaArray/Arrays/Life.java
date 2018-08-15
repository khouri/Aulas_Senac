package Arrays;

public class Life {

	int MAX = 10;//Tamanho da matriz
	int[][]matriz = new int[MAX][MAX] ;

	void inicializa() {
		int i,j;
		for ( i = 1 ; i < MAX - 1 ; i ++)
			for ( j = 1 ; j < MAX - 1 ; j ++)
				matriz[i][j] = ( int ) ( Math.random() * 1.5 );

	}

	void imprimeTabuleiro(){

		int i , j ;
		for ( i = 0 ; i < MAX; i ++) {
			for ( j = 0 ; j < MAX; j ++)
				if ( matriz[i] [j] == 1 )
					System.out.print( " ∗ " ) ;
				else
					System.out.print( " . " ) ;
			System.out.println();
		}
		System.out.println();
	}

	int vizinhos( int i , int j )
	{
		return matriz[i - 1][j -1] + matriz[i -1][ j ] + matriz[i -1][j + 1 ] +
			matriz[ i ] [ j -1] + matriz[ i ] [ j + 1] +
			matriz[i + 1] [ j -1] + matriz[ i + 1 ] [ j ] + matriz[ i + 1 ] [ j + 1 ] ;
	}
	
	int[][]iteracao(){
		int [ ] [ ] aux = new int [MAX] [MAX] ;
		int i,j;
		for( i = 1 ; i < MAX - 1 ; i ++)
			for( j = 1 ; j < MAX - 1 ; j ++)
				if( matriz[i][j] == 1 )
					// se está viva
				{
					if ( ( vizinhos(i,j) < 2) || ( vizinhos(i,j) > 3))
						aux[i][j] = 0 ;
					// morre
					else
						aux[i][j] = 1 ;
					// continua viva
				}
				else
					//se não e s t á v i v a
					{
					if(vizinhos(i,j) == 3 )
					aux[i][j] = 1 ;
					// aparece vida
					else
						aux[i][j] = 0 ;
					// c o n t i n u a como e s t a v a
					}
			
		return aux ; // d e v o l v e a m a t r i z com a nova i t e r a ç ã o
	}
	
	void simulaVida( int quant )
	{
		int i ;
		// f a r e m o s a s i m u l a ç ã o de q u a n t o s c i c l o s
		for ( i = 0 ; i < quant ; i ++)
		{
			imprimeTabuleiro( );
			matriz = iteracao() ; // a m a t r i z da i t e r a ç ã o a n t e r i o r é r e c o l h i d a
			// p e l o c o l e t o r de l i x o .
		}
	}
	
}