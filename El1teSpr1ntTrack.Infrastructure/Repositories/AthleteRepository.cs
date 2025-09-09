using El1teSpr1ntTrack.Core.Interfaces.Repositories;
using El1teSpr1ntTrack.Core.Models;
using El1teSpr1ntTrack.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El1teSpr1ntTrack.Infrastructure.Repositories
{
    public class AthleteRepository : IAthleteRepository
    {
        private readonly El1teDbContext _context;

        public AthleteRepository(El1teDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Athlete>> GetAllAsync()
        {
            return await _context.Athletes.ToListAsync();
        }

        public async Task<Athlete?> GetByIdAsync(int id)
        {
            return await _context.Athletes.FindAsync(id);
        }

        public async Task AddAsync(Athlete athlete)
        {
            await _context.Athletes.AddAsync(athlete);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Athlete athlete)
        {
            _context.Athletes.Update(athlete);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Athlete athlete)
        {
            _context.Athletes.Remove(athlete);
            await _context.SaveChangesAsync();
        }
    }
}
