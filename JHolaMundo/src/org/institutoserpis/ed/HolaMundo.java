package org.institutoserpis.ed;

import java.util.Scanner;

public class HolaMundo {

	public static void main(String[] args) {
		Scanner tcl = new Scanner(System.in);
		System.out.print("Introduce tu nombre: ");
		String nom = tcl.nextLine();
		System.out.printf("Hola %s desde eclipse!", nom);
	}
}
