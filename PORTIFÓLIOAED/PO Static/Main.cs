using System;

class MainClass {
  public static void Main (string[] args) {
    //Criação de objetos do tipo Robo:
    Robo robo1 = new Robo("r4");
    Robo robo2 = new Robo("r9");

    Robo.NovaMensagem("Somos todos iguais!");
    robo1.setCor(ConsoleColor.Green);

    robo1.Mensagem();
    robo2.Mensagem();
    robo2.setCor(ConsoleColor.Red);

    Robo.NovaMensagem("Vamos dominar o mundo, babacas !!!");
    Robo.Msg();

  }
}