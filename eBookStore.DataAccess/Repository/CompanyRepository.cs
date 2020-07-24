using eBookStore.DataAccess.Data;
using eBookStore.DataAccess.Repository.IRepository;
using eBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBookStore.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);            
        }
    }
}
