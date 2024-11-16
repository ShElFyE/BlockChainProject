using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wallet2.Services
{
    public class MyEntityService : IMyEntityService
    {
        private readonly IRepository<MyEntity> _repository;

        public MyEntityService(IRepository<MyEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MyEntity>> GetAllEntitiesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<MyEntity> GetEntityByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task CreateEntityAsync(MyEntity entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateEntityAsync(MyEntity entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteEntityAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
