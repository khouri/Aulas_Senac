public int sequencialSearch(int arrayA[], int chave){

int indice = -1;
 for (int i = 0; i < arrayA.length; i++) {
 
 if(chave ==  arrayA[i]){
 indice = i;
 break;
 }
}	
return indice;
}