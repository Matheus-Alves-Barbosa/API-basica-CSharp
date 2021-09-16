using AulaUdemy.Data.VO;

namespace AulaUdemy.Services
{
    public interface ILoginService
    {
        TokenVO ValidateCredentials(UserVO user);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string username);
    }
}
