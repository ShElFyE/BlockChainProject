using Microsoft.AspNetCore.Mvc;

namespace Wallet2.Interfaces
{
    public interface IRepositoryFactory
    {
        MyEntityRepository CreateMyEntityRepository();
    }
}
