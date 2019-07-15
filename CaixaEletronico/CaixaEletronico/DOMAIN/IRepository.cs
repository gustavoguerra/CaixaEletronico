using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    interface IRepository<TEntity>
    {
        TEntity Getall();

        void Deposito(TEntity entity);

        void Saque(TEntity entity);
    }
}
