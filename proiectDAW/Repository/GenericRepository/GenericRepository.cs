using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using proiectDAW.Data;
using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Context _context;
        protected readonly DbSet<TEntity> _table;
        private ContextBoundObject context;

        //injectam o instanta de context
        public GenericRepository(Context context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public GenericRepository(ContextBoundObject context)
        {
            this.context = context;
        }

        //Get all
        public async Task<List<TEntity>> GetAll()
        {
            //cand avem async trb sa punem mereu await
            //daca vrem doar sa luam datele fara sa facem modificari punem AsNoTracking
            return await _table.AsNoTracking().ToListAsync();
        }
        public IQueryable<TEntity> GetAllAsQueryable()
        {
            return _table.AsNoTracking();
        }

        //Create
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        //Update
        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        //Delete
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        //Find
        public TEntity FindById(object id)
        {
            return _table.Find(id);
        }

        public async Task<TEntity> FindByIdAsync (object id)
        {
            return await _table.FindAsync(id);
        } 

        //Salvare
        public async Task<bool> Save()
        {
            try
            {
                return await _context.SaveChangesAsync() > 0;

            } catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }

        bool IGenericRepository<TEntity>.Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
