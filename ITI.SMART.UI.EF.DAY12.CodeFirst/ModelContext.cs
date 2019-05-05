namespace ITI.SMART.UI.EF.DAY12.CodeFirst
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Your context has been configured to use a 'ModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ITI.SMART.UI.EF.DAY12.CodeFirst.ModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelContext' 
        // connection string in the application configuration file.
        public ModelContext()
            : base("name=ModelContext")
        {
        }

      
        public virtual DbSet<City> cities { get; set; }
        public virtual DbSet<Country> countries { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Book> books { get; set; }
        public virtual DbSet<Department> departments { get; set; }
        public virtual DbSet<Employee> employees { get; set; }
        public virtual DbSet<Cover> covers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department")
                .HasKey(d => d.DeptId)
                .Property(d=>d.name).HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>().ToTable("Employee")
                .Property(d => d.name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Department>()
              .HasMany(d => d.employees)
              .WithRequired(e => e.Department)
              .HasForeignKey(e => e.FK_DepartmentId);

            modelBuilder.Entity<Employee>()
           .HasMany(e => e.Books)
           .WithMany(b => b.employees)
           .Map(m => m.ToTable("EmpBooks")
           .MapLeftKey("FK_EmpId")
           .MapRightKey("FK_BookId"));

           modelBuilder.Entity<City>()
          .HasOptional(c => c.Book)
          .WithRequired(b => b.City);

            modelBuilder.Entity<Cover>()
                .ToTable("cover")
                .Property(c => c.code)
                .HasMaxLength(100).IsRequired();
        

        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}