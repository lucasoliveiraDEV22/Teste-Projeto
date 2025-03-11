using ProjetoTeste.Application.Interfaces;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.Domain.Interfaces;

namespace ProjetoTeste.Application.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public async Task<IEnumerable<Venda>> GetAllAsync()
        {
            return await _vendaRepository.GetAllAsync();
        }

        public async Task<Venda> GetByIdAsync(int id)
        {
            return await _vendaRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Venda venda)
        {
            await _vendaRepository.AddAsync(venda);
        }

        public async Task UpdateAsync(Venda venda)
        {
            await _vendaRepository.UpdateAsync(venda);
        }

        public async Task DeleteAsync(int id)
        {
            await _vendaRepository.DeleteAsync(id);
        }
    }
}
