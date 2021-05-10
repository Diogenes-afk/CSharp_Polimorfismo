using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Mouse : Produto
    {
        public string tipo { get; set; }

        public Mouse(string nomeLoja, float preco, string tipo) : base(nomeLoja, preco)
        {
            this.tipo = tipo;
            Console.WriteLine("Mouse ótico de 20.000 dpi que custou um rim esquerdo");
        }

        public override string getDescricao()
        {
            return base.getDescricao() + "" + ;

        }
    }
}
