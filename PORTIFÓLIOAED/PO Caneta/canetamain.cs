using System;

class MainClass {
  static void Main (string[] args) {
    Caneta joyce = new Caneta("Azul","bic", 90f);
    Caneta pamela = new Caneta("Azul","bic", 50f);
   
    Console.WriteLine(joyce.resumoDados());
    Console.WriteLine(pamela.resumoDados());

    joyce.transferirCarga(pamela, 10);

    Console.WriteLine("Transferindo...");
    Console.WriteLine(joyce.resumoDados());
    Console.WriteLine(pamela.resumoDados());

  }
}