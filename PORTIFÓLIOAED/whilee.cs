using System;

class MainClass {
  public static void Main (string[] args) {
    int numero = 0;
    Console.WriteLine ("Digite um número:");
    numero = int.Parse(Console.ReadLine());

    while (numero>0){
      Console.WriteLine ("Vou subtrair 2 do número escolhido");

      numero = numero -2;

      Console.WriteLine ("O número agora é:{0}", numero);

    }

  }
}