namespace ProjectManagment.Models
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime DueDate { get; set; }
        public int AssignedByUserID { get; set; }

     
        public Project Project { get; set; }
        public User AssignedBy { get; set; }
        public ICollection<TaskAssingnment> TaskAssignments { get; set; }
    }
}
