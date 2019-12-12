using System;

class MainClass {
  public static void Main (string[] args) {
    Bola bola = new Bola("Vermelha","Ferro");
    Console.Clear();
    Console.WriteLine("A cor e o material são:");
    Console.WriteLine(bola.getCor());
    Console.WriteLine(bola.getMaterial());

    bola.setCor("Azul");
    Console.WriteLine("\nA cor nova é:");
    Console.WriteLine(bola.getCor());
  }
}