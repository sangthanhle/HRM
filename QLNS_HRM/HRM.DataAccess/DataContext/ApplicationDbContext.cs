using HRM.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace HRM.DataAccess.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeContract> EmployeeContracts { get; set; }
        public DbSet<EmployeeInsurance> EmployeeInsurances { get; set; }
        public DbSet<EmployeeMovement> EmployeeMovements { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<TrainingAttendance> TrainingAttendances { get; set; }

           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
               .HasIndex(e => e.Email)
               .IsUnique();
            modelBuilder.Entity<EmployeeInsurance>()
                .HasIndex(e => e.InsuranceNumber)
                .IsUnique();
            // Cấu hình khóa ngoại
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany(p => p.Employees)
                .HasForeignKey(e => e.PositionID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Role)
                .WithMany(r => r.Employees)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<EmployeeContract>()
                .HasOne(ec => ec.Employee)
                .WithMany(e => e.Contracts)
                .HasForeignKey(ec => ec.EmployeeID);

            modelBuilder.Entity<EmployeeInsurance>()
                .HasOne(ei => ei.Employee)
                .WithMany(e => e.Insurances)
                .HasForeignKey(ei => ei.EmployeeID);

            modelBuilder.Entity<EmployeeMovement>()
                .HasOne(em => em.Employee)
                .WithMany(e => e.Movements)
                .HasForeignKey(em => em.EmployeeID);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(ar => ar.Employee)
                .WithMany(e => e.AttendanceRecords)
                .HasForeignKey(ar => ar.EmployeeID);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(ar => ar.Shift)
                .WithMany()
                .HasForeignKey(ar => ar.ShiftID);

            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(ar => ar.LeaveType)
                .WithMany()
                .HasForeignKey(ar => ar.LeaveTypeID);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(lr => lr.Employee)
                .WithMany(e => e.LeaveRequests)
                .HasForeignKey(lr => lr.EmployeeID);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(lr => lr.LeaveType)
                .WithMany()
                .HasForeignKey(lr => lr.LeaveTypeID);

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(lr => lr.Approver)
                .WithMany()
                .HasForeignKey(lr => lr.ApprovedBy);

            modelBuilder.Entity<TrainingAttendance>()
                .HasOne(ta => ta.Employee)
                .WithMany(e => e.TrainingAttendances)
                .HasForeignKey(ta => ta.EmployeeID);

            modelBuilder.Entity<TrainingAttendance>()
                .HasOne(ta => ta.TrainingProgram)
                .WithMany()
                .HasForeignKey(ta => ta.TrainingProgramID);
            modelBuilder.Entity<LeaveRequest>()
                .HasOne(lr => lr.Employee)
                .WithMany(e => e.LeaveRequests)
                .HasForeignKey(lr => lr.EmployeeID)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
