using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Wallet2.Services
{
    public interface IMyEntityService
    {
        Task<IEnumerable<MyEntity>> GetAllEntitiesAsync();
        Task<MyEntity> GetEntityByIdAsync(int id);
        Task CreateEntityAsync(MyEntity entity);
        Task UpdateEntityAsync(MyEntity entity);
        Task DeleteEntityAsync(int id);
    }

}
