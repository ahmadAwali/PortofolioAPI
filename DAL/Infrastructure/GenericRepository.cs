using Microsoft.EntityFrameworkCore;
using MODELS.PortoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Infrastructure
{
    public class GenericRepository<Type> where Type : BaseModel
    {
        #region Attributes

        private readonly PortContext _dbContext;
        private DbSet<Type> Entity;

        #endregion Attributes

        public GenericRepository(PortContext Context)
        {
            _dbContext = Context;
            Entity = _dbContext.Set<Type>();
        }

        #region Methods

        public void Insert(Type entity)
        {
            try
            {
                Entity.Add(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Update(Type entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }

        public void Delete(Type entity)
        {
            try
            {
                Entity.Remove(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(int Id)
        {
            try
            {
                Entity.Remove(Read(Id));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Type Read(int Id)
        {
            try
            {
                Type entity = Entity.Find(Id);
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Type> Read()
        {
            try
            {
                return Entity.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int GetLength()
        {
            return Entity.Count();
        }


        #endregion Methods
    }
}
