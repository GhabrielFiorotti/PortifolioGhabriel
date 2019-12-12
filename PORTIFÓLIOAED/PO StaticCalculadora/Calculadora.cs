using System;

class Calculadora{
  private static int numero1;  
  private static int numero2;
  

	public Calculadora(){
		numero1 = 1;
    numero2 = 2;

	}
  public Calculadora(int valor1, int valor2){
		numero1 = valor1;
    numero2 = valor2;
	}

  public static void Calcular(){
    Console.WriteLine(numero1 + numero2);
  }
}