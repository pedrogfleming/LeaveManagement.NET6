using Application.DTOs.LeaveType;
using MediatR;

namespace Application.Features.LeaveType.Requests.Queries
{
    /// <summary>
    /// Implements IRequest<First, what should expect in return>
    /// </summary>
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
