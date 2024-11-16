using Microsoft.AspNetCore.Mvc;
using Wallet2.Interfaces;

namespace Wallet2.Patterns
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly MyDbContext _context;

        public RepositoryFactory(MyDbContext context)
        {
            _context = context;
        }

        public MyEntityRepository CreateMyEntityRepository()
        {
            return new MyEntityRepository(_context);
        }
    }

}
