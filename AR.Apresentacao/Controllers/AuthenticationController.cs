using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using Microsoft.Extensions.Configuration;
using AR.Presentetion.Services;
using AR.Presentetion.Resources;
using AR.Presentetion.Util;
using AR.Presentetion.Extensions;
using AR.Presentetion.Domain.Models;

namespace AR.Presentetion.Controllers
{
    [Route("/api/[controller]")]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthenticationController(IUserService userService, IMapper mapper, IConfiguration configuration)
        {
            _userService = userService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> VerifyLogin([FromBody] AuthUserResource resource)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.GetErrorMessages());

                var user = _mapper.Map<AuthUserResource, User>(resource);
                var result = await _userService.FirstOrDefaultAsync(user.Login, user.Password);

                if (result == null)
                    return BadRequest("Erro ao tentar realizar o login.");

                var token = CryptoFunctions.GenerateToken(_configuration, user);

                return Ok(new
                {
                    error = false,
                    result = new
                    {
                        token,
                        user = new { user.Id, user.Login }
                    }
                });

            }

            catch (Exception ex)
            {
                var message = "Erro ao tentar realizar o login.";
                return BadRequest(new { error = true, result = new { message } });
            }

        }

    }
}
