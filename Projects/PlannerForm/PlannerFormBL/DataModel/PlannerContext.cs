namespace PlannerFormBL.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PlannerContext : DbContext
    {
        // Your context has been configured to use a 'PlannerContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PlannerFormBL.DataModel.PlannerContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PlannerContext' 
        // connection string in the application configuration file.
        public PlannerContext()
            : base("name=PlannerContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<PlanTask> PlanListData { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}