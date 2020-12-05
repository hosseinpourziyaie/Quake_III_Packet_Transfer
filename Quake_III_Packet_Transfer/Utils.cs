using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Quake_III_Packet_Transfer
{
    class Utils
    {
        public static bool Validate_Port(string StrPort)
        {
            int port;
            bool InRange = Int32.TryParse(StrPort, out port) && port >= 0 && port <= 65535;
            return InRange;
        }

        //https://stackoverflow.com/questions/11412956/what-is-the-best-way-of-validating-an-ip-address
        public static bool Validate_IP(string ipStr)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$";
            Regex check = new Regex(pattern);
            bool valid = false;
            if (ipStr == "")
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(ipStr, 0);
            }
            return valid;
        }
    }
}
