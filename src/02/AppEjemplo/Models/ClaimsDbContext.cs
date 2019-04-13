using Microsoft.EntityFrameworkCore;

namespace AppEjemplo.Models
{
    public partial class ClaimsDbContext : DbContext
    {
        public ClaimsDbContext()
        {
        }

        public ClaimsDbContext(DbContextOptions<ClaimsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Claims> Claims { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");


            modelBuilder.Entity<Claims>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("pk_claims");

                entity.ToTable("claims");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("claim_id")
                    .UseNpgsqlIdentityByDefaultColumn();

                entity.Property(e => e.InsurerAddress1)
                    .IsRequired()
                    .HasColumnName("insurer_address1")
                    .HasMaxLength(55);

                entity.Property(e => e.InsurerAddress2)
                    .HasColumnName("insurer_address2")
                    .HasMaxLength(55);

                entity.Property(e => e.InsurerCity)
                    .IsRequired()
                    .HasColumnName("insurer_city")
                    .HasMaxLength(50);

                entity.Property(e => e.InsurerId).HasColumnName("insurer_id");

                entity.Property(e => e.InsurerName)
                    .IsRequired()
                    .HasColumnName("insurer_name")
                    .HasMaxLength(80);

                entity.Property(e => e.InsurerState)
                    .IsRequired()
                    .HasColumnName("insurer_state")
                    .HasColumnType("character(2)");

                entity.Property(e => e.InsurerZip)
                    .IsRequired()
                    .HasColumnName("insurer_zip")
                    .HasColumnType("character(12)");

                entity.Property(e => e.SubscriberAddress1)
                    .IsRequired()
                    .HasColumnName("subscriber_address1")
                    .HasMaxLength(55);

                entity.Property(e => e.SubscriberAddress2)
                    .HasColumnName("subscriber_address2")
                    .HasMaxLength(55);

                entity.Property(e => e.SubscriberCity)
                    .IsRequired()
                    .HasColumnName("subscriber_city")
                    .HasMaxLength(50);

                entity.Property(e => e.SubscriberDOB)
                    .HasColumnName("subscriber_d_o_b")
                    .HasColumnType("date");

                entity.Property(e => e.SubscriberEmployerName)
                    .IsRequired()
                    .HasColumnName("subscriber_employer_name")
                    .HasMaxLength(80);

                entity.Property(e => e.SubscriberFirstName)
                    .IsRequired()
                    .HasColumnName("subscriber_first_name")
                    .HasMaxLength(35);

                entity.Property(e => e.SubscriberGender).HasColumnName("subscriber_gender");

                entity.Property(e => e.SubscriberId)
                    .IsRequired()
                    .HasColumnName("subscriber_id")
                    .HasMaxLength(20);

                entity.Property(e => e.SubscriberLastName)
                    .IsRequired()
                    .HasColumnName("subscriber_last_name")
                    .HasMaxLength(60);

                entity.Property(e => e.SubscriberMiddleInitial).HasColumnName("subscriber_middle_initial");

                entity.Property(e => e.SubscriberNameSuffix)
                    .HasColumnName("subscriber_name_suffix")
                    .HasMaxLength(10);

                entity.Property(e => e.SubscriberPlanGroupNumber)
                    .IsRequired()
                    .HasColumnName("subscriber_plan_group_number")
                    .HasMaxLength(20);

                entity.Property(e => e.SubscriberState)
                    .IsRequired()
                    .HasColumnName("subscriber_state")
                    .HasColumnType("character(2)");

                entity.Property(e => e.SubscriberZip)
                    .IsRequired()
                    .HasColumnName("subscriber_zip")
                    .HasColumnType("character(12)");
            });
        }
    }
}
