public int encontraMinimo(int arrayA[]){

int minimo = arrayA[0];
for (int i = 1; i < arrayA.length; i++) {
 
 if(minimo < arrayA[i]){
	 minimo = arrayA[i];
 }
}

return minimo;
}
