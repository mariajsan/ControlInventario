namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ControlInventario.Models.productoscontextdb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ControlInventario.Models.productoscontextdb";
        }

        protected override void Seed(ControlInventario.Models.productoscontextdb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
