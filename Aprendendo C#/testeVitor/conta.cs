
using System;

public class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Teste t = new Teste();

        Console.WriteLine("Digite um número: ");

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");

        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(t.somar(a, b));
        
    }
    class Teste
{
   public int somar(int a, int b)
   {
      return a + b;
   }
    
}
}