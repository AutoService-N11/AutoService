using AutoService.Domain.Entities.Models.ServiceModels;
using AutoService.Domain.Entities.Models.AutoServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Domain.Entities.Models.UserModels
{
    public class UserRequests
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid AutoServiceId { get; set; }
        public Guid ServiceId { get; set; }
    }
}
