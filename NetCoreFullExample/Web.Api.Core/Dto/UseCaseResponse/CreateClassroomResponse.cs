using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseResponse
{   
    public class CreateClassroomResponse : UseCaseResponseMessage
    {
        public Classroom Classroom { get; set; }

        public CreateClassroomResponse(Classroom newClassroom) : base()
        {

        }
    }
}
