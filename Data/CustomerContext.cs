using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDApi.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options){


        }

        public DbSet<CustomerDto> Customer {get; set; }
        
    }
}