using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wallet2
{

    public class MyEntityRepository : IRepository<MyEntity>
    {
        private readonly MyDbContext _context;

        public MyEntityRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MyEntity>> GetAllAsync()
        {
            return await _context.MyEntities.ToListAsync();
        }

        public async Task<MyEntity> GetByIdAsync(int id)
        {
            return await _context.MyEntities.FindAsync(id);
        }

        public async Task AddAsync(MyEntity entity)
        {
            await _context.MyEntities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(MyEntity entity)
        {
            _context.MyEntities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.MyEntities.FindAsync(id);
            if (entity != null)
            {
                _context.MyEntities.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }

}
