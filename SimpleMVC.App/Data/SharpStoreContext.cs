using System.Security.AccessControl;
using SharpStore.Models;

namespace SharpStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SharpStoreContext : DbContext
    {
        // Your context has been configured to use a 'SharpStoreContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SharpStore.Data.SharpStoreContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SharpStoreContext' 
        // connection string in the application configuration file.
        public SharpStoreContext()
            : base("name=SharpStoreContext")
        {
        }

        public virtual DbSet<Knife> Knives { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        public virtual DbSet<Purchase> Purchases { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Login> Logins { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}