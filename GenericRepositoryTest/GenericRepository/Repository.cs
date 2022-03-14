﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GenericRepositoryTest.GenericRepository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        DbContext _context;
        DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Commit();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            Commit();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects =_dbSet.Where(where).AsEnumerable();
            foreach (T obj in objects)
                _dbSet.Remove(obj);
            Commit();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Commit();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).AsEnumerable();
        }
        public T FirstOrDefault(Expression<Func<T, bool>> where)

        {
            return _dbSet.FirstOrDefault(where);
        }
        public T LastOrDefault(Expression<Func<T, bool>> where)

        {
            return _dbSet.LastOrDefault(where);
        }
        public bool Any(Expression<Func<T, bool>> where)
        {
            return _dbSet.Any(where);
        }
        public T First(Expression<Func<T, bool>> where)
        {
            return _dbSet.First(where);
        }
        public T Last(Expression<Func<T, bool>> where)
        {
            return _dbSet.Last(where);
        }
        public bool IsExist(Expression<Func<T, bool>> where)
        {
            var count = _dbSet.Count(where);
            return count > 0;
        }

        public string Max(Expression<Func<T, string>> where)
        {
            return _dbSet.AsNoTracking().Max(where);
        }

        public string Min(Expression<Func<T, string>> where)
        {
            return _dbSet.AsNoTracking().Min(where);
        }

        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            await CommitAsync();

        }

        public async  Task UpdateAsync(T entity)
        {
             _context.Entry(entity).State = EntityState.Modified;
            await CommitAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await CommitAsync();
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _dbSet.Where(where).AsEnumerable();
            foreach (T obj in objects)
                _dbSet.Remove(obj);
           await CommitAsync();

        }
        public void AddMultiple(IEnumerable<T> list)
        {
            _context.Set<T>().AddRange(list);
            Commit();
        }

        public void DeleteMultiple(IEnumerable<T> list)
        {
            _context.Set<T>().RemoveRange(list);
            Commit();
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return _context.Database.ExecuteSqlRaw(sqlCommand, parameters);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
           
        }
        public  void Commit()
        {
             _context.SaveChanges();
        }




    }
}
