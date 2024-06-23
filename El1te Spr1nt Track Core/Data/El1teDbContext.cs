using Microsoft.EntityFrameworkCore;

namespace El1te_Spr1nt_Track_Core.Data
{
    public class El1teDbContext :  DbContext
    {

        public El1teDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
