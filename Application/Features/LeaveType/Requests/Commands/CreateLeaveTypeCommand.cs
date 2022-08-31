using Application.DTOs.LeaveType;
using MediatR;

namespace Application.Features.LeaveType.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
