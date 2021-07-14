using System;

namespace EncTypes
{
    public struct EncFloat
    {
        /// A struct for storing a Single (float) while efficiently keeping it encrypted in the memory
        /// Instead of encrypting and decrypting yourself, you can just use the encrypted type (EncType) of the variable you want to be encrypted
        /// The encryption will happen in the background without you worrying about it
        /// In the memory it is saved as a an array of weird bytes that are affected by random values { encryptionKeys array }
        /// Every time the value changes, the encryption keys change too. And it works exactly as an float (Single)
        ///
        /// WIKI AND INFO: https://github.com/JosepeDev/VarEnc

        #region Variables And Properties

        private readonly byte[] encryptionKeys;
        private readonly byte[] encryptedValue;

        private float Decrypt
        {
            get
            {
                var valueBytes = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    valueBytes[i] = (byte)(encryptedValue[i] ^ encryptionKeys[i]);
                }
                return BitConverter.ToSingle(valueBytes, 0);
            }
        }

        public static float Epsilon { get => Single.Epsilon; }
        public static float MaxValue { get => Single.MaxValue; }
        public static float MinValue { get => Single.MinValue; }
        public static float NaN { get => Single.NaN; }
        public static float NegativeInfinity { get => Single.NegativeInfinity; }
        public static float PositiveInfinity { get => Single.PositiveInfinity; }

        #endregion

        #region Methods And Constructors

        private EncFloat(float value)
        {
            encryptionKeys = new byte[4];
            encryptedValue = Encrypt(value, encryptionKeys);
        }

        static private Random random = new Random();

        private static byte[] Encrypt(float value, byte[] keys)
        {
            random.NextBytes(keys);
            var valueBytes = BitConverter.GetBytes(value);
            for (int i = 0; i < 4; i++)
            {
                valueBytes[i] ^= keys[i];
            }
            return valueBytes;
        }

        public int CompareTo(Single value) => Decrypt.CompareTo(value);
        public int CompareTo(object value) => Decrypt.CompareTo(value);
        public override bool Equals(object obj) => Decrypt.Equals(obj);
        public bool Equals(Single obj) => Decrypt.Equals(obj);
        public override int GetHashCode() => Decrypt.GetHashCode();
        public TypeCode GetTypeCode() => Decrypt.GetTypeCode();
        public override string ToString() => Decrypt.ToString();
        public string ToString(IFormatProvider provider) => Decrypt.ToString(provider);
        public string ToString(string format) => Decrypt.ToString(format);
        public string ToString(string format, IFormatProvider provider) => Decrypt.ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncFloat operator +(EncFloat eint1, EncFloat eint2) => new EncFloat(eint1.Decrypt + eint2.Decrypt);
        public static EncFloat operator -(EncFloat eint1, EncFloat eint2) => new EncFloat(eint1.Decrypt - eint2.Decrypt);
        public static EncFloat operator *(EncFloat eint1, EncFloat eint2) => new EncFloat(eint1.Decrypt * eint2.Decrypt);
        public static EncFloat operator /(EncFloat eint1, EncFloat eint2) => new EncFloat(eint1.Decrypt / eint2.Decrypt);
        public static EncFloat operator %(EncFloat eint1, EncFloat eint2) => new EncFloat(eint1.Decrypt % eint2.Decrypt);

        public static float operator +(EncFloat efloat1, ulong efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, ulong efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, ulong efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, ulong efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, ulong efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, long efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, long efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, long efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, long efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, long efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, uint efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, uint efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, uint efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, uint efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, uint efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, int efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, int efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, int efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, int efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, int efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, ushort efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, ushort efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, ushort efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, ushort efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, ushort efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, short efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, short efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, short efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, short efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, short efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, byte efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, byte efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, byte efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, byte efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, byte efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, sbyte efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, sbyte efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, sbyte efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, sbyte efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, sbyte efloat2) => efloat1.Decrypt % efloat2;

