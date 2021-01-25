using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Models
{
    public class UserProfile
    {
        [Key]
        public int U_ID { get; set; }
        public string Name { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
