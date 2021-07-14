using System;

namespace EncTypes
{
    public struct EncInt
    {
        /// A struct for storing a 32-bit integer while efficiently keeping it encrypted in the memory
        /// Instead of encrypting and decrypting yourself, you can just use the encrypted type (EncType) of the variable you want to be encrypted
        /// The encryption will happen in the background without you worrying about it
        /// In the memory it is saved as a an array of weird bytes that are affected by random values { encryptionKeys array }
        /// Every time the value changes, the encryption keys change too. And it works exactly as an int (Int32)
        ///
        /// WIKI AND INFO: https://github.com/JosepeDev/VarEnc

        #region Variables And Properties

        private readonly int encryptionKey;
        private readonly int encryptedValue;

        private int Decrypt
        {
            get => encryptedValue ^ encryptionKey;
        }

        public static int MaxValue { get => Int32.MaxValue; }
        public static int MinValue { get => Int32.MinValue; }

        #endregion

        #region Methods And Constructors

        private EncInt(int value)
        {
            encryptionKey = random.Next();
            encryptedValue = value ^ encryptionKey;
        }

        static private Random random = new Random();

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
        public static EncInt operator &(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt & eint2.Decrypt);
        public static EncInt operator |(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt | eint2.Decrypt);
        public static EncInt operator ^(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt ^ eint2.Decrypt);

        public static int operator &(EncInt eint1, int eint2) => eint1.Decrypt & eint2;
        public static int operator |(EncInt eint1, int eint2) => eint1.Decrypt | eint2;
        public static int operator ^(EncInt eint1, int eint2) => eint1.Decrypt ^ eint2;
        public static int operator >>(EncInt eint1, int eint2) => eint1.Decrypt >> eint2;
        public static int operator <<(EncInt eint1, int eint2) => eint1.Decrypt << eint2;

        /// + - * / %
        public static EncInt operator +(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt + eint2.Decrypt);
        public static EncInt operator -(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt - eint2.Decrypt);
        public static EncInt operator *(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt * eint2.Decrypt);
        public static EncInt operator /(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt / eint2.Decrypt);
        public static EncInt operator %(EncInt eint1, EncInt eint2) => new EncInt(eint1.Decrypt % eint2.Decrypt);

        public static int operator +(EncInt eint1, int eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt eint1, int eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt eint1, int eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt eint1, int eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt eint1, int eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt eint1, ushort eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt eint1, ushort eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt eint1, ushort eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt eint1, ushort eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt eint1, ushort eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt eint1, short eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt eint1, short eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt eint1, short eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt eint1, short eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt eint1, short eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt eint1, byte eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt eint1, byte eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt eint1, byte eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt eint1, byte eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt eint1, byte eint2) => eint1.Decrypt % eint2;

        public static int operator +(EncInt eint1, sbyte eint2) => eint1.Decrypt + eint2;
        public static int operator -(EncInt eint1, sbyte eint2) => eint1.Decrypt - eint2;
        public static int operator *(EncInt eint1, sbyte eint2) => eint1.Decrypt * eint2;
        public static int operator /(EncInt eint1, sbyte eint2) => eint1.Decrypt / eint2;
        public static int operator %(EncInt eint1, sbyte eint2) => eint1.Decrypt % eint2;

        /// == != < >
        public static bool operator ==(EncInt eint1, EncInt eint2) => eint1.Decrypt == eint2.Decrypt;
        public static bool operator !=(EncInt eint1, EncInt eint2) => eint1.Decrypt != eint2.Decrypt;
        public static bool operator <(EncInt eint1, EncInt eint2) => eint1.Decrypt < eint2.Decrypt;
        public static bool operator >(EncInt eint1, EncInt eint2) => eint1.Decrypt > eint2.Decrypt;

        public static bool operator ==(EncInt eint1, ulong eint2) => (ulong)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, ulong eint2) => (ulong)eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, ulong eint2) => (ulong)eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, ulong eint2) => (ulong)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, long eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, long eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, long eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, long eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, uint eint2) => (uint)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, uint eint2) => (uint)eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, uint eint2) => (uint)eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, uint eint2) => (uint)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, int eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, int eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, int eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, int eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, ushort eint2) => (ushort)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, ushort eint2) => (ushort)eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, ushort eint2) => (ushort)eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, ushort eint2) => (ushort)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, short eint2) => (short)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, short eint2) => (short)eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, short eint2) => (short)eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, short eint2) => (short)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, byte eint2) => (byte)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, byte eint2) => (byte)eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, byte eint2) => (byte)eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, byte eint2) => (byte)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, sbyte eint2) => (sbyte)eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, sbyte eint2) => (sbyte)eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, sbyte eint2) => (sbyte)eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, sbyte eint2) => (sbyte)eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, decimal eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, decimal eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, decimal eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, decimal eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, double eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, double eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, double eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, double eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncInt eint1, float eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncInt eint1, float eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncInt eint1, float eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncInt eint1, float eint2) => eint1.Decrypt < eint2;

        /// assign
        public static explicit operator EncInt(ulong value) => new EncInt((int)value);
        public static explicit operator EncInt(long value) => new EncInt((int)value);
        public static explicit operator EncInt(uint value) => new EncInt((int)value);
        public static implicit operator EncInt(int value) => new EncInt(value);
        public static implicit operator EncInt(ushort value) => new EncInt(value);
        public static implicit operator EncInt(short value) => new EncInt(value);
        public static implicit operator EncInt(byte value) => new EncInt(value);
        public static implicit operator EncInt(sbyte value) => new EncInt(value);
        public static explicit operator EncInt(decimal value) => new EncInt((int)value);
        public static explicit operator EncInt(double value) => new EncInt((int)value);
        public static explicit operator EncInt(float value) => new EncInt((int)value);

        public static explicit operator ulong(EncInt eint1) => (ulong)eint1.Decrypt;
        public static implicit operator long(EncInt eint1) => eint1.Decrypt;
        public static explicit operator uint(EncInt eint1) => (uint)eint1.Decrypt;
        public static implicit operator int(EncInt eint1) => eint1.Decrypt;
        public static explicit operator ushort(EncInt eint1) => (ushort)eint1.Decrypt;
        public static explicit operator short(EncInt eint1) => (short)eint1.Decrypt;
        public static explicit operator byte(EncInt eint1) => (byte)eint1.Decrypt;
        public static explicit operator sbyte(EncInt eint1) => (sbyte)eint1.Decrypt;
        public static implicit operator decimal(EncInt eint1) => eint1.Decrypt;
        public static implicit operator double(EncInt eint1) => eint1.Decrypt;
        public static implicit operator float(EncInt eint1) => eint1.Decrypt;

        #endregion
    }
}
