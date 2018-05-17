using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMicroService.Models;


namespace ProductMicroService.Database
{
    public class ProductContext : DbContext
    {
	    public DbSet<Product> Product { get; set; }
    }
}
