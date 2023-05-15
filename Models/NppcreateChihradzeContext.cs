using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NPP.Models;

public partial class NppcreateChihradzeContext : DbContext
{
    public NppcreateChihradzeContext()
    {
    }

    private static NppcreateChihradzeContext _context;

    public NppcreateChihradzeContext(DbContextOptions<NppcreateChihradzeContext> options)
        : base(options)
    {
    }

    public static NppcreateChihradzeContext GetContext()
    {
        if (_context == null)
            _context = new NppcreateChihradzeContext();

        return _context;
    }



    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<County> Counties { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<OrgProduct> OrgProducts { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<TypeEquipment> TypeEquipments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=81.177.6.104, 1433; Database=nppcreate_Chihradze; User ID=is221; Password =Student1234; Trusted_Connection=False; Integrated Security=False; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.ToTable("Contract");

            entity.Property(e => e.DateContract).HasColumnType("date");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdOrgProductNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdOrgProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_OrgProduct");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Status");

            entity.HasOne(d => d.IdWorkerNavigation).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.IdWorker)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Worker");
        });

        modelBuilder.Entity<County>(entity =>
        {
            entity.ToTable("County");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.ToTable("Delivery");

            entity.Property(e => e.Comment).HasMaxLength(50);

            entity.HasOne(d => d.IdContractNavigation).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.IdContract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Delivery_Contract");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<OrgProduct>(entity =>
        {
            entity.ToTable("OrgProduct");

            entity.HasOne(d => d.IdOrgNavigation).WithMany(p => p.OrgProducts)
                .HasForeignKey(d => d.IdOrg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrgProduct_Organization");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.OrgProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrgProduct_Product1");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.ToTable("Organization");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Website).HasMaxLength(50);

            entity.HasOne(d => d.IdCountryNavigation).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.IdCountry)
                .HasConstraintName("FK_Organization_County");

            entity.HasOne(d => d.IdUserOrgNavigation).WithMany(p => p.Organizations)
                .HasForeignKey(d => d.IdUserOrg)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Organization_User");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.ToTable("Post");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdTypeEquipmentNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeEquipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_TypeEquipment");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Status_1");

            entity.ToTable("Status");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeEquipment>(entity =>
        {
            entity.ToTable("TypeEquipment");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("Имя пользователя");
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.ToTable("Worker");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Birthday).HasColumnType("date");
            entity.Property(e => e.DateDismissal).HasColumnType("date");
            entity.Property(e => e.DateHiring).HasColumnType("date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Patronymic).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);

            entity.HasOne(d => d.IdDepartmentNavigation).WithMany(p => p.Workers)
                .HasForeignKey(d => d.IdDepartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Worker_Department1");

            entity.HasOne(d => d.IdPostNavigation).WithMany(p => p.Workers)
                .HasForeignKey(d => d.IdPost)
                .HasConstraintName("FK_Worker_Post1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
