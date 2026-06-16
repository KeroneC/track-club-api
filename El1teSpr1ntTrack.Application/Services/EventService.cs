using El1teSpr1ntTrack.Application.Interfaces;
using El1teSpr1ntTrack.Core.Interfaces.Repositories;
using El1teSpr1ntTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El1teSpr1ntTrack.Application.Services
{
    public class EventService : IEventService
    {

        private readonly IRepository<Event> _eventRepo;

        public EventService(IRepository<Event> eventRepo)
        {
            _eventRepo = eventRepo;
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await _eventRepo.GetAllAsync();
        }

        public async Task<Event?> GetByIdAsync(int id)
        {
            return await _eventRepo.GetByIdAsync(id);
        }

        public async Task AddAsync(Event ev)
        {
            await _eventRepo.AddAsync(ev);
            await _eventRepo.SaveChangesAsync();
        }

        public async Task UpdateAsync(Event ev)
        {
            _eventRepo.Update(ev);
            await _eventRepo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Event ev)
        {
            _eventRepo.Remove(ev);
            await _eventRepo.SaveChangesAsync();
        }
    }
}
