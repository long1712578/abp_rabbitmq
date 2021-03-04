using System;
using System.Collections.Generic;
using System.Text;

namespace ChatABP.Dtos.Response
{
    public class ReceivedMessageEto
    {
        public string Content { get; set; }

        public Guid Id { get; set; }

        public string SenderName { get; set; }

        public ReceivedMessageEto(
        Guid id, string senderName, string content)
        {
            Id = id;
            SenderName = senderName;
            Content = content;
        }
    }
}
