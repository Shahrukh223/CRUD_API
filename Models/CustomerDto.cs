using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDApi.Models
{
    public class CustomerDto
    
    {   
        [Key]
        public int InvoiceID { get; set; }

        public string FullName { get; set; }


    }

}