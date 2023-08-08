using MediatR;

namespace CQRSPattern_With_MediatR.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
