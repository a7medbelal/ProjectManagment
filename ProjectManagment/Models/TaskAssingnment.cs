namespace ProjectManagment.Models
{
    public class TaskAssingnment : BaseEntity

    {
       public int TaskID { get; set; }
        public int UserID { get; set; }
        public DateTime AssignedDate { get; set; }

        public Task Task { get; set; }
        public User User { get; set; }

    }
    }
