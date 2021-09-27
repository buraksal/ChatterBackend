using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatter.Dto.Interfaces
{
    public interface IMessageDto
    {
        public string User { get; set; }
        public string Message { get; set; }
    }
}
