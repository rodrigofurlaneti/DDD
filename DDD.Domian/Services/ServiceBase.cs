using System;
using System.Collections.Generic;
using DDD.Domian.Interfaces;
using DDD.Domian.Interfaces.Services;
namespace DDD.Domian.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        //Injeção de dependencia, injetar a classe concreta
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}