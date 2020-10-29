using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;   

            
             Console.ForegroundColor = ConsoleColor.DarkMagenta;
             Console.Write("= Doador de Sangue =");
             Console.ResetColor();
 
             Console.Write("\nIdade porfavor: ");
             idade = Convert.ToInt32(Console.ReadLine());
             Console.Clear();
  
            if (idade >= 18 && idade <= 67)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Está apto a dor sangue! :D");
                Console.ResetColor();
                Console.WriteLine("Obrigado, por salvar vidas :D !!! ");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você não poderá doar sangue, {idade} anos não é permitido.");
                Console.ResetColor();
                Console.WriteLine("Seja entre 18 e 67 anos");              
            }
        }
    }
}