using MongoDB.Driver;
using WebApiFaseB.DataAccess;
using WebApiFaseB.Entities;

namespace WebApiFaseB.Services
{
    public class ProdottiService : IProdottiService
    {

        private  INegozioContext _context;
        public ProdottiService(INegozioContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async  Task<List<Prodotto>> GetProdotti()
        {
            return await _context
                            .Prodotti
                            .Find(p => true)
                            .ToListAsync();
        }

        public async Task<List<Prodotto>> GetProdottiByIDCarrello(Carrello id)
        {
            return null;
           
        }

        public Task<Prodotto> GetProdotto(string id)
        {
            throw new NotImplementedException();
        }
    }
}
