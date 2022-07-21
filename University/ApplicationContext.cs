using University.Tables;
using Microsoft.EntityFrameworkCore;

namespace University
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Specialization> Specializations { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Faculty> Faculties { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<EducationForm> EducationForms { get; set; } = null!;
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<AcademicDegree> AcademicDegrees { get; set; } = null!;
        public DbSet<Dormitory> Dormitories { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Block> Blocks { get; set; } = null!;
        public DbSet<Parent> Parents { get; set; } = null!;
        public DbSet<BlockType> BlockTypes { get; set; } = null!;
        public DbSet<Scholarship> Scholarships { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=University;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlockType>().HasData(
                new BlockType { Id = 1, AmountOfSeats = 3, ChairsAmount = 3, TablesAmount = 1, WardrobesAmount = 3},
                new BlockType { Id = 2, AmountOfSeats = 2, ChairsAmount = 2, TablesAmount = 1, WardrobesAmount = 2 }
                );
        }
    }
}
