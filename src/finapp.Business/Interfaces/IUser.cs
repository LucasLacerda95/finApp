using System.Security.Claims;

namespace finapp.Business.Interfaces{


    public interface IUser{

        string Name { get; }
        Guid GetUserId();
        string GeUserEmail();
        bool IsAuthenticated();
        bool IsInRole(string role);
        IEnumerable<Claim> GetClaimsIdentity();
    }
}