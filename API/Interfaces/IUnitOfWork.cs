namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get;}
        ILikesRepository LikesRepository {get;}
        Task<bool> Complete();
        bool HasChanges();
    }
}