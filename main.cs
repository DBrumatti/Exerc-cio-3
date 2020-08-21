using System;

class MainClass {
  public static void Main (string[] args) {
    int Numero01, Numero02, Soma;    
           
    Console.Write("Digite o primeiro número:  ");
    Numero01 = int.Parse(Console.ReadLine());
    
    Console.Write("Digite o segundo número:  ");
    Numero02 = int.Parse(Console.ReadLine());
    
    
    Soma = Numero01 + Numero02;
    
    Console.WriteLine ("O resultado é:  " + Soma);
           
  }
}