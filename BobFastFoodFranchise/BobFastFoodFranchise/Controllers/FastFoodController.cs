using BobFastFoodFranchise.Core.FastFoodShop;
using BobFastFoodFranchise.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FastFoodController : ControllerBase
    {

        private readonly IFastFoodshop _context;
        public FastFoodController(IFastFoodshop _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult> GetFastFoodShop()
        {
            try
            {
                return Ok(await _context.GetFastFoodShop());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data from the Database");
            }
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<FastFoodShops>> AddFastFoodShop(FastFoodShops fastFoodShops)
        {
            try
            {
                if (fastFoodShops == null)
                {
                    return BadRequest();
                }
                var addFastFoodShop = await _context.AddFastFoodShop(fastFoodShops);
                return CreatedAtAction(nameof(AddFastFoodShop), new { id = addFastFoodShop.FastFoodShopId }, addFastFoodShop);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Adding Data to the Database");
            }
        }
    }
}
