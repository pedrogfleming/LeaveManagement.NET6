using Application.DTOs.LeaveRequest;
using MediatR;

namespace Application.Features.LeaveRequest.Requests.Commands
{
    public class CreatedLeveRequestCommand : IRequest<int>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; internal set; }
    }
}
