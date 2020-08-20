using eBookStore.DataAccess.Data;
using eBookStore.DataAccess.Repository.IRepository;
using eBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBookStore.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.Update(obj);
        }
    }
}
