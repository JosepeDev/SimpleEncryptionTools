using System;

namespace Benchmark.OldTypes
{
    public struct EncDecimal_0_9_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Variables And Properties

        // The encryption values
        private readonly decimal encryptionKey1;
        private readonly decimal encryptionKey2;

        // The encrypted value stored in memory
        private readonly decimal encryptedValue;

        // The decrypted value
        private decimal Value
        {
            get => Decrypt();
        }

        public Decimal MaxValue { get => Decimal.MaxValue; }
        public Decimal MinValue { get => Decimal.MinValue; }
        public Decimal MinusOne { get => Decimal.MinusOne; }
        public Decimal One { get => Decimal.One; }
        public Decimal Zero { get => Decimal.Zero; }

        #endregion

        #region Methods & Constructors

        private EncDecimal_0_9_0(decimal value)
        {
            encryptionKey1 = (decimal)random.NextDouble();
            encryptionKey2 = (decimal)random.NextDouble();
            encryptedValue = Encrypt(value, encryptionKey1, encryptionKey2);
        }

        // Encryption key generator
        static private Random random = new Random();

        // Takes a given value and returns it encrypted
        private static decimal Encrypt(decimal value, decimal k1, decimal k2) => (value + k1) * k2;

        // Takes an encrypted value and returns it decrypted
        private decimal Decrypt() => (encryptedValue / encryptionKey2) - encryptionKey1;

        // Overrides
        public int CompareTo(Decimal value) => Value.CompareTo(value);
        public int CompareTo(object value) => Value.CompareTo(value);
        public bool Equals(Decimal value) => Value.Equals(value);
        public override bool Equals(object value) => Value.Equals(value);
        public override int GetHashCode() => Value.GetHashCode();
        public TypeCode GetTypeCode() => Value.GetTypeCode();
        public string ToString(string format) => Value.ToString(format);
        public string ToString(IFormatProvider provider) => Value.ToString(provider);
        public override string ToString() => Value.ToString();
        public string ToString(string format, IFormatProvider provider) => Value.ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// + - * / %

        public static EncDecimal_0_9_0 operator +(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => new EncDecimal_0_9_0(eint1.Value + eint2.Value);
        public static EncDecimal_0_9_0 operator -(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => new EncDecimal_0_9_0(eint1.Value - eint2.Value);
        public static EncDecimal_0_9_0 operator *(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => new EncDecimal_0_9_0(eint1.Value * eint2.Value);
        public static EncDecimal_0_9_0 operator /(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => new EncDecimal_0_9_0(eint1.Value / eint2.Value);
        public static EncDecimal_0_9_0 operator %(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => new EncDecimal_0_9_0(eint1.Value % eint2.Value);

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, ulong edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, ulong edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, ulong edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, ulong edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, ulong edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, long edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, long edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, long edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, long edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, long edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, uint edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, uint edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, uint edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, uint edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, uint edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, int edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, int edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, int edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, int edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, int edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, ushort edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, ushort edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, ushort edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, ushort edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, ushort edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, short edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, short edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, short edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, short edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, short edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, byte edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, byte edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, byte edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, byte edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, byte edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, sbyte edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, sbyte edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, sbyte edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, sbyte edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, sbyte edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, decimal edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, decimal edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, decimal edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, decimal edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, decimal edecimal2) => edecimal1.Value % edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, double edecimal2) => edecimal1.Value + (decimal)edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, double edecimal2) => edecimal1.Value - (decimal)edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, double edecimal2) => edecimal1.Value * (decimal)edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, double edecimal2) => edecimal1.Value / (decimal)edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, double edecimal2) => edecimal1.Value % (decimal)edecimal2;

        public static decimal operator +(EncDecimal_0_9_0 edecimal1, float edecimal2) => edecimal1.Value + (decimal)edecimal2;
        public static decimal operator -(EncDecimal_0_9_0 edecimal1, float edecimal2) => edecimal1.Value - (decimal)edecimal2;
        public static decimal operator *(EncDecimal_0_9_0 edecimal1, float edecimal2) => edecimal1.Value * (decimal)edecimal2;
        public static decimal operator /(EncDecimal_0_9_0 edecimal1, float edecimal2) => edecimal1.Value / (decimal)edecimal2;
        public static decimal operator %(EncDecimal_0_9_0 edecimal1, float edecimal2) => edecimal1.Value % (decimal)edecimal2;

        /// == != < >

        public static bool operator ==(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncDecimal_0_9_0 eint1, EncDecimal_0_9_0 eint2) => eint1.Value > eint2.Value;

        public static bool operator ==(EncDecimal_0_9_0 eint1, ulong eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, ulong eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, ulong eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, ulong eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, long eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, long eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, long eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, long eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, uint eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, uint eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, uint eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, uint eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, int eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, int eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, int eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, int eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, ushort eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, ushort eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, ushort eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, ushort eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, short eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, short eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, short eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, short eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, byte eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, byte eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, byte eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, byte eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, sbyte eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, sbyte eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, sbyte eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, sbyte eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, decimal eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, decimal eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, decimal eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, decimal eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, double eint2) => eint1.Value == (decimal)eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, double eint2) => eint1.Value != (decimal)eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, double eint2) => eint1.Value > (decimal)eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, double eint2) => eint1.Value < (decimal)eint2;

        public static bool operator ==(EncDecimal_0_9_0 eint1, float eint2) => eint1.Value == (decimal)eint2;
        public static bool operator !=(EncDecimal_0_9_0 eint1, float eint2) => eint1.Value != (decimal)eint2;
        public static bool operator >(EncDecimal_0_9_0 eint1, float eint2) => eint1.Value > (decimal)eint2;
        public static bool operator <(EncDecimal_0_9_0 eint1, float eint2) => eint1.Value < (decimal)eint2;

        /// assign

        public static implicit operator EncDecimal_0_9_0(decimal value) => new EncDecimal_0_9_0(value);
        public static implicit operator decimal(EncDecimal_0_9_0 eint1) => eint1.Value;
        public static explicit operator double(EncDecimal_0_9_0 eint1) => (double)eint1.Value;
        public static explicit operator float(EncDecimal_0_9_0 eint1) => (float)eint1.Value;
        public static explicit operator ulong(EncDecimal_0_9_0 eint1) => (ulong)eint1.Value;
        public static explicit operator long(EncDecimal_0_9_0 eint1) => (long)eint1.Value;
        public static explicit operator uint(EncDecimal_0_9_0 eint1) => (uint)eint1.Value;
        public static explicit operator int(EncDecimal_0_9_0 eint1) => (int)eint1.Value;
        public static explicit operator ushort(EncDecimal_0_9_0 eint1) => (ushort)eint1.Value;
        public static explicit operator short(EncDecimal_0_9_0 eint1) => (short)eint1.Value;
        public static explicit operator byte(EncDecimal_0_9_0 eint1) => (byte)eint1.Value;
        public static explicit operator sbyte(EncDecimal_0_9_0 eint1) => (sbyte)eint1.Value;

        #endregion
    }
}
