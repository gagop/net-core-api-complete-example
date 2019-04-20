using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest
{
    public class CreateClassroomRequest : IUseCaseRequest<CreateClassroomResponse>
    {
        public int IdClassroom { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }

        

    }
}
