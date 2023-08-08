using System.ComponentModel.DataAnnotations;

namespace CQRSPattern_With_MediatR.Models
{
    public class StudentDetails
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentAddress { get; set; } = string.Empty;
        public int StudentAge { get; set; }
    }
}
