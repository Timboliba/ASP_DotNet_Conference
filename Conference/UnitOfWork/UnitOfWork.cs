using Conference.Interfaces;
using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference.Repository
{
    public class UnitOfWork<T>: IUnitOfWork<T> where T:class
    {
        private readonly DataEntities db;
        private IGenericRepository<T> _entity;


        public UnitOfWork()
        {
            this.db = new DataEntities();
        }

        public UnitOfWork(DataEntities db)
        {
            this.db = new DataEntities();
        }

        

        public IGenericRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(db));
            }
        }

        public IGenericRepository<T> Entities => throw new NotImplementedException();

        public void Save()
        {
            db.SaveChanges();
        }
    }
}