using ChatABP.Dtos.Request;
using ChatABP.Dtos.Response;
using ChatABP.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Identity;

namespace ChatABP.Messages
{
    public class Chatservice : ApplicationService, IChatService, ITransientDependency
    {
        private readonly IIdentityUserRepository _identityUserRepository;
        private readonly ILookupNormalizer _lookupNormalizer;
        private readonly IDistributedEventBus _distributedEventBus;

        public Chatservice(IIdentityUserRepository identityUserRepository, ILookupNormalizer lookupNormalizer, IDistributedEventBus distributedEventBus)
        {
            _identityUserRepository = identityUserRepository;
            _lookupNormalizer = lookupNormalizer;
            _distributedEventBus = distributedEventBus;
        }

        public async Task CreateAsync(MessageRequest input)
        {
            //var targetId = (await _identityUserRepository.FindByNormalizedUserNameAsync(_lookupNormalizer.NormalizeName(input.SenderName))).Id;
            var message = new Message(GuidGenerator.Create(), input.SenderName
                    , input.Content, input.TimeStamp);
           
            await _distributedEventBus.PublishAsync(message);
        }
    }
    }
