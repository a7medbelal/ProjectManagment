using ProjectManagment.Models.Enums;

namespace ProjectManagment.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; }

       
        public ICollection<Project> CreatedProjects { get; set; }
        public ICollection<TaskAssingnment> AssignedTasks { get; set; }
    }
}
