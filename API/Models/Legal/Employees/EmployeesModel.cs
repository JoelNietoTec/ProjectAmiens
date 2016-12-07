namespace API.Models.Legal.Employees
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeesModel : DbContext
    {
        public EmployeesModel()
            : base("name=EmployeesModel")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<Matter> Matters { get; set; }
        public virtual DbSet<MatterType> MatterTypes { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<PracticeArea> PracticeAreas { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>();

            modelBuilder.Entity<ClientType>();

            modelBuilder.Entity<Employee>()
                .Property(e => e.HourRate)
                .HasPrecision(19, 4);


            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Matters)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.AttorneyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PracticeArea>();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PracticeAreas)
                .WithMany(e => e.Employees)
                .Map(x =>
                {
                    x.ToTable("PracticeAreaMembers");
                    x.MapLeftKey("PracticeAreaID");
                    x.MapRightKey("AttorneyID");
                });


            modelBuilder.Entity<Industry>();

            modelBuilder.Entity<Matter>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Matter>()
                .Property(e => e.AdvanceBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MatterType>();

            modelBuilder.Entity<Position>();
        }
    }
}
