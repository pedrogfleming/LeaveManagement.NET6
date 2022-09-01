using Application.DTOs.LeaveType.Validators;
using Application.Features.LeaveType.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.Features.LeaveType.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        /// <returns>Returns the id of the Request created</returns>
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);
            if (!validationResult.IsValid) throw new Exception();

            var leaveType = _mapper.Map<Domain.LeaveType>(request.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.Add(leaveType);
            return leaveType.id;
        }
    }
}
