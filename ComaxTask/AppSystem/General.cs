using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaxTask.AppSystem
{
    public class General
    {
        private static UserProfile _connectedUserProfile;

        public static UserProfile ConnectedUserProfile
        {
            get
            {
                return _connectedUserProfile;
            }
            set
            {
                _connectedUserProfile = value;
            }
        }
    }
}
