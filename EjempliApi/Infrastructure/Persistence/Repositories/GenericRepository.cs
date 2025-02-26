using EjempliApi.Entities;
using EjempliApi.Infrastructure.Context;
using EjempliApi.Infrastructure.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EjempliApi.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly DbaeroClubContext _context;
        private readonly DbSet<T> _entity;

        public GenericRepository(DbaeroClubContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }
        public async Task<bool> EditAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllQueryble()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetEntityQuery(Expression<Func<T, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetSelectAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegisterAsync(T entity)
        {
            entity.FechaIngreso = DateTime.Now;

            await _context.AddAsync(entity);

            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
