using OsDsII.api.Models;

namespace OsDsII.api.Repository
{
    public interface IServiceOrderRepository 
    {
        public Task<List<ServiceOrder>> GetAllAsync();
        public Task<List<ServiceOrder>> GetByIdAsync();
        public Task AddAsync(ServiceOrder serviceorder);
        public Task FinishAsync(ServiceOrder serviceorder);
        public Task CancelAsync(ServiceOrder serviceorder);
    }
}
