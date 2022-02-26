namespace StretchCeilings.Domain.Services
{
    /// <summary>
    /// Represents a services for authorization
    /// </summary>
    public interface IAuthService
    {
        
        /// <summary>
        /// Tries to authorize a user
        /// </summary>
        /// <param name="login">user name</param>
        /// <param name="password">user password</param>
        /// <returns>
        /// <see langword="true"/> if a user with the same username
        /// and password exists in the database;
        /// otherwise <see langword="false"/>
        /// </returns>
        bool Login(string login, string password);
    }
}