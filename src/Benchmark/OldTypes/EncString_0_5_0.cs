using System;

namespace Benchmark.OldTypes
{
    public class EncString_0_5_0
    {
        /// An old class, just used for comparing the older versions of the EncTypes

        #region Content

        #region Variables And Properties

        private string _encryptionKey;
        private string _encryptedValue;

        private string Value
        {
            get => EncryptorDecryptor(_encryptedValue, _encryptionKey);
            set => _encryptedValue = EncryptorDecryptor(value, _encryptionKey);
        }

        public int Length
        {
            get => Value.Length;
        }

        #endregion

        #region Methods

        public static EncString_0_5_0 NewEncString(string value)
        {
            EncString_0_5_0 encString = new EncString_0_5_0
            {
                _encryptionKey = RandomString(),
                Value = value
            };
            return encString;
        }

        public static EncString_0_5_0 NewEncString(char[] characters)
        {
            string value = new string(characters);
            EncString_0_5_0 encString = new EncString_0_5_0
            {
                _encryptionKey = RandomString(),
                Value = value
            };
            return encString;
        }

        static Random random = new Random();

        public static char RandomChar() => RandomChar(char.MinValue, char.MaxValue - 1);
        public static char RandomChar(int min, int max)
        {
            return (char)(random.Next(min, max));
        }
        public static char RandomNormalChar() => RandomChar(48, 125);


        public static string RandomString()
        {
            char[] chars = new char[100];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = RandomChar();
            }
            return new string(chars);
        }
        public static string RandomNormalString()
        {
            char[] chars = new char[25];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = RandomNormalChar();
            }
            return new string(chars);
        }


        public static string EncryptorDecryptor(string data, string key)
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

        public static string ReplaceAt(string input, int index, char newChar)
        {
            if (input != null)
            {
                char[] chars = input.ToCharArray();
                chars[index] = newChar;
                return new string(chars);
            }
            else return null;
        }

        public char[] ToCharArray() => this.Value.ToCharArray();

        #endregion

        #region Default Overrides

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        #endregion

        #region Operators Overloading

        /// == != < >
        public static bool operator ==(EncString_0_5_0 es1, string es2) => es1.Value == es2;
        public static bool operator !=(EncString_0_5_0 es1, string es2) => es1.Value != es2;

        public static bool operator ==(EncString_0_5_0 es1, EncString_0_5_0 es2) => es1.Value == es2.Value;
        public static bool operator !=(EncString_0_5_0 es1, EncString_0_5_0 es2) => es1.Value != es2.Value;

        /// assign
        public static implicit operator EncString_0_5_0(string value) => EncString_0_5_0.NewEncString(value);
        public static implicit operator string(EncString_0_5_0 encString) => encString.Value;
        public static explicit operator char[](EncString_0_5_0 encString) => encString.Value.ToCharArray();


        #endregion

        #endregion
    }
}
