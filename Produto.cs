using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Produto
    {
        protected string nomeLoja { get; set; }

        protected float preco { get; set; }

        protected string descricao { get; set; }


        public  Produto(string nomeLoja, float preco) {  // Construtor padrão da classe
            this.nomeLoja = nomeLoja;
            this.preco = preco;
        }

        public virtual string getDescricao() // metodo descrição
        {
            return "Descrição do Produto: ";
        }
    }
}
