using HRManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Application.Persistance.Contracts
{
    internal interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}
