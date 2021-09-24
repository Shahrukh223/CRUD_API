using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApi.Data;
using CRUDApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CRUDApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrudController : ControllerBase
    {
        private readonly CustomerContext _context;

        public CrudController(CustomerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAllCustomer(){

            return await _context.Customer.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id){

            var customer = await _context.Customer.FindAsync(id);

            if(customer == null){

                return NotFound();

            }

            return customer;

        }

         [HttpPost]
        public async Task<ActionResult<CustomerDto>> PostCustomer([FromBody]CustomerDto customer)
        {
            
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new {id=customer.InvoiceID}, customer);
        }
        
        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerDto>> DeleteCustomer(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.InvoiceID == id);
        }
    }
}