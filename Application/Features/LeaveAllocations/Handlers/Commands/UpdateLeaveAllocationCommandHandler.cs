using Application.Features.LeaveAllocations.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveAllocations.Handlers.Commands
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveAllocationRepository.Get(request.LeaveAllocationDto.Id);
            //We dont know wich field where updated so we can use automapper to do the update
            _mapper.Map(request.LeaveAllocationDto, leaveType);
            await _leaveAllocationRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
