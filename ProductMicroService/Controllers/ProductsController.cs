using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductMicroService.Database;
using ProductMicroService.Models;

namespace ProductMicroService.Controllers
{
	[Route( "api/[controller]" )]
	public class ProductsController : Controller
	{
		private readonly IProductRepository _productRepo;
	    public ProductsController(IProductRepository productRepo)
	    {
		    _productRepo = productRepo;
	    }

	    // GET api/products
	    [HttpGet]
	    public IEnumerable<Product> Get()
	    {
		    try
		    {
			    var products = _productRepo.GetProducts();
			    return products;
		    }
		    catch (Exception e)
		    {
			    Console.WriteLine(e);
			    throw;
		    }
		}

	    // GET api/products/5
	    [HttpGet( "{id}" )]
	    public Product Get( int id )
	    {
			try
			{
				var product = _productRepo.GetProductById( id );

				return product;
			}
			catch( Exception e )
			{
				Console.WriteLine( e );
				throw;
			}
		}
	}
}