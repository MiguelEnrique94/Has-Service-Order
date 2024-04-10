using Microsoft.EntityFrameworkCore;
using OsDsII.api.Data;
using OsDsII.api.Models;

namespace OsDsII.api.Repository
{
    public sealed class ServiceOrderRepository
    {
        //DI DATA CONTEXT
        private readonly DataContext _dataContext;

        public ServiceOrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<ServiceOrder>> GetAllAsync()
        {
            return await _dataContext.ServiceOrders.ToListAsync();
        }

        public async Task<List<ServiceOrder>> GetByIdAsync()
        {
            return await _dataContext.ServiceOrders.FirstOrDefaultAsync(s => s.Id == Id);
        }

        public async Task AddAsync(ServiceOrder serviceorder)
        {
            await _dataContext.ServiceOrders.AddAsync(serviceorder);
            await _dataContext.SaveChangesAsync();
        }

        public async Task FinishAsync(ServiceOrder serviceorder)
        {
            _dataContext.ServiceOrders.Update(serviceorder);
            await _dataContext.SaveChangesAsync();
        }

        public async Task CancelAsync(ServiceOrder serviceorder)
        {
            _dataContext.ServiceOrders.Update(serviceorder);
            await _dataContext.SaveChangesAsync();
        }
    }
}

