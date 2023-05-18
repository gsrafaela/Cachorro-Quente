using System;

public class Program 
{

  public static void Main(string[] args) 
  {
    string[] entrada = Console.ReadLine().Split();
    int participantes = int.Parse(entrada[0]);
    int cachorrosQuentes = int.Parse(entrada[1]);

    double media = (double) cachorrosQuentes / participantes;
    
    Console.WriteLine($"{media:F2}");
  }
}

