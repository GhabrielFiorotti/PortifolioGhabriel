using System;

class Robo{
  private string nome;  

  private static string mensagem_geral;
  private static ConsoleColor cor = ConsoleColor.White;


  public void Mensagem(){
    Console.ForegroundColor = cor; 
    Console.WriteLine("[{0}]:{1}",nome, mensagem_geral);
    Console.ForegroundColor = ConsoleColor.White; 
  }

  
  public static void Msg(){
    Console.WriteLine(mensagem_geral);
  }

  public static void NovaMensagem(string msg){
    mensagem_geral = msg;
  }
  
  public void setCor(ConsoleColor c){
    cor = c;
  }

  public Robo(string n){
    nome = n;
  }
}