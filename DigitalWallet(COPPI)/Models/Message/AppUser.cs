using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Models.Message
{
    public class AppUser
    {
        public AppUser()
        {
            Message = new HashSet<Message>();
        }
        public virtual ICollection<Message> Message { get; set; }
    }
}
