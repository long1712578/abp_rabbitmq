using ChatABP.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ChatABP.Messages
{
    public interface IChatService : IApplicationService
    {
        Task CreateAsync(MessageRequest input);
    }
}
