﻿using Application.Persistence.Contracts;
using FluentValidation;

namespace Application.DTOs.LeaveAllocation.Validator
{
    public class UpdateLeaveAllocationDtoValidator : AbstractValidator<UpdateLeaveAllocationDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            Include(new ILeaveAllocationDtoValidator(_leaveTypeRepository));

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
