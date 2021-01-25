using DigitalWallet_COPPI_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Models
{
    public class FriendRequests
    {
        public UserProfile UserInfo { get; set; }
        public string RequestStatus { get; set; }
        public int RequestorUserID { get; set; }
        public int EndUserID { get; set; }
        public string Id { get; set; }
        public string ReceiverId { get; set; }
        public string ReceiverFullName { get; set; }
    }
}
