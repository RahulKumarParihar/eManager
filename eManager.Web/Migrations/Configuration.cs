using System.Data.Entity.Migrations;
using eManager.Domain;
using eManager.Web.Infrastructure;

namespace eManager.Web.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DepartmentDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Departments.AddOrUpdate(x => x.Name,
                new Department {Name = "Engineering"},
                new Department {Name = "Sales"},
                new Department {Name = "Shipping"},
                new Department {Name = "Human Resources"}
            );
        }
    }
}