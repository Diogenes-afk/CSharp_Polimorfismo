using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse("Sumarino.com", 360.00f, "Ótico");

            Mouse mouse2 = new Mouse("Submarino.com", 100.00f, "Bolinha");

            Mouse mouse3 = new Mouse("Submarino.com", 40.00f, "Plastico");

            Livro livro = new Livro("Ebook.com", 55.00f, "Grillo, Matheus");

            Livro livro2 = new Livro("Ebook.com", 15.00f, "Grillo, Matheus");

            Livro livro3 = new Livro("Ebook.com", 20.00f, "Grillo, Matheus");



            List<Produto> lista = new List<Produto>();

                lista.Add(mouse);
                lista.Add(livro);


                
                lista.Add(mouse2);
                lista.Add(livro2);


                lista.Add(mouse3);
                lista.Add(livro3);

            foreach (var produto in lista)
            {
                Console.WriteLine(produto.getDescricao());
            }

        }
    }
}
