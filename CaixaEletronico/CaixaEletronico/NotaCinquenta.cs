using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class NotaCinquenta : Movimentacao
    {
        public int saldo()
        {
            return Valor * 50;
        }

    }
}
