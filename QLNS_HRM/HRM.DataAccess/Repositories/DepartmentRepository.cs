using HRM.DataAccess.DataContext;
using HRM.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace HRM.DataAccess.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        //private readonly ApplicationDbContext _context;
        public DepartmentRepository (ApplicationDbContext context) : base(context)
        {
            //_context = context;
        }
        public async Task<IEnumerable<Department>> GetAllActiveDepartment()
        {
            return await _Dbcontext.Departments.Where(c => c.IsActive).ToListAsync();
        }
    }
}
