//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsersManagerService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SupercomEntities : DbContext
    {
        public SupercomEntities()
            : base("name=SupercomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
    
        public virtual ObjectResult<GetUsers_Result> GetUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsers_Result>("GetUsers");
        }
    }
}
