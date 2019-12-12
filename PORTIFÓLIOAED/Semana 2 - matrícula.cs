using System; 

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um número:");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num3 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num4 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num5 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num6 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num7 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    int num8 = int.Parse(Console.ReadLine());

    int soma = (num1*2) + (num2 *3) + (num3 *4) + (num4 *3) +(num5 *2) + num6 + num7 + num8;

    float resto = soma % 10;

    Console.WriteLine ("A matrícula é: {0}{1}{2}{3}{4}{5}{6}{7}-{8}", num1,num2,num3,num4,num5,num6,num7,num8,resto);

  }
}
