using AutoMapper;
using finapp.Api.ViewModel;
using finapp.Business.Interfaces;
using finapp.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace finapp.Api.Controllers
{

    //[Authorize]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost("new-account")]
        public async Task<ActionResult<AccountViewModel>> AddAccount([FromBody]AccountViewModel accountViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _accountService.Add(_mapper.Map<Account>(accountViewModel));

            return Ok(accountViewModel);
        }

    }

}