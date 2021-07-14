using System;

namespace Benchmark.OldTypes
{
    public struct EncFloat_0_8_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Variables And Properties

        // The encryption values
        private double encryptionKey1;
        private double encryptionKey2;

        // The encrypted value stored in memory
        private double encryptedValue;

        // The decrypted value
        private float Value
        {
            set
            {
                encryptedValue = Encrypt(value);
            }
            get
            {
                return (float)(Decrypt(encryptedValue));
            }
        }

        public float Epsilon { get => Single.Epsilon; }
        public float MaxValue { get => Single.MaxValue; }
        public float MinValue { get => Single.MinValue; }
        public float NaN { get => Single.NaN; }
        public float NegativeInfinity { get => Single.NegativeInfinity; }
        public float PositiveInfinity { get => Single.PositiveInfinity; }

        #endregion

        #region Methods & Constructors

        private EncFloat_0_8_0(float value)
        {
            encryptionKey1 = GetEncryptionKey();
            encryptionKey2 = GetEncryptionKey();
            encryptedValue = 0;
            Value = value;
        }

        private static EncFloat_0_8_0 NewEncFloat(float value)
        {
            EncFloat_0_8_0 theEncFloat = new EncFloat_0_8_0
            {
                encryptionKey1 = GetEncryptionKey(),
                encryptionKey2 = GetEncryptionKey(),
                Value = value
            };
            return theEncFloat;
        }

        // encryption key generator
        static private Random random = new Random();
        static private double GetEncryptionKey() => random.NextDouble();

        // Takes a given value and returns it encrypted
        private double Encrypt(double value)
        {
            double valueToReturn = value;
            valueToReturn += encryptionKey1;
            valueToReturn *= encryptionKey2;
            return valueToReturn;
        }

        // Takes an encrypted value and returns it decrypted
        private double Decrypt(double value)
        {
            double valueToReturn = value;
            valueToReturn /= encryptionKey2;
            valueToReturn -= encryptionKey1;
            return valueToReturn;
        }

        // Single methods
        public int CompareTo(Single value) => Value.CompareTo(value);
        public int CompareTo(object value) => Value.CompareTo(value);
        public override bool Equals(object obj) => Value.Equals(obj);
        public bool Equals(Single obj) => Value.Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public TypeCode GetTypeCode() => Value.GetTypeCode();
        public override string ToString() => Value.ToString();
        public string ToString(IFormatProvider provider) => Value.ToString(provider);
        public string ToString(string format) => Value.ToString(format);
        public string ToString(string format, IFormatProvider provider) => Value.ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncFloat_0_8_0 operator +(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => new EncFloat_0_8_0(eint1.Value + eint2.Value);
        public static EncFloat_0_8_0 operator -(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => new EncFloat_0_8_0(eint1.Value - eint2.Value);
        public static EncFloat_0_8_0 operator *(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => new EncFloat_0_8_0(eint1.Value * eint2.Value);
        public static EncFloat_0_8_0 operator /(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => new EncFloat_0_8_0(eint1.Value / eint2.Value);
        public static EncFloat_0_8_0 operator %(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => new EncFloat_0_8_0(eint1.Value % eint2.Value);

        public static float operator +(EncFloat_0_8_0 efloat1, ulong efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, ulong efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, ulong efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, ulong efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, ulong efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, long efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, long efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, long efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, long efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, long efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, uint efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, uint efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, uint efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, uint efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, uint efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, int efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, int efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, int efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, int efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, int efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, ushort efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, ushort efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, ushort efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, ushort efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, ushort efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, short efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, short efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, short efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, short efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, short efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, byte efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, byte efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, byte efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, byte efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, byte efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, sbyte efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, sbyte efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, sbyte efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, sbyte efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, sbyte efloat2) => efloat1.Value % efloat2;

        public static float operator +(EncFloat_0_8_0 efloat1, float efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_8_0 efloat1, float efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_8_0 efloat1, float efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_8_0 efloat1, float efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_8_0 efloat1, float efloat2) => efloat1.Value % efloat2;

        /// == != < >

        public static bool operator ==(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncFloat_0_8_0 eint1, EncFloat_0_8_0 eint2) => eint1.Value > eint2.Value;

        public static bool operator ==(EncFloat_0_8_0 eint1, ulong eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, ulong eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, ulong eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, ulong eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, long eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, long eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, long eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, long eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, uint eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, uint eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, uint eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, uint eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, int eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, int eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, int eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, int eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, ushort eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, ushort eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, ushort eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, ushort eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, short eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, short eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, short eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, short eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, byte eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, byte eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, byte eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, byte eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, sbyte eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, sbyte eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, sbyte eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, sbyte eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, double eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, double eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, double eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, double eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_8_0 eint1, float eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_8_0 eint1, float eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_8_0 eint1, float eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_8_0 eint1, float eint2) => eint1.Value < eint2;

        /// assign
        public static implicit operator EncFloat_0_8_0(float value) => new EncFloat_0_8_0(value);
        public static explicit operator decimal(EncFloat_0_8_0 eint1) => (decimal)eint1.Value;
        public static implicit operator double(EncFloat_0_8_0 eint1) => eint1.Value;
        public static implicit operator float(EncFloat_0_8_0 eint1) => eint1.Value;
        public static explicit operator ulong(EncFloat_0_8_0 eint1) => (ulong)eint1.Value;
        public static explicit operator long(EncFloat_0_8_0 eint1) => (long)eint1.Value;
        public static explicit operator uint(EncFloat_0_8_0 eint1) => (uint)eint1.Value;
        public static explicit operator int(EncFloat_0_8_0 eint1) => (int)eint1.Value;
        public static explicit operator ushort(EncFloat_0_8_0 eint1) => (ushort)eint1.Value;
        public static explicit operator short(EncFloat_0_8_0 eint1) => (short)eint1.Value;
        public static explicit operator byte(EncFloat_0_8_0 eint1) => (byte)eint1.Value;
        public static explicit operator sbyte(EncFloat_0_8_0 eint1) => (sbyte)eint1.Value;

        #endregion
    }
}
