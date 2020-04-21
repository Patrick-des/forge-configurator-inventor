﻿using System;
using System.IO;
using System.Security.Cryptography;

namespace WebApplication.Utilities
{
    public class Crypto
    {
        private static readonly SHA1 _sha1 = SHA1.Create(); // chosen because it's shorter

        /// <summary>
        /// Generate hex string from the bytes.
        /// </summary>
        public static string BytesToString(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", string.Empty);
        }

        /// <summary>
        /// Generate hash for the file.
        /// </summary>
        /// <returns>Byte array with hash.</returns>
        public static byte[] GenerateFileHash(string filePath)
        {
            using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return _sha1.ComputeHash(stream);
        }

        /// <summary>
        /// Generate hash for the file.
        /// </summary>
        /// <returns>Hash string.</returns>
        public static string GenerateFileHashString(string filePath)
        {
            var bytes = GenerateFileHash(filePath);
            return BytesToString(bytes);
        }

        /// <summary>
        /// Generate hash for stream.
        /// </summary>
        /// <returns>Hash string.</returns>
        public static string GenerateStreamHashString(Stream stream)
        {
            return BytesToString(_sha1.ComputeHash(stream));
        }
    }
}