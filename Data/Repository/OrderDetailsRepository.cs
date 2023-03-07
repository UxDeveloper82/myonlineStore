using onlineStore.Data.Repository.IRepository;
using onlineStore.Models;

namespace onlineStore.Data.Repository
{
    public class OrderDetailsRepository : Repository<OrderDetail>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(OrderDetail obj)
        {
            _db.Update(obj);
        }
    }
}
