using System;
using Primeiro;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
     
     class Program
     {
         
         static void Main(string[] args)
         {
           var pessoa = (Pessoas)0;
           Pessoas pessoas2 = Pessoa.Pedro;
           Pessoas pessoa3 = (Pessoas)4;

           Pessoa person = new Pessoa();

           person.Nome = "Vitoria";
           person.Idade = 23;
           person.Estado = "PE";

           var person2 = new Pessoa();

           person2.Nome = "Amanda";
           person2.Idade = 19;
           person2.Estado = "RJ";

           Animal animal = new Animal();

           animal.Nome = "Jujuba";
           animal.NomeDono = "Vitoria";
           animal.Especie = "Gato";

           var classe = new Classe();
           var classe2 = new Segundo.Classe();

           Console.WriteLine("Hello Word!");
         }
     }
}