﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace GalaxyFlow.Core.Tools
{
    public class JhEncrypt
    {
        #region 构造方法

        /// <summary>
        /// 构造方法
        /// </summary>
        public JhEncrypt()
        {
        }


        #endregion

        #region 私有字段

        //
        // 缺省密码
        //
        const string defaultPassword = "JASONHEUNG";

        #endregion

        #region 公共静态方法

        /// <summary>
        /// 使用缺省密钥字符串加密
        /// </summary>
        /// <param name="original">明文</param>
        /// <returns>密文</returns>
        public static string Encrypt(string original)
        {
            return Encrypt(original, defaultPassword);
        }


        /// <summary>
        /// 使用缺省密钥解密
        /// </summary>
        /// <param name="original">密文</param>
        /// <returns>明文</returns>
        public static string Decrypt(string original)
        {
            return Decrypt(original, defaultPassword, Encoding.Default);
        }


        /// <summary>
        /// 使用给定密钥解密
        /// </summary>
        /// <param name="original">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        public static string Decrypt(string original, string key)
        {
            return Decrypt(original, key, Encoding.Default);
        }


        /// <summary>
        /// 使用缺省密钥解密,返回指定编码方式明文
        /// </summary>
        /// <param name="original">密文</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>明文</returns>
        public static string Decrypt(string original, Encoding encoding)
        {
            return Decrypt(original, defaultPassword, encoding);
        }


        /// <summary>
        /// 使用给定密钥加密
        /// </summary>
        /// <param name="original">原始文字</param>
        /// <param name="key">密钥</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns>密文</returns>
        public static string Encrypt(string original, string key)
        {
            byte[] buff = Encoding.Default.GetBytes(original);
            byte[] kb = Encoding.Default.GetBytes(key);
            return Convert.ToBase64String(Encrypt(buff, kb));
        }


        /// <summary>
        /// 使用给定密钥解密
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns>明文</returns>
        public static string Decrypt(string encrypted, string key, Encoding encoding)
        {
            byte[] buff = Convert.FromBase64String(encrypted);
            byte[] kb = Encoding.Default.GetBytes(key);
            return encoding.GetString(Decrypt(buff, kb));
        }


        /// <summary>
        /// 生成MD5摘要
        /// </summary>
        /// <param name="original">数据源</param>
        /// <returns>摘要</returns>
        public static byte[] MakeMD5(byte[] original)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyhash = hashmd5.ComputeHash(original);
            hashmd5 = null;
            return keyhash;
        }


        /// <summary>
        /// 使用给定密钥加密
        /// </summary>
        /// <param name="original">明文</param>
        /// <param name="key">密钥</param>
        /// <returns>密文</returns>
        public static byte[] Encrypt(byte[] original, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
        }


        /// <summary>
        /// 使用给定密钥解密数据
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        public static byte[] Decrypt(byte[] encrypted, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
        }


        /// <summary>
        /// 使用给定密钥加密
        /// </summary>
        /// <param name="original">原始数据</param>
        /// <param name="key">密钥</param>
        /// <returns>密文</returns>
        public static byte[] Encrypt(byte[] original)
        {
            byte[] key = Encoding.Default.GetBytes(defaultPassword);
            return Encrypt(original, key);
        }


        /// <summary>
        /// 使用缺省密钥解密数据
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        public static byte[] Decrypt(byte[] encrypted)
        {
            byte[] key = Encoding.Default.GetBytes(defaultPassword);
            return Decrypt(encrypted, key);
        }


        #endregion
    }
}
