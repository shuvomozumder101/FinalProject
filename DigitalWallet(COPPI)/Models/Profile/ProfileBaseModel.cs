using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Models.Profile
{
    public class ProfileBaseModel
    {
        public ProfileHeaderBarModel ProfileHeaderBarModel { get; private set; }

        public ProfileBaseModel()
        {
            ProfileHeaderBarModel = new ProfileHeaderBarModel();
        }
    }
}
