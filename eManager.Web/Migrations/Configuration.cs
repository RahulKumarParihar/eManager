using System.Data.Entity.Migrations;
using eManager.Domain;
using eManager.Web.Infrastructure;

namespace eManager.Web.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DepartmentDb>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        ///     Runs after upgrading to the latest migration to allow seed data to be updated.
        /// </summary>
        /// <param name="context">Context to be used for updating seed data.</param>
        /// <remarks>
        ///     Note that the database may already contain seed data when this method runs. This means that
        ///     implementations of this method must check whether or not seed data is present and/or up-to-date
        ///     and then only make changes if necessary and in a non-destructive way. The
        ///     <see
        ///         cref="M:System.Data.Entity.Migrations.DbSetMigrationsExtensions.AddOrUpdate``1(System.Data.Entity.IDbSet{``0},``0[])" />
        ///     can be used to help with this, but for seeding large amounts of data it may be necessary to do less
        ///     granular checks if performance is an issue.
        ///     If the <see cref="T:System.Data.Entity.MigrateDatabaseToLatestVersion`2" /> database
        ///     initializer is being used, then this method will be called each time that the initializer runs.
        ///     If one of the <see cref="T:System.Data.Entity.DropCreateDatabaseAlways`1" />,
        ///     <see cref="T:System.Data.Entity.DropCreateDatabaseIfModelChanges`1" />,
        ///     or <see cref="T:System.Data.Entity.CreateDatabaseIfNotExists`1" /> initializers is being used, then this method
        ///     will not be
        ///     called and the Seed method defined in the initializer should be used instead.
        /// </remarks>
        protected override void Seed(DepartmentDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Departments.AddOrUpdate(x => x.Name,
                new Departments {Name = "Engineering"},
                new Departments {Name = "Sales"},
                new Departments {Name = "Shipping"},
                new Departments {Name = "Human Resources"}
            );
        }
    }
}