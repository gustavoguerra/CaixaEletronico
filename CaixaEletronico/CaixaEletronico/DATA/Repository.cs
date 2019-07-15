using CaixaEletronico.DOMAIN;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DATA
{
    class Repository<TEntity> : IRepository<TEntity>
    {
        protected TEntity Valor { get; set; }

        public void Deposito(TEntity entity)
        {
            Valor = entity;
        }

        public TEntity Getall()
        {
            return Valor;
        }

        public void Saque(TEntity entity)
        {
            Valor = entity;
        }
    }
}
