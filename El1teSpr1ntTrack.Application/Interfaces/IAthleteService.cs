using El1teSpr1ntTrack.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El1teSpr1ntTrack.Application.Interfaces
{
    public interface IAthleteService
    {
        Task<IEnumerable<Athlete>> GetAllAsync();
        Task<Athlete?> GetByIdAsync(int id);
        Task AddAsync(Athlete athlete);
        Task UpdateAsync(Athlete athlete);
        Task DeleteAsync(Athlete athlete);
    }
}
