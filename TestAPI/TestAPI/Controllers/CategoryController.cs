using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestAPI.DataModel;
using TestAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly EcommerceDbContext _ecommerceDbContext;
        private readonly IMapper _mapper;
        public CategoryController(EcommerceDbContext ecommerceDbContext, IMapper mapper)
        {
            _ecommerceDbContext = ecommerceDbContext;
            _mapper = mapper;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _ecommerceDbContext.Categories.ToList();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            #pragma warning disable CS8603 // Possible null reference return.
            return _ecommerceDbContext.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            #pragma warning restore CS8603 // Possible null reference return.
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category obj)
        {
            //_mapper.Map<Category, UpsertCategory>(obj)
            _ecommerceDbContext.Categories.Add(obj);    
            _ecommerceDbContext.SaveChanges();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
