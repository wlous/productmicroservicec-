using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroService.Models;

namespace ProductMicroService.Database
{
    public class ProductRepository : IProductRepository
    {
	    public IEnumerable<Product> GetProducts()
	    {
			using( var dbContext = new ProductContext() )
			{
				return dbContext.Product.ToList();
			}

			//var products = new List<Product>();
			//products.Add( new Product( 1, "Google Pixel", "http://www.pixelbild.com" ) );
			//return products;
		}

	    public Product GetProductById( int id )
	    {
		    var product = new Product( 1, "iPhön", "http://www.iphune.com" );
		    return product;
	    }
	}
}
