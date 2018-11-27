﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShopModule.Classes.Misc
{
    class Miscs
    {
        private const string EncryptKey = "secret123.a32.a23";

        public static string EncryptPassword(string pswdDecrypt)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(EncryptKey);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    pswdDecrypt = Convert.ToBase64String(ms.ToArray());
                }
            }

            return pswdDecrypt;
        }

        public static string DecryptPassword(string pswdEncrypt)
        {
            pswdEncrypt = pswdEncrypt.Replace(" ", "+");
            byte[] encryptBytes = Convert.FromBase64String(pswdEncrypt);
            using (Aes encryptor =  Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptBytes, 0, encryptBytes.Length);
                        cs.Close();
                    }

                    pswdEncrypt = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return pswdEncrypt;
        }
    }
}