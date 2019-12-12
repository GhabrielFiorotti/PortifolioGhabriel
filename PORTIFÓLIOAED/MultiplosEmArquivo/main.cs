using System;
using System.IO;
using System.Text;

class Programa{

  public static void Main(string[] args){
    FileStream arquivo = new FileStream("numero.txt", FileMode.Open, FileAccess.Read);
    StreamReader procura = new StreamReader(arquivo, Encoding.UTF8);
    
    const int qLinhas = 2, qColunas=5;
    int[,] matriz = new int[qLinhas, qColunas];
    
    for(int i=0;i<qLinhas; i++){
      for(int j=0;j<qColunas; j++){
         matriz[i, j] = int.Parse( procura.ReadLine() );       
      }
    }
    
    for(int i=0;i<qLinhas; i++){
      for(int j=0;j<qColunas; j++){
         if( matriz[i,j]%3==0  || matriz[i,j]%5==0)
            Console.Write("{0}, ", matriz[i, j]);      
      }
    }
    procura.Close();
    arquivo.Close();
  }
}