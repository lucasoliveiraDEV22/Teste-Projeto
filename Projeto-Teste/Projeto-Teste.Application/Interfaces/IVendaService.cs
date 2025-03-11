using ProjetoTeste.Domain.Entities;

namespace ProjetoTeste.Application.Interfaces
{
    public interface IVendaService
    {
        Task<IEnumerable<Venda>> GetAllAsync();
        Task<Venda> GetByIdAsync(int id);
        Task AddAsync(Venda venda);
        Task UpdateAsync(Venda venda);
        Task DeleteAsync(int id);
    }
}