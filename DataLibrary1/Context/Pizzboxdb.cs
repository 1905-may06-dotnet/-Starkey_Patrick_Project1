using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBoxContext.Context
{
    public partial class Pizzboxdb : DbContext
    {
        public Pizzboxdb()
        {
        }

        public Pizzboxdb(DbContextOptions<Pizzboxdb> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Pizzahistory> Pizzahistory { get; set; }
        public virtual DbSet<PizzasToCreate> PizzasToCreate { get; set; }
        public virtual DbSet<StoreLocation> StoreLocation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=utadbt.database.windows.net;Database=PizzaBox;user id=starkeycs;Password=CodeLikeABoss!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Customer__CB9A1CFFA34D58EE");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zipCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Customer__CB9A1CFFC80162B8");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__inventor__1EA716132BF468CA");

                entity.ToTable("inventory");

                entity.Property(e => e.StoreId)
                    .HasColumnName("storeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anchovies).HasColumnName("anchovies");

                entity.Property(e => e.Cheese).HasColumnName("cheese");

                entity.Property(e => e.Dough).HasColumnName("dough");

                entity.Property(e => e.Mushroom).HasColumnName("mushroom");
            });

            modelBuilder.Entity<Pizzahistory>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__pizzahis__080E3775E031DF95");

                entity.ToTable("pizzahistory");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Crust)
                    .HasColumnName("crust")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.Topping1)
                    .HasColumnName("topping1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping2)
                    .HasColumnName("topping2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping3)
                    .HasColumnName("topping3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping4)
                    .HasColumnName("topping4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping5)
                    .HasColumnName("topping5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Pizzahistory)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__pizzahist__order__5629CD9C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pizzahistory)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__pizzahist__userI__571DF1D5");
            });

            modelBuilder.Entity<PizzasToCreate>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__pizzasTo__080E3775C76027A0");

                entity.ToTable("pizzasToCreate");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Crust)
                    .HasColumnName("crust")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.Topping1)
                    .HasColumnName("topping1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping2)
                    .HasColumnName("topping2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping3)
                    .HasColumnName("topping3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping4)
                    .HasColumnName("topping4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Topping5)
                    .HasColumnName("topping5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PizzasToCreate)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__pizzasToC__order__5CD6CB2B");
            });

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__storeLoc__1EA71613DC467452");

                entity.ToTable("storeLocation");

                entity.Property(e => e.StoreId)
                    .HasColumnName("storeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zipCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });
        }
    }
}
