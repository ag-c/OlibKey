﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace OlibKey.Core
{
    public static class Encryptor
    {
        private static byte[] GetRandomBytes()
        {
            var saltLength = SaltLength;
            var ba = new byte[saltLength];
            RandomNumberGenerator.Create().GetBytes(ba);
            return ba;
        }

        private static int SaltLength => 8;

        private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] saltBytes = {1, 2, 3, 4, 5, 6, 7, 8};

            using var ms = new MemoryStream();

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 2000);
            using var aes = new RijndaelManaged {KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC};
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);

            using var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
            cs.Close();

            return ms.ToArray();
        }

        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] saltBytes = {1, 2, 3, 4, 5, 6, 7, 8};

            using var ms = new MemoryStream();

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 2000);
            using var aes = new RijndaelManaged {KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC};
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);

            using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);

            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
            cs.Close();

            return ms.ToArray();
        }

        public static string EncryptString(string text, string password)
        {
            var baPwd = Encoding.UTF8.GetBytes(password);
            var baPwdHash = SHA256.Create().ComputeHash(baPwd);
            var baText = Encoding.UTF8.GetBytes(text);
            var baSalt = GetRandomBytes();
            var baEncrypted = new byte[baSalt.Length + baText.Length];
            for (var i = 0; i < baSalt.Length; i ++) baEncrypted[i] = baSalt[i];
            for (var i = 0; i < baText.Length; i ++) baEncrypted[i + baSalt.Length] = baText[i];
            baEncrypted = AES_Encrypt(baEncrypted, baPwdHash);

            return Convert.ToBase64String(baEncrypted);
        }

        public static string DecryptString(string text, string password)
        {
            var baPwd = Encoding.UTF8.GetBytes(password);
            var baPwdHash = SHA256.Create().ComputeHash(baPwd);
            var baText = Convert.FromBase64String(text);
            var baDecrypted = AES_Decrypt(baText, baPwdHash);
            var saltLength = SaltLength;
            var baResult = new byte[baDecrypted.Length - saltLength];
            for (int i = 0; i < baResult.Length; i ++) baResult[i] = baDecrypted[i + saltLength];

            return Encoding.UTF8.GetString(baResult);
        }
    }
}
