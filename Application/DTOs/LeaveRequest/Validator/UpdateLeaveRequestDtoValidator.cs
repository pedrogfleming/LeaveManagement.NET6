using Application.Persistence.Contracts;
using FluentValidation;

namespace Application.DTOs.LeaveRequest.Validator
{
    public class UpdateLeaveRequestDtoValidator : AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveTypeRepository;

        public UpdateLeaveRequestDtoValidator(ILeaveRequestRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
