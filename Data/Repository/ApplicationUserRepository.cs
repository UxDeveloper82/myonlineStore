using onlineStore.Data.Repository.IRepository;
using onlineStore.Models;

namespace onlineStore.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db):base(db)  
        {
            _db = db;
        }
    }
}
