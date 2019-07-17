using CaixaEletronico.DOMAIN;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CaixaEletronico.DATA
{
    class Repository<TEntity> : IRepository<TEntity>
    {
        private List<TEntity> Caixa;

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

        public void Saque(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
