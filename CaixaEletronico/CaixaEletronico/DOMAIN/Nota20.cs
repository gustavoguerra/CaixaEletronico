using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    class Nota20
    {
        public int Valor { get; private set; }

        public Nota20(int valor)
        {
            Valor = valor;
        }
    }
}