        public static float operator +(EncFloat efloat1, float efloat2) => efloat1.Decrypt + efloat2;
        public static float operator -(EncFloat efloat1, float efloat2) => efloat1.Decrypt - efloat2;
        public static float operator *(EncFloat efloat1, float efloat2) => efloat1.Decrypt * efloat2;
        public static float operator /(EncFloat efloat1, float efloat2) => efloat1.Decrypt / efloat2;
        public static float operator %(EncFloat efloat1, float efloat2) => efloat1.Decrypt % efloat2;

        /// == != < >
        public static bool operator ==(EncFloat eint1, EncFloat eint2) => eint1.Decrypt == eint2.Decrypt;
        public static bool operator !=(EncFloat eint1, EncFloat eint2) => eint1.Decrypt != eint2.Decrypt;
        public static bool operator <(EncFloat eint1, EncFloat eint2) => eint1.Decrypt < eint2.Decrypt;
        public static bool operator >(EncFloat eint1, EncFloat eint2) => eint1.Decrypt > eint2.Decrypt;

        public static bool operator ==(EncFloat eint1, ulong eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, ulong eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, ulong eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, ulong eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, long eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, long eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, long eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, long eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, uint eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, uint eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, uint eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, uint eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, int eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, int eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, int eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, int eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, ushort eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, ushort eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, ushort eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, ushort eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, short eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, short eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, short eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, short eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, byte eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, byte eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, byte eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, byte eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, sbyte eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, sbyte eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, sbyte eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, sbyte eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, decimal eint2) => (decimal)eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, decimal eint2) => (decimal)eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, decimal eint2) => (decimal)eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, decimal eint2) => (decimal)eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, double eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, double eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, double eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, double eint2) => eint1.Decrypt < eint2;

        public static bool operator ==(EncFloat eint1, float eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncFloat eint1, float eint2) => eint1.Decrypt != eint2;
        public static bool operator >(EncFloat eint1, float eint2) => eint1.Decrypt > eint2;
        public static bool operator <(EncFloat eint1, float eint2) => eint1.Decrypt < eint2;

        /// assign
        public static implicit operator EncFloat(ulong value) => new EncFloat(value);
        public static implicit operator EncFloat(long value) => new EncFloat(value);
        public static implicit operator EncFloat(uint value) => new EncFloat(value);
        public static implicit operator EncFloat(int value) => new EncFloat(value);
        public static implicit operator EncFloat(ushort value) => new EncFloat(value);
        public static implicit operator EncFloat(short value) => new EncFloat(value);
        public static implicit operator EncFloat(byte value) => new EncFloat(value);
        public static implicit operator EncFloat(sbyte value) => new EncFloat(value);
        public static explicit operator EncFloat(decimal value) => new EncFloat((float)value);
        public static explicit operator EncFloat(double value) => new EncFloat((float)value);
        public static implicit operator EncFloat(float value) => new EncFloat(value);

        public static explicit operator decimal(EncFloat eint1) => (decimal)eint1.Decrypt;
        public static implicit operator double(EncFloat eint1) => eint1.Decrypt;
        public static implicit operator float(EncFloat eint1) => eint1.Decrypt;
        public static explicit operator ulong(EncFloat eint1) => (ulong)eint1.Decrypt;
        public static explicit operator long(EncFloat eint1) => (long)eint1.Decrypt;
        public static explicit operator uint(EncFloat eint1) => (uint)eint1.Decrypt;
        public static explicit operator int(EncFloat eint1) => (int)eint1.Decrypt;
        public static explicit operator ushort(EncFloat eint1) => (ushort)eint1.Decrypt;
        public static explicit operator short(EncFloat eint1) => (short)eint1.Decrypt;
        public static explicit operator byte(EncFloat eint1) => (byte)eint1.Decrypt;
        public static explicit operator sbyte(EncFloat eint1) => (sbyte)eint1.Decrypt;

        #endregion
    }
}
