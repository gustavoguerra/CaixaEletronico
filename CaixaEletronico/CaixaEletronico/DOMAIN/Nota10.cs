using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    class Nota10
    {
        public int Valor { get; private set; }

        public Nota10(int valor)
        {
            Valor = valor;
        }
    }
}
