using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Digite o primeiro número");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número");
    int num2 = int.Parse(Console.ReadLine());

    try{
      Console.WriteLine("Divisão:{0}", num1 / num2);
    }
    catch (DivideByZeroException){
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Não é possível dividir por zero");
        
    }     
  }
}