using System;
using System.Linq;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Project();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        static void Project()
        {   
            List<User>Pessoas = new List<User>();

            List<Type>Tipos = new List<Type>();

            Pessoas.Add(new User(1, "Pessoa", 1));

            Pessoas.Add(new User(2, "Pessoa2", 1));

            Tipos.Add(new Type(1, "Pessoas Física"));

            Key.Restrition(Pessoas, Tipos);

            // Teste

            Calculos.Operacao();
        }
    }
}
