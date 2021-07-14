using System;

namespace Benchmark.OldTypes
{
    public struct EncInt_1_1_0
    {
        /// A struct for storing a 32-bit integer while efficiently keeping it encrypted in the memory
        /// Instead of encrypting and decrypting yourself, you can just use the encrypted type (EncType) of the variable you want to be encrypted
        /// The encryption will happen in the background without you worrying about it
        /// In the memory it is saved as a an array of weird bytes that are affected by random values { encryptionKeys array }
        /// Every time the value changes, the encryption keys change too. And it works exactly as an int (Int32)
        ///
        /// WIKI & INFO: https://github.com/JosepeDev/VarEnc

        #region Variables And Properties

        private readonly byte[] encryptionKeys;

        // The encrypted value stored in memory
        private readonly byte[] encryptedValue;

        // Takes an encrypted value and returns it decrypted
        private int Decrypt
        {
            get
            {
                var valueBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    valueBytes[i] = (byte)(encryptedValue[i] ^ encryptionKeys[i]);
                }
                return BitConverter.ToInt32(valueBytes, 0);
            }
        }

        public static int MaxValue { get => Int32.MaxValue; }
        public static int MinValue { get => Int32.MinValue; }

        #endregion

        #region Methods And Constructors

        private EncInt_1_1_0(int value)
        {
            encryptionKeys = new byte[4];
            encryptedValue = Encrypt(value, encryptionKeys);
        }

        // Encryption Key Generator
        static private Random random = new Random();

        // Takes a given value and returns it encrypted
        private static byte[] Encrypt(int value, byte[] keys)
        {
            random.NextBytes(keys);
            var valueBytes = BitConverter.GetBytes(value);
            for (int i = 0; i < 4; i++)
            {
                valueBytes[i] ^= keys[i];
            }
            return valueBytes;
        }

        // Int32 methods
        public Int32 CompareTo(object value) => Decrypt.CompareTo(value);
        public Int32 CompareTo(Int32 value) => Decrypt.CompareTo(value);
        public bool Equals(Int32 obj) => Decrypt.Equals(obj);
        public override bool Equals(object obj) => Decrypt.Equals(obj);
        public override Int32 GetHashCode() => Decrypt.GetHashCode();
        public TypeCode GetTypeCode() => Decrypt.GetTypeCode();
        public override string ToString() => Decrypt.ToString();
        public string ToString(IFormatProvider provider) => Decrypt.ToString(provider);
        public string ToString(string format) => Decrypt.ToString(format);
        public string ToString(string format, IFormatProvider provider) => Decrypt.ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// & | ^ << >>
        public static EncInt_1_1_0 operator &(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt & eint2.Decrypt);
        public static EncInt_1_1_0 operator |(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt | eint2.Decrypt);
        public static EncInt_1_1_0 operator ^(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt ^ eint2.Decrypt);

