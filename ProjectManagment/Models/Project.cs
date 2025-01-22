namespace ProjectManagment.Models
{
    public class Project : BaseEntity
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedByUserID { get; set; }

    
        public User CreatedBy { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
