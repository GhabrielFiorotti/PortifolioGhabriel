using System;

class MainClass {
  public static void Main (string[] args) {

  float cont = 0;
  float soma = 0;

  while (cont <=9){
    Console.WriteLine ("Digite um valor: ");
    float n = float.Parse(Console.ReadLine());

    soma += n;
    cont++;

    }

    Console.WriteLine ("A soma é: {0}, e a média é: {1}", soma, soma/cont);
  }
}