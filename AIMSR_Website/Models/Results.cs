using System.ComponentModel.DataAnnotations;

namespace AIMSR_Website.Models
{
    public class Results
    {
        [Key]
        public int ResultId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string Subject { get; set; }
        public int Marks { get; set; }
    }
}
