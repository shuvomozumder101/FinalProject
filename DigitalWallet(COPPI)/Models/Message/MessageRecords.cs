using DigitalWallet_COPPI_.Models.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Models.Message
{
    public class MessageRecords
    {
        public List<Message> Messages { get; set; }
        public int TotalMessages { get; set; }
        public int LastChatMessageId { get; set; }
    }
}
