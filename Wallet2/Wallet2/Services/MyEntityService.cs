using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wallet2.Interfaces;

namespace Wallet2.Services
{
    public class MyEntityService : IMyEntityService
    {
        private readonly IRepository<MyEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryFactory _repositoryFactory;
        public MyEntityService(IRepository<MyEntity> repository, IUnitOfWork unitOfWork, IRepositoryFactory repositoryFactory)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _repositoryFactory = repositoryFactory;
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
            await _unitOfWork.MyEntityRepository.AddAsync(entity);
            await _unitOfWork.CompleteAsync();

            var repository = _repositoryFactory.CreateMyEntityRepository();
            await repository.AddAsync(entity);
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
