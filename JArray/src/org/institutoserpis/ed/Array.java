package org.institutoserpis.ed;

public class Array {

	public static void main(String[] args) {
		int[] v=new int[]{5,9,7,12,21};
		System.out.println("T1) Primer elemento = " + v[0]);
		System.out.println("T1) Segundo elemento = " + v[1]);
		System.out.println("T1) Tercero elemento = " + v[2]);
		System.out.println("T1) Cuarto elemento = " + v[3]);
		System.out.println("T1) Quinto elemento = " + v[4]);
		
		//Cambiamos el valor de v[0]
		v[0]=33;
		//Devolvemos el valor de v[0]
		v[0]=5;
		
		//Mostramos por pantalla con un index
		int index=0;
		System.out.println("T2) Elemento con index="+index+" vale: "+v[index]);
		index++;
		System.out.println("T2) Elemento con index="+index+" vale: "+v[index]);
		index++;
		System.out.println("T2) Elemento con index="+index+" vale: "+v[index]);
		index++;
		System.out.println("T2) Elemento con index="+index+" vale: "+v[index]);
		index++;
		System.out.println("T2) Elemento con index="+index+" vale: "+v[index]);
		
		//Esto último es lo mismo que si lo efectuamos con un bucle for
		for (int ind=0;ind <5;ind++){
			System.out.println("T3) Elemento con ind="+ind+" vale: "+v[ind]);
		}
		System.out.println("E1) Suma del array = "+suma(v)); //Llamamos al método Suma que se describe a continuación
		System.out.println("E2) Suma de otro array = "+suma(new int[]{14,24}));
		System.out.println("E3) Suma de array vacio= "+suma(new int[]{}));
		System.out.println("E4) Este es el menor valor del vector: "+menor(v)); 
		System.out.println("E5) Esta es la posición en el vector del valor: "+indexOf(v,12));
	}
	
	public static int suma(int[] v){ //devuelve la suma de los elementos del vector
		//AYUDA: Número de elementos del vector: v.length
		int sum=0;
		for(int i=0;i<v.length;i++){
			sum=sum+v[i];
		}
	//	int suma=0;
	//	for(int item:v){			//Usamos el item:v para recorrer todos los elementos del vector
	//		suma=suma+item;
	//	}
		return sum;
	}
	public static int menor(int[] v){ //Devuelve el menor valor del vector
		int min=v[0];
		for (int i=0; i<v.length; i++){
			if(v[i]<min){
				min=v[i];
			}
		}
		return min;
	}
	public static int indexOf(int[] v,int item){ //Devuelve la posición del vector donde esta el valor item 
		int index=-1;
		for(int i=0; i<v.length;i++){
			if(item==v[i]){
				index=i;
				return index;
			}
		}
		return index;
	}
	
	private static void swap(int[] v, int oneIndex, int otherIndex) {
		int aux = v[oneIndex];
		v[oneIndex] = v[otherIndex];
		v[otherIndex] = aux;
	}
	
}
