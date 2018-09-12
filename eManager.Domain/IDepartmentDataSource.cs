using System.Linq;

namespace eManager.Domain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employees> Employees { get; }
        IQueryable<Departments> Departments { get; }
    }
}