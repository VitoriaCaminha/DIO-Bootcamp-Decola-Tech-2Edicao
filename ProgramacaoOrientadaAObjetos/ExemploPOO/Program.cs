using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
  class Program
  {
    static void Main(string[] args)
    {
      ICalculadora calc2 = new Calculadora();
      System.Console.WriteLine(calc2.Somar(10, 20));



      Computador comp = new Computador();
      System.Console.WriteLine(comp.ToString());



      Corrente c = new Corrente();
      c.Creditar(100);

      c.ExibirSaldo();



      Calculadora calc = new Calculadora();
      System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
      System.Console.WriteLine("Resultado da Segunda soma: " + calc.Somar(10, 10, 10));



      Aluno p1 = new Aluno();
      p1.Nome = "Vitoria";
      p1.Idade = 23;
      p1.Documento = "123456";
      p1.Nota = 10;
      p1.Apresentar();

      Professor p2 = new Professor();
      p2.Nome = "Vitoria";
      p2.Idade = 23;
      p2.Documento = "123456";
      p2.Salario = 2000;
      p2.Apresentar();



      Professor p3 = new Professor();

      p3.Nome = "Vitoria";
      p3.Idade = 23;

      p3.Apresentar();

      Aluno p4 = new Aluno();
      p4.Nome = "Vitoria";
      p4.Idade = 23;

      p4.Apresentar();



      //valores validos
      Retangulo r = new Retangulo();
      r.DefinirMedidas(30, 30);

      System.Console.WriteLine($"Área: {r.ObterArea()}");

      //valores invalidos
      Retangulo r2 = new Retangulo();
      r.DefinirMedidas(0, 30);

      System.Console.WriteLine($"Área: {r2.ObterArea()}");



      Pessoa p5 = new Pessoa();

      p5.Nome = "Vitoria";
      p5.Idade = 23;

      p5.Apresentar();
    }
  }
}