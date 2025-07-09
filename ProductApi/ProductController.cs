using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// [ApiController]: Makes the controller ready to handle web API requests. 
// Automatically validates model inputs and returns 400 errors if the model is invalid.
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase {

    // base path is created like : api/product
    // [Route("api/[controller]")]: The URL route is based on the controller name (ProductController becomes api/product).

    // ControllerBase: This base class gives access to common API features like Ok(), NotFound(), CreatedAtAction() without adding views.

    private readonly ProductDbContext _context;

    // Injects the ProductDbContext (your EF Core database context).

    // Lets you access the database inside controller methods via _context.

    public ProductController(ProductDbContext context){
        this._context = context;
    }

    // Returns all products from the Products table.

    // ToListAsync() fetches data asynchronously.

    // The return type is a list of Product objects wrapped in an HTTP 200 response.

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts(){
        return await _context.product.ToListAsync();
    }

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<Product>>> GetProductsAll(){
        return await _context.product.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductUsingId(int id){

        var product = await _context.product.FindAsync(id);
        if(product == null) return NotFound();
        return product;
    }
    [HttpPost]
    public async Task<ActionResult<Product>> SaveProduct(Product product){
         _context.product.Add(product);
         await _context.SaveChangesAsync();
         return CreatedAtAction(nameof(GetProductUsingId), new {id = product.id},product);
    }
    [HttpPut("{id}")]
    public async Task<ActionResult<Product>> updateProduct(int id, Product ChangedProduct){

        var prod = await _context.product.FindAsync(id);
        if(prod == null) return NotFound();

        prod.name= ChangedProduct.name;
        prod.price = ChangedProduct.price;

        await _context.SaveChangesAsync();

    return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Product>> DeleteProduct(int id){
        var prod = await _context.product.FindAsync(id);
        if(prod == null) return NotFound();

         _context.product.Remove(prod);
        await _context.SaveChangesAsync();
        return NoContent();


    }


}