using finapp.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace finapp.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        public readonly IUser AppUser;

        protected Guid UsuarioId { get; set; }
        protected bool UsuarioAutenticado { get; set; }

        protected MainController(IUser appUser)
        {
            
            AppUser = appUser;

            if (appUser.IsAuthenticated())
            {
                UsuarioId = appUser.GetUserId();
                UsuarioAutenticado = true;
            }
        }

    }
}
