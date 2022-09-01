using Application.Persistence.Contracts;
using FluentValidation;

namespace Application.DTOs.LeaveRequest.Validator
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private ILeaveRequestRepository _leaveRequestRepository;

        public CreateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
            Include(new ILeaveRequestDtoValidator(_leaveRequestRepository));
        }
    }
}
