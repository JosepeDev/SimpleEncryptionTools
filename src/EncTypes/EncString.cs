using System;
using System.Globalization;
using System.Text;

namespace EncTypes
{
    public class EncString
    {
        /// A class for storing a string while efficiently keeping it encrypted in the memory
        /// Instead of encrypting and decrypting yourself, you can just use the encrypted type (EncType) of the variable you want to be encrypted
        /// The encryption will happen in the background without you worrying about it
        /// In the memory it is saved as a wierd char array that is affected by random keys { encryptionKeys }
        /// Every time the value of the string changes, the encryption keys change too. And it works exactly as a string
        ///
        /// WIKI AND INFO: https://github.com/JosepeDev/VarEnc

        #region Variables And Properties

        private readonly byte[] encryptionKeys;
        private readonly ushort[] encryptedValue;

        private string Decrypt
        {
            get
            {
                if (encryptedValue == null)
                {
                    return null;
                }
                else
                {
                    int dataLen = encryptedValue.Length;
                    int keyLen = encryptionKeys.Length;
                    char[] output = new char[dataLen];

                    for (int i = 0; i < dataLen; ++i)
                    {
                        output[i] = (char)(encryptedValue[i] ^ encryptionKeys[i % keyLen]);
                    }

                    return new string(output);
                }
            }
        }

        public int Length
        {
            get => Decrypt.Length;
        }

        public static string Empty
        {
            get => string.Empty;
        }

        public char this[int index]
        {
            get => Decrypt[index];
        }

        #endregion

        #region Methods

