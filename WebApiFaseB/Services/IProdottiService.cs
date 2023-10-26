using WebApiFaseB.Entities;

namespace WebApiFaseB.Services
{
    public interface IProdottiService
    {
        Task<List<Prodotto>> GetProdotti();
        Task<Prodotto> GetProdotto(string id);
        Task<List<Prodotto>> GetProdottiByIDCarrello(Carrello id);
        
        
        
        

    }
}
