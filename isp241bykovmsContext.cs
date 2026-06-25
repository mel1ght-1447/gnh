using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace pr8
{
    public partial class isp241bykovmsContext : DbContext
    {
        public isp241bykovmsContext()
        {
        }

        public isp241bykovmsContext(DbContextOptions<isp241bykovmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectDocument> ProjectDocument { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<SystemSetting> SystemSetting { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserTask> UserTask { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=pgadmin.lab;Port=5432;Database=isp-24-1-bykov-ms;SearchPath=pr7;Username=isp-24-bykov-ms;Password=58227");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.PkProject)
                    .HasName("project_pkey");

                entity.ToTable("project", "pr7");

                entity.Property(e => e.PkProject)
                    .HasColumnName("pk_project")
                    .HasDefaultValueSql("nextval('project_pk_project_seq'::regclass)");

                entity.Property(e => e.BeginDate).HasColumnName("begin_date");

                entity.Property(e => e.Budget).HasColumnName("budget");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FkUser)
                    .HasColumnName("fk_user")
                    .HasDefaultValueSql("nextval('project_fk_user_seq'::regclass)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ProjectDocument>(entity =>
            {
                entity.HasKey(e => e.PkProjectDocument)
                    .HasName("project_document_pkey");

                entity.ToTable("project_document", "pr7");

                entity.Property(e => e.PkProjectDocument)
                    .HasColumnName("pk_project_document")
                    .HasDefaultValueSql("nextval('project_document_pk_project_document_seq'::regclass)");

                entity.Property(e => e.FkProject)
                    .HasColumnName("fk_project")
                    .HasDefaultValueSql("nextval('project_document_fk_project_seq'::regclass)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkProjectNavigation)
                    .WithMany(p => p.ProjectDocument)
                    .HasForeignKey(d => d.FkProject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("project_document_fk_project_fkey");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasKey(e => e.PkReport)
                    .HasName("report_pkey");

                entity.ToTable("report", "pr7");

                entity.Property(e => e.PkReport)
                    .HasColumnName("pk_report")
                    .HasDefaultValueSql("nextval('report_pk_report_seq'::regclass)");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.FkUser)
                    .HasColumnName("fk_user")
                    .HasDefaultValueSql("nextval('report_fk_user_seq'::regclass)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(25);

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("report_fk_user_fkey");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasKey(e => e.PkSystemSetting)
                    .HasName("system_setting_pkey");

                entity.ToTable("system_setting", "pr7");

                entity.Property(e => e.PkSystemSetting)
                    .HasColumnName("pk_system_setting")
                    .HasDefaultValueSql("nextval('system_setting_pk_system_setting_seq'::regclass)");

                entity.Property(e => e.BackupDate).HasColumnName("backup_date");

                entity.Property(e => e.BackupType)
                    .IsRequired()
                    .HasColumnName("backup_type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.PkTask)
                    .HasName("task_pkey");

                entity.ToTable("task", "pr7");

                entity.Property(e => e.PkTask)
                    .HasColumnName("pk_task")
                    .HasDefaultValueSql("nextval('task_pk_task_seq'::regclass)");

                entity.Property(e => e.Deadline).HasColumnName("deadline");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.FkProject)
                    .HasColumnName("fk_project")
                    .HasDefaultValueSql("nextval('task_fk_project_seq'::regclass)");

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasColumnName("priority")
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.HasOne(d => d.FkProjectNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.FkProject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("task_fk_project_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.PkUser)
                    .HasName("user_pkey");

                entity.ToTable("user", "pr7");

                entity.Property(e => e.PkUser)
                    .HasColumnName("pk_user")
                    .HasDefaultValueSql("nextval('user_pk_user_seq'::regclass)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(255);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(255);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(255);

                entity.Property(e => e.Midllename)
                    .HasColumnName("midllename")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasMaxLength(12);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UserTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_task", "pr7");

                entity.Property(e => e.FkTask)
                    .HasColumnName("fk_task")
                    .HasDefaultValueSql("nextval('user_task_fk_task_seq'::regclass)");

                entity.Property(e => e.FkUser)
                    .HasColumnName("fk_user")
                    .HasDefaultValueSql("nextval('user_task_fk_user_seq'::regclass)");

                entity.HasOne(d => d.FkTaskNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_task_fk_task_fkey");

                entity.HasOne(d => d.FkUserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.FkUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_task_fk_user_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
