using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    class NotaVinte : Movimentacao
    {
        public int saldo()
        {
            return Valor * 20;
        }
    }
}
