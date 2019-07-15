using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class NotaDez : Movimentacao
    {
        public int saldo()
        {
            return Valor * 10;
        }
    }
}
