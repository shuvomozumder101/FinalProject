using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Models
{
    public class LoginRegitrationViewModel
    {
        public Login Login { get; set; }
        public Registration Registration { get; set; }

        public LoginRegitrationViewModel()
        {
            this.Login = new Login();
            this.Registration = new Registration();
        }
    }
}
