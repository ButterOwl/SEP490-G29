using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternshipHub.Models
{
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }
        public int Status { get; set; }
        public int MentorId { get; set; }
        public int InternId { get; set; }
        public string? Reason { get; set; }
    }
}
