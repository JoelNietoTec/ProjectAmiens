namespace API.Models.Legal.Clients
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClientsModel : DbContext
    {
        public ClientsModel()
            : base("name=ClientsModel")
        {
        }

        public virtual DbSet<ClientContact> ClientContacts { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<Matter> Matters { get; set; }
        public virtual DbSet<MatterType> MatterTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Matters)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientType>();

            modelBuilder.Entity<Country>();

            modelBuilder.Entity<Employee>()
                .Property(e => e.HourRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Industry>();

            modelBuilder.Entity<Matter>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Matter>()
                .Property(e => e.AdvanceBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MatterType>();
        }
    }
}
