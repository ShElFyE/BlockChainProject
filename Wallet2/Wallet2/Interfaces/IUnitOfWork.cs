using Microsoft.AspNetCore.Mvc;

namespace Wallet2.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<MyEntity> MyEntityRepository { get; }
        Task<int> CompleteAsync();
    }
}
