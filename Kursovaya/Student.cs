using Microsoft.EntityFrameworkCore;


namespace Kursovaya
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string RoomNumber { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public static string sqlstr;
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
    }
    public static class DbWork
    {
        public static void AddStudent(string _FirstName, string _SecondName, string _RoomNumber)
        {
            using (var dbContext = new StudentDbContext())
            {
                var newStudent = new Student()
                {
                    FirstName = _FirstName,
                    SecondName = _SecondName,
                    RoomNumber = _RoomNumber
                };
                dbContext.Students.Add(newStudent);
                dbContext.SaveChanges();
            }
        }
        public static void DeleteStudent(int Id)
        {
            using (var dbContext = new StudentDbContext())
            {
                var entity = dbContext.Students.FirstOrDefault(e => e.Id == Id);
                dbContext.Remove(entity);
                dbContext.SaveChanges();
            }
        }
    }
}