        public bool IsNull() => this.Decrypt == null;
        public object Clone() => Decrypt.Clone();
        public override bool Equals(object obj) => Decrypt.Equals(obj);
        public override int GetHashCode() => Decrypt.GetHashCode();
        public bool Contains(string value) => Decrypt.Contains(value);
        public int CompareTo(object value) => Decrypt.CompareTo(value);
        public int CompareTo(string strB) => Decrypt.CompareTo(strB);
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) => Decrypt.CopyTo(sourceIndex, destination, destinationIndex, count);
        public bool EndsWith(string value) => Decrypt.EndsWith(value);
        public bool EndsWith(string value, StringComparison comparisonType) => Decrypt.EndsWith(value, comparisonType);
        public bool EndsWith(string value, bool ignoreCase, CultureInfo culture) => Decrypt.EndsWith(value, ignoreCase, culture);
        public CharEnumerator GetEnumerator() => Decrypt.GetEnumerator();
        public TypeCode GetTypeCode() => Decrypt.GetTypeCode();
        public int IndexOf(string value, int startIndex, StringComparison comparisonType) => Decrypt.IndexOf(value, startIndex, comparisonType);
        public int IndexOf(string value, StringComparison comparisonType) => Decrypt.IndexOf(value, comparisonType);
        public int IndexOf(string value, int startIndex, int count) => Decrypt.IndexOf(value, startIndex, count);
        public int IndexOf(string value) => Decrypt.IndexOf(value);
        public int IndexOf(char value, int startIndex, int count) => Decrypt.IndexOf(value, startIndex, count);
        public int IndexOf(char value, int startIndex) => Decrypt.IndexOf(value, startIndex);
        public int IndexOf(char value) => Decrypt.IndexOf(value);
        public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) => Decrypt.IndexOf(value, startIndex, count, comparisonType);
        public int IndexOf(string value, int startIndex) => Decrypt.IndexOf(value, startIndex);
        public int IndexOfAny(char[] anyOf) => Decrypt.IndexOfAny(anyOf);
        public int IndexOfAny(char[] anyOf, int startIndex, int count) => Decrypt.IndexOfAny(anyOf, startIndex, count);
        public int IndexOfAny(char[] anyOf, int startIndex) => Decrypt.IndexOfAny(anyOf, startIndex);
        public string Insert(int startIndex, string value) => Decrypt.Insert(startIndex, value);
        public bool IsNormalized() => Decrypt.IsNormalized();
        public bool IsNormalized(NormalizationForm normalizationForm) => Decrypt.IsNormalized(normalizationForm);
        public int LastIndexOf(string value, int startIndex, StringComparison comparisonType) => Decrypt.LastIndexOf(value, startIndex, comparisonType);
        public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) => Decrypt.LastIndexOf(value, startIndex, count, comparisonType);
        public int LastIndexOf(string value, int startIndex, int count) => Decrypt.LastIndexOf(value, startIndex, count);
        public int LastIndexOf(string value, StringComparison comparisonType) => Decrypt.LastIndexOf(value, comparisonType);
        public int LastIndexOf(string value) => Decrypt.LastIndexOf(value);
        public int LastIndexOf(char value, int startIndex, int count) => Decrypt.LastIndexOf(value, startIndex, count);
        public int LastIndexOf(char value, int startIndex) => Decrypt.LastIndexOf(value, startIndex);
        public int LastIndexOf(string value, int startIndex) => Decrypt.LastIndexOf(value, startIndex);
        public int LastIndexOf(char value) => Decrypt.LastIndexOf(value);
        public int LastIndexOfAny(char[] anyOf) => Decrypt.LastIndexOfAny(anyOf);
        public int LastIndexOfAny(char[] anyOf, int startIndex) => Decrypt.LastIndexOfAny(anyOf, startIndex);
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count) => Decrypt.LastIndexOfAny(anyOf, startIndex, count);
        public string Normalize() => Decrypt.Normalize();
        public string Normalize(NormalizationForm normalizationForm) => Decrypt.Normalize(normalizationForm);
        public string PadLeft(int totalWidth) => Decrypt.PadLeft(totalWidth);
        public string PadLeft(int totalWidth, char paddingChar) => Decrypt.PadLeft(totalWidth, paddingChar);
        public string PadRight(int totalWidth) => Decrypt.PadRight(totalWidth);
        public string PadRight(int totalWidth, char paddingChar) => Decrypt.PadRight(totalWidth, paddingChar);
        public string Remove(int startIndex) => Decrypt.Remove(startIndex);
        public string Remove(int startIndex, int count) => Decrypt.Remove(startIndex, count);
        public string Replace(string oldValue, string newValue) => Decrypt.Replace(oldValue, newValue);
        public string Replace(char oldChar, char newChar) => Decrypt.Replace(oldChar, newChar);
        public string[] Split(string[] separator, int count, StringSplitOptions options) => Decrypt.Split(separator, count, options);
        public string[] Split(params char[] separator) => Decrypt.Split(separator);
        public string[] Split(char[] separator, int count) => Decrypt.Split(separator, count);
        public string[] Split(char[] separator, int count, StringSplitOptions options) => Decrypt.Split(separator, count, options);
        public string[] Split(char[] separator, StringSplitOptions options) => Decrypt.Split(separator, options);
        public string[] Split(string[] separator, StringSplitOptions options) => Decrypt.Split(separator, options);
        public bool StartsWith(string value) => Decrypt.StartsWith(value);
        public bool StartsWith(string value, bool ignoreCase, CultureInfo culture) => Decrypt.StartsWith(value, ignoreCase, culture);
        public bool StartsWith(string value, StringComparison comparisonType) => Decrypt.StartsWith(value, comparisonType);
        public string Substring(int startIndex) => Decrypt.Substring(startIndex);
        public string Substring(int startIndex, int length) => Decrypt.Substring(startIndex, length);
        public char[] ToCharArray(int startIndex, int length) => Decrypt.ToCharArray(startIndex, length);
        public char[] ToCharArray() => Decrypt.ToCharArray();
        public string ToLower() => Decrypt.ToLower();
        public string ToLower(CultureInfo culture) => Decrypt.ToLower(culture);
        public string ToLowerInvariant() => Decrypt.ToLowerInvariant();
        public override string ToString() => Decrypt.ToString();
        public string ToString(IFormatProvider provider) => Decrypt.ToString(provider);
        public string ToUpper() => Decrypt.ToUpper();
        public string ToUpper(CultureInfo culture) => Decrypt.ToUpper(culture);
        public string ToUpperInvariant() => Decrypt.ToUpperInvariant();
        public string Trim() => Decrypt.Trim();
        public string Trim(params char[] trimChars) => Decrypt.Trim(trimChars);
        public string TrimEnd(params char[] trimChars) => Decrypt.TrimEnd(trimChars);
        public string TrimStart(params char[] trimChars) => Decrypt.TrimStart(trimChars);

        #endregion

        #region Constructors

        public EncString()
        {
            encryptionKeys = new byte[8];
        }

        public EncString(string value) : this()
        {
            encryptedValue = Encrypt(value, encryptionKeys);
        }

        public EncString(char[] value) : this()
        {
            encryptedValue = Encrypt(value, encryptionKeys);
        }

        public EncString(char c, int count)
            : this(new string(c, count)) { }

        public EncString(char[] value, int startIndex, int length)
            : this(new string(value, startIndex, length)) { }


        #endregion

        #region Encryption Decryption

        static Random random = new Random();

        private static ushort[] Encrypt(char[] data, byte[] keys)
        {
            if (data == null)
            {
                return null;
            }
            else
            {
                random.NextBytes(keys);

                int dataLen = data.Length;
                int keyLen = keys.Length;
                ushort[] output = new ushort[dataLen];

                for (int i = 0; i < dataLen; ++i)
                {
                    output[i] = (ushort)(data[i] ^ keys[i % keyLen]);
                }

                return output;
            }
        }

        private static ushort[] Encrypt(string data, byte[] keys)
        {
            if (data == null)
            {
                return null;
            }
            else
            {
                random.NextBytes(keys);

                int dataLen = data.Length;
                int keyLen = keys.Length;
                ushort[] output = new ushort[dataLen];

                for (int i = 0; i < dataLen; ++i)
                {
                    output[i] = (ushort)(data[i] ^ keys[i % keyLen]);
                }

                return output;
            }
        }

        #endregion

        #region Operators Overloading

        /// + 
        public static EncString operator +(EncString enc, string n) => new EncString(enc.Decrypt + n);
        public static string operator +(string n, EncString enc) => enc.Decrypt + n;

        /// == != < >
        public static bool operator ==(EncString es1, string es2) => es1.Decrypt == es2;
        public static bool operator !=(EncString es1, string es2) => es1.Decrypt != es2;
        public static bool operator ==(EncString es1, EncString es2) => es1.Decrypt == es2.Decrypt;
        public static bool operator !=(EncString es1, EncString es2) => es1.Decrypt != es2.Decrypt;

        /// assign
        public static implicit operator EncString(string value) => new EncString(value);
        public static explicit operator EncString(char[] value) => new EncString(value);
        public static implicit operator string(EncString encString) => encString.Decrypt;

        #endregion
    }
}
