using EjempliApi.Entities;
using System.Data;

namespace EjempliApi.Infrastructure.Persistence.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Persona> Persona { get; }
        void SaveChanges();
        Task SaveChangesAsync();
        IDbTransaction BeginTransaction();
    }
}
