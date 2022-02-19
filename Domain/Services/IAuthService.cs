namespace StretchCeilings.Domain.Services
{
    public interface IAuthService
    {
        bool Login(string login, string password);
    }
}