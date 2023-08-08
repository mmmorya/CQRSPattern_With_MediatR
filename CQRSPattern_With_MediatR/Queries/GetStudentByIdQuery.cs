using CQRSPattern_With_MediatR.Models;
using MediatR;

namespace CQRSPattern_With_MediatR.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
