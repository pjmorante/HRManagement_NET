using HRManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}