        public static int operator &(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt & eint2;
        public static int operator |(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt | eint2;
        public static int operator ^(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt ^ eint2;
        public static int operator >>(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt >> eint2;
        public static int operator <<(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt << eint2;

        /// + - * / %
        public static EncInt_1_1_0 operator +(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt + eint2.Decrypt);
        public static EncInt_1_1_0 operator -(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt - eint2.Decrypt);
        public static EncInt_1_1_0 operator *(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt * eint2.Decrypt);
        public static EncInt_1_1_0 operator /(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt / eint2.Decrypt);
        public static EncInt_1_1_0 operator %(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => new EncInt_1_1_0(eint1.Decrypt % eint2.Decrypt);

        public static int operator +(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt_1_1_0 eint1, ushort eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt_1_1_0 eint1, ushort eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt_1_1_0 eint1, ushort eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt_1_1_0 eint1, ushort eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt_1_1_0 eint1, ushort eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt_1_1_0 eint1, short eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt_1_1_0 eint1, short eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt_1_1_0 eint1, short eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt_1_1_0 eint1, short eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt_1_1_0 eint1, short eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt_1_1_0 eint1, byte eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt_1_1_0 eint1, byte eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt_1_1_0 eint1, byte eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt_1_1_0 eint1, byte eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt_1_1_0 eint1, byte eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt_1_1_0 eint1, sbyte eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt_1_1_0 eint1, sbyte eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt_1_1_0 eint1, sbyte eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt_1_1_0 eint1, sbyte eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt_1_1_0 eint1, sbyte eint2) => eint1.Decrypt % eint2;

        /// == != < >
        public static bool operator ==(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => eint1.Decrypt == eint2.Decrypt;
        public static bool operator !=(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => eint1.Decrypt != eint2.Decrypt;
        public static bool operator <(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => eint1.Decrypt < eint2.Decrypt;
        public static bool operator >(EncInt_1_1_0 eint1, EncInt_1_1_0 eint2) => eint1.Decrypt > eint2.Decrypt;

        public static bool operator ==(EncInt_1_1_0 eint1, ulong eint2) => (ulong)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, ulong eint2) => (ulong)eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, ulong eint2) => (ulong)eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, ulong eint2) => (ulong)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, long eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, long eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, long eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, long eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, uint eint2) => (uint)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, uint eint2) => (uint)eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, uint eint2) => (uint)eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, uint eint2) => (uint)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, int eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, ushort eint2) => (ushort)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, ushort eint2) => (ushort)eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, ushort eint2) => (ushort)eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, ushort eint2) => (ushort)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, short eint2) => (short)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, short eint2) => (short)eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, short eint2) => (short)eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, short eint2) => (short)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, byte eint2) => (byte)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, byte eint2) => (byte)eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, byte eint2) => (byte)eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, byte eint2) => (byte)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, sbyte eint2) => (sbyte)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, sbyte eint2) => (sbyte)eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, sbyte eint2) => (sbyte)eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, sbyte eint2) => (sbyte)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, decimal eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, decimal eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, decimal eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, decimal eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, double eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, double eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, double eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, double eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt_1_1_0 eint1, float eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt_1_1_0 eint1, float eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt_1_1_0 eint1, float eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt_1_1_0 eint1, float eint2) => eint1.Decrypt < eint2;

        /// assign
        public static explicit operator EncInt_1_1_0(ulong value) => new EncInt_1_1_0((int)value);
        public static explicit operator EncInt_1_1_0(long value) => new EncInt_1_1_0((int)value);
        public static explicit operator EncInt_1_1_0(uint value) => new EncInt_1_1_0((int)value);
        public static implicit operator EncInt_1_1_0(int value) => new EncInt_1_1_0(value);
        public static implicit operator EncInt_1_1_0(ushort value) => new EncInt_1_1_0(value);
        public static implicit operator EncInt_1_1_0(short value) => new EncInt_1_1_0(value);
        public static implicit operator EncInt_1_1_0(byte value) => new EncInt_1_1_0(value);
        public static implicit operator EncInt_1_1_0(sbyte value) => new EncInt_1_1_0(value);
        public static explicit operator EncInt_1_1_0(decimal value) => new EncInt_1_1_0((int)value);
        public static explicit operator EncInt_1_1_0(double value) => new EncInt_1_1_0((int)value);
        public static explicit operator EncInt_1_1_0(float value) => new EncInt_1_1_0((int)value);

        public static explicit operator ulong(EncInt_1_1_0 eint1) => (ulong)eint1.Decrypt;
        public static implicit operator long(EncInt_1_1_0 eint1) => eint1.Decrypt;
        public static explicit operator uint(EncInt_1_1_0 eint1) => (uint)eint1.Decrypt;
        public static implicit operator int(EncInt_1_1_0 eint1) => eint1.Decrypt;
        public static explicit operator ushort(EncInt_1_1_0 eint1) => (ushort)eint1.Decrypt;
        public static explicit operator short(EncInt_1_1_0 eint1) => (short)eint1.Decrypt;
        public static explicit operator byte(EncInt_1_1_0 eint1) => (byte)eint1.Decrypt;
        public static explicit operator sbyte(EncInt_1_1_0 eint1) => (sbyte)eint1.Decrypt;
        public static implicit operator decimal(EncInt_1_1_0 eint1) => eint1.Decrypt;
        public static implicit operator double(EncInt_1_1_0 eint1) => eint1.Decrypt;
        public static implicit operator float(EncInt_1_1_0 eint1) => eint1.Decrypt;

        #endregion
    }
}
