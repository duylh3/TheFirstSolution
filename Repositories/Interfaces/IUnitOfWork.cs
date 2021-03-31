using AppData;

namespace Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<UserInfo> UserInfoRepository { get; }

        void Commit(bool? validateOnSaveEnabled = null);
    }
}
