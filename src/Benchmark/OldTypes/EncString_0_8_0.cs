using System;
using System.Globalization;
using System.Text;

namespace Benchmark.OldTypes
{
    public class EncString_0_8_0
    {
        /// An old class, just used for comparing the older versions of the EncTypes

        #region Variables And Properties

        private string _encryptionKey;
        private string _encryptedValue;

        /// <summary>
        /// The decrypted value of the stored string.
        /// </summary>
        private string Value
        {
            get => EncryptorDecryptor(_encryptedValue, _encryptionKey);
            set => _encryptedValue = EncryptorDecryptor(value, _encryptionKey);
        }

        public int Length
        {
            get => Value.Length;
        }

        public static string Empty
        {
            get => string.Empty;
        }

        public char this[int index]
        {
            get => Value[index];
        }

        #endregion

        #region Methods

        public bool IsEqual(EncString_0_8_0 encString) => encString.Value == this.Value;
        public bool IsNull() => this.Value == null;
        public object Clone() => Value.Clone();
        public override bool Equals(object obj) => Value.Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public bool Contains(string value) => Value.Contains(value);
        public int CompareTo(object value) => Value.CompareTo(value);
        public int CompareTo(string strB) => Value.CompareTo(strB);
        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) => Value.CopyTo(sourceIndex, destination, destinationIndex, count);
        public bool EndsWith(string value) => Value.EndsWith(value);
        public bool EndsWith(string value, StringComparison comparisonType) => Value.EndsWith(value, comparisonType);
        public bool EndsWith(string value, bool ignoreCase, CultureInfo culture) => Value.EndsWith(value, ignoreCase, culture);
        public CharEnumerator GetEnumerator() => Value.GetEnumerator();
        public TypeCode GetTypeCode() => Value.GetTypeCode();
        public int IndexOf(string value, int startIndex, StringComparison comparisonType) => Value.IndexOf(value, startIndex, comparisonType);
        public int IndexOf(string value, StringComparison comparisonType) => Value.IndexOf(value, comparisonType);
        public int IndexOf(string value, int startIndex, int count) => Value.IndexOf(value, startIndex, count);
        public int IndexOf(string value) => Value.IndexOf(value);
        public int IndexOf(char value, int startIndex, int count) => Value.IndexOf(value, startIndex, count);
        public int IndexOf(char value, int startIndex) => Value.IndexOf(value, startIndex);
        public int IndexOf(char value) => Value.IndexOf(value);
        public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) => Value.IndexOf(value, startIndex, count, comparisonType);
        public int IndexOf(string value, int startIndex) => Value.IndexOf(value, startIndex);
        public int IndexOfAny(char[] anyOf) => Value.IndexOfAny(anyOf);
        public int IndexOfAny(char[] anyOf, int startIndex, int count) => Value.IndexOfAny(anyOf, startIndex, count);
        public int IndexOfAny(char[] anyOf, int startIndex) => Value.IndexOfAny(anyOf, startIndex);
        public string Insert(int startIndex, string value) => Value.Insert(startIndex, value);
        public bool IsNormalized() => Value.IsNormalized();
        public bool IsNormalized(NormalizationForm normalizationForm) => Value.IsNormalized(normalizationForm);
        public int LastIndexOf(string value, int startIndex, StringComparison comparisonType) => Value.LastIndexOf(value, startIndex, comparisonType);
        public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) => Value.LastIndexOf(value, startIndex, count, comparisonType);
        public int LastIndexOf(string value, int startIndex, int count) => Value.LastIndexOf(value, startIndex, count);
        public int LastIndexOf(string value, StringComparison comparisonType) => Value.LastIndexOf(value, comparisonType);
        public int LastIndexOf(string value) => Value.LastIndexOf(value);
        public int LastIndexOf(char value, int startIndex, int count) => Value.LastIndexOf(value, startIndex, count);
        public int LastIndexOf(char value, int startIndex) => Value.LastIndexOf(value, startIndex);
        public int LastIndexOf(string value, int startIndex) => Value.LastIndexOf(value, startIndex);
        public int LastIndexOf(char value) => Value.LastIndexOf(value);
        public int LastIndexOfAny(char[] anyOf) => Value.LastIndexOfAny(anyOf);
        public int LastIndexOfAny(char[] anyOf, int startIndex) => Value.LastIndexOfAny(anyOf, startIndex);
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count) => Value.LastIndexOfAny(anyOf, startIndex, count);
        public string Normalize() => Value.Normalize();
        public string Normalize(NormalizationForm normalizationForm) => Value.Normalize(normalizationForm);
        public string PadLeft(int totalWidth) => Value.PadLeft(totalWidth);
        public string PadLeft(int totalWidth, char paddingChar) => Value.PadLeft(totalWidth, paddingChar);
        public string PadRight(int totalWidth) => Value.PadRight(totalWidth);
        public string PadRight(int totalWidth, char paddingChar) => Value.PadRight(totalWidth, paddingChar);
        public string Remove(int startIndex) => Value.Remove(startIndex);
        public string Remove(int startIndex, int count) => Value.Remove(startIndex, count);
        public string Replace(string oldValue, string newValue) => Value.Replace(oldValue, newValue);
        public string Replace(char oldChar, char newChar) => Value.Replace(oldChar, newChar);
        public string[] Split(string[] separator, int count, StringSplitOptions options) => Value.Split(separator, count, options);
        public string[] Split(params char[] separator) => Value.Split(separator);
        public string[] Split(char[] separator, int count) => Value.Split(separator, count);
        public string[] Split(char[] separator, int count, StringSplitOptions options) => Value.Split(separator, count, options);
        public string[] Split(char[] separator, StringSplitOptions options) => Value.Split(separator, options);
        public string[] Split(string[] separator, StringSplitOptions options) => Value.Split(separator, options);
        public bool StartsWith(string value) => Value.StartsWith(value);
        public bool StartsWith(string value, bool ignoreCase, CultureInfo culture) => Value.StartsWith(value, ignoreCase, culture);
        public bool StartsWith(string value, StringComparison comparisonType) => Value.StartsWith(value, comparisonType);
        public string Substring(int startIndex) => Value.Substring(startIndex);
        public string Substring(int startIndex, int length) => Value.Substring(startIndex, length);
        public char[] ToCharArray(int startIndex, int length) => Value.ToCharArray(startIndex, length);
        public char[] ToCharArray() => Value.ToCharArray();
        public string ToLower() => Value.ToLower();
        public string ToLower(CultureInfo culture) => Value.ToLower(culture);
        public string ToLowerInvariant() => Value.ToLowerInvariant();
        public override string ToString() => Value.ToString();
        public string ToString(IFormatProvider provider) => Value.ToString(provider);
        public string ToUpper() => Value.ToUpper();
        public string ToUpper(CultureInfo culture) => Value.ToUpper(culture);
        public string ToUpperInvariant() => Value.ToUpperInvariant();
        public string Trim() => Value.Trim();
        public string Trim(params char[] trimChars) => Value.Trim(trimChars);
        public string TrimEnd(params char[] trimChars) => Value.TrimEnd(trimChars);
        public string TrimStart(params char[] trimChars) => Value.TrimStart(trimChars);

        #endregion

        #region Constructors

        public EncString_0_8_0(string value) => New(value, this);

        public EncString_0_8_0(char[] value)
            : this(new string(value)) { }

        public EncString_0_8_0(char c, int count)
            : this(new string(c, count)) { }

        public EncString_0_8_0(char[] value, int startIndex, int length)
            : this(new string(value, startIndex, length)) { }

        private static void New(string value, EncString_0_8_0 encString)
        {
            encString._encryptionKey = RandomString();
            encString.Value = value;
        }

        #endregion

        #region Encryption Decryption

        static Random random = new Random();

        static int RandomLength() => random.Next(10, 150);

        static char RandomChar(int min = char.MinValue, int max = (char.MaxValue - 1))
        {
            return (char)(random.Next(min, max));
        }

        static string RandomString()
        {
            char[] chars = new char[RandomLength()];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = RandomChar();
            }
            return new string(chars);
        }

        private static string EncryptorDecryptor(string data, string key)
        {
            if (data == null || key == null)
            {
                return null;
            }
            else
            {
                int dataLen = data.Length;
                int keyLen = key.Length;
                char[] output = new char[dataLen];

                for (int i = 0; i < dataLen; ++i)
                {
                    output[i] = (char)(data[i] ^ key[i % keyLen]);
                }

                return new string(output);
            }
        }

        #endregion

        #region Operators Overloading

        /// + 
        public static EncString_0_8_0 operator +(EncString_0_8_0 enc, string n) => new EncString_0_8_0(enc.Value + n);
        public static string operator +(string n, EncString_0_8_0 enc) => enc.Value + n;

        /// == != < >
        public static bool operator ==(EncString_0_8_0 es1, string es2) => es1.Value == es2;
        public static bool operator !=(EncString_0_8_0 es1, string es2) => es1.Value != es2;

        /// assign
        public static implicit operator EncString_0_8_0(string value) => new EncString_0_8_0(value);
        public static implicit operator string(EncString_0_8_0 encString) => encString.Value;

        #endregion
    }
}
