using Chatter.Dto;
using Chatter.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatter.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> hubContext;

        public ChatController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        [HttpPost]
        [Route("send")]
        public IActionResult SendRequest(MessageDto message)
        {
            hubContext.Clients.All.SendAsync("SendMessage", message.User, message.Message);
            return Ok();
        }

    }
}
