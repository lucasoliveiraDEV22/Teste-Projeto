// using ProjetoTeste.Application.Interfaces;
// using ProjetoTeste.Domain.Entities;
// using ProjetoTeste.Domain.Interfaces;
// using ProjetoTeste.Infrastructure.Repositories;

using ProjetoTeste.Application.Interfaces;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.Infrastructure.Repositories;

namespace ProjetoTeste.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _clienteRepository.AddAsync(cliente);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            await _clienteRepository.UpdateAsync(cliente);
        }

        public async Task DeleteAsync(int id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        Task<IEnumerable<Cliente>> IClienteService.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Cliente> IClienteService.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
