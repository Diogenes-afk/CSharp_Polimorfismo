using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Livro : Produto
    {
        public string autor { get; set; }
        public Livro(string nomeLoja, float preco, string autor) : base(nomeLoja, preco)
        {
            this.autor = autor;
            Console.WriteLine("Livro com capa dura e mais de 400 paginas");
        }

        public override string getDescricao()
        {
            return base.getDescricao() + "" + this.autor;
        }
    }
}
