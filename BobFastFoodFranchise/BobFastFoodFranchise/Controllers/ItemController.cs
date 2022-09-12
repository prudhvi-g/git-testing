using BobFastFoodFranchise.Core.Items;
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
    public class ItemController : ControllerBase
    {

        private readonly Iitems _context;
        public ItemController(Iitems _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult> GetItem()
        {
            try
            {
                return Ok(await _context.GetItem());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data from the Database");
            }
        }
        [HttpGet("{vegOrNonveg:string}")]
        public async Task<ActionResult<Item>> GetVegOrNonveg(string vegOrNonveg)
        {
            try
            {
                var result = await _context.GetVegOrNonveg(vegOrNonveg);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data from the Database");
            }
        }
        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Item>> UpdateItem(int id, Item item)
        {
            try
            {
                if (id != item.FastFoodShopId)
                {
                    return BadRequest("Mismatch FastFoodShopId");
                }
                var updateItem = await _context.GetItem();
                if (updateItem == null)
                {
                    return NotFound($"FastFoodShop with Id={id} not Found");
                }
                return await _context.UpdateItem(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Updating Data to the Database");
            }
        }
    }
}
