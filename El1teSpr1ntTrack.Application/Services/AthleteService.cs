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
    public class AthleteService : IAthleteService
    {
        private readonly IRepository<Athlete> _athleteRepo;

        public AthleteService(IRepository<Athlete> athleteRepo)
        {
            _athleteRepo = athleteRepo;
        }

        public async Task<IEnumerable<Athlete>> GetAllAsync()
        {
            return await _athleteRepo.GetAllAsync();
        }

        public async Task<Athlete?> GetByIdAsync(int id)
        {
            return await _athleteRepo.GetByIdAsync(id);
        }

        public async Task AddAsync(Athlete athlete)
        {
            await _athleteRepo.AddAsync(athlete);
        }

        public async Task UpdateAsync(Athlete athlete)
        {
            _athleteRepo.Update(athlete);
            await _athleteRepo.SaveChangesAsync();
        }

        public async Task DeleteAsync(Athlete athlete)
        {
            _athleteRepo.Remove(athlete);
            await _athleteRepo.SaveChangesAsync();  
        }
    }
}
