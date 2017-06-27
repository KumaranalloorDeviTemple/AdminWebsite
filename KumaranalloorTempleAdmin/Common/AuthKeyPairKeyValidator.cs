using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kumaranalloordevitempleadminweb.Common
{
    public class AuthKeyPairKeyValidator
    {
        public bool validateAuthKeyPairKey(string AuthKey, string PairKey)
        {
            if (AuthKey=="K83uB2p1O6" && PairKey=="9401347" ||
                AuthKey == "H20sT5a9O4" && PairKey == "8390236" ||
                AuthKey == "D92iW8x3O5" && PairKey == "7289125")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}