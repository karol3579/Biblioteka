using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_KP.Common
{
    static internal class MD5
    {
        public static string CreateMD5(string data) {
            var md = System.Security.Cryptography.MD5.Create();
            var hash = md.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

    }
}
