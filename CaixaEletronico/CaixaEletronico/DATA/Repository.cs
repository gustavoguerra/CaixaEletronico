using CaixaEletronico.DOMAIN;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CaixaEletronico.DATA
{
    class Repository<TEntity> : IRepository<TEntity>
    {
        //Retira notas da conta
        public void Saque(TEntity entity)
        {
            throw new NotImplementedException();
        }

        // Coloca notas na conta
        public void Deposito(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetByQuantTipo(int tipo)
        {
            throw new NotImplementedException();
        }

    }
}
