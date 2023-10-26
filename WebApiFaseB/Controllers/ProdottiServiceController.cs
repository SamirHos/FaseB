using Microsoft.AspNetCore.Mvc;
using WebApiFaseB.Entities;
using WebApiFaseB.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiFaseB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottiServiceController : ControllerBase
    {
        IProdottiService _prodottiService;

        public ProdottiServiceController(IProdottiService prodottiService)
        {
            _prodottiService = prodottiService;
        }

        // GET: api/<ProdottiServiceController>
        [HttpGet]
        public async Task<ActionResult<List<Prodotto>>> Get()
        {
            var prodotti =await _prodottiService.GetProdotti();    
            return Ok(prodotti);
        }

        // GET api/<ProdottiServiceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prodotto>> Get(string id)
        {
            var prodotto = await _prodottiService.GetProdotto(id);
            if (prodotto == null)
            {
                return NotFound();
            }
            return Ok(prodotto);
        }

        // POST api/<ProdottiServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdottiServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdottiServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
