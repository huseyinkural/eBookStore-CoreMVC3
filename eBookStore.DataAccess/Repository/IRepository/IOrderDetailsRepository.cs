using eBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBookStore.DataAccess.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails obj);
    }
}
