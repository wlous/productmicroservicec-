using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroService.Models
{
    public class Product
    {
	    public Product( int id, string productName, string productImageUrl )
	    {
		    Id = id;
		    ProductName = productName;
		    ProductImageUrl = productImageUrl;
		    LastUpdated = DateTime.Now;
	    }

	    public int Id { get; set; }
	    public string ProductName { get; set; }
	    public string ProductImageUrl { get; set; }
	    public DateTime LastUpdated { get; set; }
	}
}
