using Chatter.Dto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatter.Dto
{
    public class MessageDto: IMessageDto
    {
        public string User { get; set; }
        public string Message { get; set; }
    }
}
