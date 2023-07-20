using CRUD_ServerSide.Models;

namespace CRUD_ServerSide.Data
{
    public interface IEmployerService
    {
        Task<IEnumerable<Employer>> GetAllEmployer();
        Task<Employer> GetEmployerDetails(int id);
        Task<bool> InsertEmployer(Employer employer);
        Task<bool> UpdateEmployer(Employer employer);
        Task<bool> DeleteEmployer(int id);
        Task<bool> SaveEmployer(Employer employer);

    }
}
