using System.ComponentModel.DataAnnotations;

namespace MvcReminder.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
       public int Priority { get; set; }
      

    }
}
