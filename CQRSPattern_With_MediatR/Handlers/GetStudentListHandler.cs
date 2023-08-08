using CQRSPattern_With_MediatR.Contracts;
using CQRSPattern_With_MediatR.Models;
using CQRSPattern_With_MediatR.Queries;
using MediatR;

namespace CQRSPattern_With_MediatR.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
