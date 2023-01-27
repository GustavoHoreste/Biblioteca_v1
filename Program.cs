using System;
using LibraryClass;

namespace Biblioteca_v1;
class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Biblioteca MinhaBiblioteca = new Biblioteca();

    MinhaBiblioteca.Titulo = "Revolução dos Bichos";
    MinhaBiblioteca.Autor = "George Orwel";
    MinhaBiblioteca.Paginas = 189;
    MinhaBiblioteca.Status = true;

    Console.WriteLine("Titulo da obra[construtor explicito]: " + MinhaBiblioteca.Titulo);
    Console.WriteLine("Autor da obra[construtor explicito]: " + MinhaBiblioteca.Autor);
    Console.WriteLine("Paginas da obra[construtor explicito]: " + MinhaBiblioteca.Paginas);
    Console.WriteLine("Status da obra[construtor explicito]: " + MinhaBiblioteca.Status);
    Console.WriteLine();

    Biblioteca MeusLivros = new Biblioteca("George Orwel", "1985", 342, false);

    Console.WriteLine("Titulo da obra[construtor Implicito]: " + MeusLivros.Titulo);
    Console.WriteLine("Autor da obra[construtor Implicito]: " + MeusLivros.Autor);
    Console.WriteLine("Paginas da obra[construtor Implicito]: " + MeusLivros.Paginas);
    Console.WriteLine("Status da obra[construtor Implicito]: " + MeusLivros.Status);
    Console.WriteLine();

    Revistas MinhaRevista = new Revistas(2023, 08);
    MinhaRevista.Titulo = "Clean code";
    MinhaRevista.Autor = "Gustavo Horestee";
    MinhaRevista.Paginas = 245;
    MinhaRevista.Status = true;

    Console.WriteLine("Titulo: " + MinhaRevista.Titulo);
    Console.WriteLine("Autor: " + MinhaRevista.Autor);
    Console.WriteLine("Paginas: " + MinhaRevista.Paginas);
    Console.WriteLine("Status: " + MinhaRevista.Status);
    Console.WriteLine("AnoPublicacao: " + MinhaRevista.AnoPublicacao);
    Console.WriteLine("MesPublicacao: " + MinhaRevista.MesPublicacao);
  }
}
