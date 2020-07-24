using eBookStore.DataAccess.Data;
using eBookStore.DataAccess.Repository.IRepository;
using eBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBookStore.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        
    }
}
