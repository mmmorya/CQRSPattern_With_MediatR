using CQRSPattern_With_MediatR.Models;
using MediatR;

namespace CQRSPattern_With_MediatR.Commands
{
    public class CreateStudentCommand : IRequest<StudentDetails>
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }

        public CreateStudentCommand(string studentName, string studentEmail, string studentAddress, int studentAge)
        {
            StudentName = studentName;
            StudentEmail = studentEmail;
            StudentAddress = studentAddress;
            StudentAge = studentAge;
        }
    }
}
