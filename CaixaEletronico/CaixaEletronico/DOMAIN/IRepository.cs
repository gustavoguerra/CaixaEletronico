using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    interface IRepository<TEntity>
    {
        TEntity GetByQuantTipo(int tipo);

        IEnumerable<TEntity> GetAll();

        void Deposito(TEntity entity);

        void Saque(TEntity entity);
    }
}
