using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número:");
    float num1 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    float num2 = float.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");

    float aux = num1;
    num1 = num2
    num2 = aux

    Console.WriteLine ("Os números trocados: {0},{1}", num1,num2);
    
    }
  
}
