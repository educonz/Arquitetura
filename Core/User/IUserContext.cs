namespace Core.User
{
    public interface IUserContext<TUserRole>
        where TUserRole : IUser, IRole
    {
        TUserRole GetUserLogged();
    }
}
