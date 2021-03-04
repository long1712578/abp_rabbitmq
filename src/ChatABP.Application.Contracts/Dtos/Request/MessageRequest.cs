using System;
using System.Collections.Generic;
using System.Text;

namespace ChatABP.Dtos.Request
{
    public class MessageRequest
    {
        public string SenderName { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
