using CQRSPattern_With_MediatR.Models;
using MediatR;

namespace CQRSPattern_With_MediatR.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {

    }
}
