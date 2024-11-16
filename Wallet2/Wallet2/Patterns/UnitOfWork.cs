using Wallet2.Interfaces;

namespace Wallet2.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;
        private IRepository<MyEntity> _myEntityRepository;

        public UnitOfWork(MyDbContext context)
        {
            _context = context;
        }

        public IRepository<MyEntity> MyEntityRepository
            => _myEntityRepository ??= new MyEntityRepository(_context);

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
