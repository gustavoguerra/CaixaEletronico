using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public interface IMovimentacao
    {
        void Saque(int saque);

        void Deposito(int deposito);
    }
}
