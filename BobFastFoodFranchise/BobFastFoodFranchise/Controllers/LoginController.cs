using BobFastFoodFranchise.DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        BobFastFoodFranchiseDbContext obj = null;
        public LoginController(BobFastFoodFranchiseDbContext _obj)
        {
            obj = _obj;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(string Username, string password)
        {
            try
            {
                var userList = obj.login.Where(i => i.Username == Username && i.Password == password).FirstOrDefault();
                if (userList == null)
                {
                    return BadRequest("Invalid credentials");
                }
                var claims = new List<Claim> { new Claim(type: ClaimTypes.Name, value: Username), new Claim(type: ClaimTypes.Name, value: password) };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));
                return Ok("Sign in successfull");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }
}
