using EjempliApi.Entities;
using EjempliApi.Infrastructure.Context;
using EjempliApi.Infrastructure.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace EjempliApi.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbaeroClubContext _context;

        public IGenericRepository<Persona> _persona = null!;

        public UnitOfWork(DbaeroClubContext context)
        {
            _context = context;
        }

        public IGenericRepository<Persona> Persona => _persona ?? new GenericRepository<Persona>(_context);

        public IDbTransaction BeginTransaction()
        {
            var transaction = _context.Database.BeginTransaction();
            return transaction.GetDbTransaction();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
