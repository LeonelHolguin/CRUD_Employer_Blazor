using CRUD_ServerSide.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ServerSide.Data
{
    public class EmployerService : IEmployerService
    {
        private readonly MyEmployersContext _context;

        public EmployerService(MyEmployersContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteEmployer(int id)
        {
            var employer = await _context.employers.FindAsync(id);

            _context.employers.Remove(employer);

            return await _context.SaveChangesAsync() > 0;


        }

        public async Task<IEnumerable<Employer>> GetAllEmployer()
        {
            return await _context.employers.ToListAsync();
        }

        public async Task<Employer> GetEmployerDetails(int id)
        {

            return await _context.employers.FindAsync(id);
        }

        public async Task<bool> InsertEmployer(Employer employer)
        {
            _context.employers.Add(employer);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveEmployer(Employer employer)
        {
            if(employer.EmployerId > 0)
                return await UpdateEmployer(employer);
            else
                return await InsertEmployer(employer);
        }

        public async Task<bool> UpdateEmployer(Employer employer)
        {
            _context.Entry(employer).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
