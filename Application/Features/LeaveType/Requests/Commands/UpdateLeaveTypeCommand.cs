using Application.DTOs.LeaveType;
using MediatR;

namespace Application.Features.LeaveType.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
