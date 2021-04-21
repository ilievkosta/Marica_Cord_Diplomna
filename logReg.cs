using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Marica_Coord
{
   public class logReg
    {
      public static byte[] GetSaltedPasswordHash(string username, string password)
        {
            byte[] pwdBytes = Encoding.UTF8.GetBytes(password);
            // byte[] salt = BitConverter.GetBytes(userId);
            byte[] salt = Encoding.UTF8.GetBytes(username);
            byte[] saltedPassword = new byte[pwdBytes.Length + salt.Length];

            Buffer.BlockCopy(pwdBytes, 0, saltedPassword, 0, pwdBytes.Length);
            Buffer.BlockCopy(salt, 0, saltedPassword, pwdBytes.Length, salt.Length);

            SHA1 sha = SHA1.Create();

            return sha.ComputeHash(saltedPassword);
        }
    }
}
