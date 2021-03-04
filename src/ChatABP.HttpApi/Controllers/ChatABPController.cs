using ChatABP.Dtos.Request;
using ChatABP.Localization;
using ChatABP.Messages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace ChatABP.Controllers
{
    /* Inherit your controllers from this class.
     */
    [Route("api/app/chat")]
    public class ChatABPController : AbpController,IChatService
    {
        private readonly IChatService _chatService;
        private readonly Producer _producer;
        public ChatABPController(IChatService chatService,Producer producer)
        {
            //LocalizationResource = typeof(ChatABPResource);
            _chatService = chatService;
            _producer = producer;
        }
        [HttpPost]
        [Route("send-message")]
        public async Task CreateAsync(MessageRequest input)
        {
            
            await _chatService.CreateAsync(input);
        }
    }
}

