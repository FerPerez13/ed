package org.institutoserpis.ed;

import static org.junit.Assert.*;

import org.junit.Test;

public class ArrayTest {

	@Test 
	public void menor() {
		assertEquals(3,Array.menor(new int[]{5,9,3,14}));
		assertEquals(5,Array.menor(new int[]{5,9,6,14}));
		assertEquals(7,Array.menor(new int[]{9,8,12,7}));
	}

	@Test
	public void indexOf(){
		assertEquals(0,Array.indexOf(new int[]{5,9,3,14},5));
		assertEquals(1,Array.indexOf(new int[]{5,9,3,14},9));
		assertEquals(2,Array.indexOf(new int[]{5,9,3,14},3));
		assertEquals(3,Array.indexOf(new int[]{5,9,3,14},14));
		
		//int[] v ={5,9,3,14};
		//for(int i=0;i<4;i++){						//Tambien podemos hacerlo así
		//	assertEquals(i,Array.indexOf(v,v[i]));
		//}
	}

	@Test
	public void indexOfvacio(){
		assertEquals(-1,Array.indexOf(new int[]{},55));
	}
}
