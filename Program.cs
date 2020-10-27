using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;   

            
             Console.ForegroundColor = ConsoleColor.DarkMagenta;
             Console.Write("= Doador de Sangue =");
             Console.ResetColor();
 
             Console.Write("\nIdade porfavor: ");
             idade = Convert.ToInt32(Console.ReadLine());
             Console.Clear();

            if (idade <= 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você não poderá doar sangue {idade} anos não permitido");
                Console.ResetColor();
                Console.WriteLine("Seja entre 18 e 67 anos");
               
            }
            if (idade >= 18 && idade <= 67)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você foi avaliado e podera doar");
                Console.ResetColor();
                Console.WriteLine("Obrigado!!!");
            }
            if (idade >= 68)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Você não poderá doar sangue {idade} anos não permitido");
                Console.ResetColor();
                Console.WriteLine("Seja entre 18 e 67 anos");
              
            }
        }
    }
}