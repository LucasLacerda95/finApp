using finapp.Api.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace finapp.Api.Controllers
{


    [Route("api")]
    public class AuthController : ControllerBase{

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
 
        [HttpPost("new-account")]
        public async Task<ActionResult> Register([FromBody]RegisterUserViewModel registerUser){
            
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var user = new IdentityUser{
                UserName = registerUser.Email,
                Email = registerUser.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, registerUser.Password);

            if(result.Succeeded){
                
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok(registerUser);
            }

            foreach(var error in result.Errors){
                BadRequest(error.Description);
            }
            
            return BadRequest($"Suceeded: {result.Succeeded}");
        }


        [HttpPost("sign-in")]
        public async Task<ActionResult> Login([FromBody]LoginUserViewModel loginUser){

            if(!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _signInManager.PasswordSignInAsync(loginUser.Email, loginUser.Password, isPersistent: false, lockoutOnFailure: true);

            if(result.Succeeded){
                return Ok($"Usuário Logado: {result.Succeeded}");
            }
            if(result.IsLockedOut){
                return BadRequest("Usuário temporariamente bloqueado por tentativas inválidas");
            }


            return BadRequest($"Usuário ou Senha inválidos - Usuário Logado: {result.Succeeded}");
        }

   

    }
}