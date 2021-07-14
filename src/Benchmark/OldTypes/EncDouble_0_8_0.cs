using System;

namespace Benchmark.OldTypes
{
    public struct EncDouble_0_8_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Variables And Properties

        // The encryption values
        private double encryptionKey1;
        private double encryptionKey2;

        // The encrypted value stored in memory
        private double encryptedValue;

        // The decrypted value
        public double Value
        {
            set
            {
                encryptedValue = Encrypt(value);
            }
            get
            {
                return Decrypt(encryptedValue);
            }
        }

        public Double Epsilon { get => Double.Epsilon; }
        public Double MaxValue { get => Double.MaxValue; }
        public Double MinValue { get => Double.MinValue; }
        public Double NaN { get => Double.NaN; }
        public Double NegativeInfinity { get => Double.NegativeInfinity; }
        public Double PositiveInfinity { get => Double.PositiveInfinity; }

        #endregion

        #region Methods & Constructors

        private EncDouble_0_8_0(double value)
        {
            encryptionKey1 = GetEncryptionKey();
            encryptionKey2 = GetEncryptionKey();
            encryptedValue = 0;
            Value = value;
        }

        // Encryption key generator
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

        // Overrides
        public int CompareTo(object value) => Value.CompareTo(value);
        public int CompareTo(Double value) => Value.CompareTo(value);
        public bool Equals(Double obj) => Value.Equals(obj);
        public override bool Equals(object obj) => Value.Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public TypeCode GetTypeCode() => Value.GetTypeCode();
        public override string ToString() => Value.ToString();
        public string ToString(IFormatProvider provider) => Value.ToString(provider);
        public string ToString(string format) => Value.ToString(format);
        public string ToString(string format, IFormatProvider provider) => Value.ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncDouble_0_8_0 operator +(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => new EncDouble_0_8_0(eint1.Value + eint2.Value);
        public static EncDouble_0_8_0 operator -(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => new EncDouble_0_8_0(eint1.Value - eint2.Value);
        public static EncDouble_0_8_0 operator *(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => new EncDouble_0_8_0(eint1.Value * eint2.Value);
        public static EncDouble_0_8_0 operator /(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => new EncDouble_0_8_0(eint1.Value / eint2.Value);
        public static EncDouble_0_8_0 operator %(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => new EncDouble_0_8_0(eint1.Value % eint2.Value);

        public static double operator +(EncDouble_0_8_0 edouble1, ulong edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, ulong edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, ulong edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, ulong edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, ulong edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, long edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, long edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, long edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, long edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, long edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, uint edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, uint edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, uint edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, uint edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, uint edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, int edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, int edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, int edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, int edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, int edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, ushort edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, ushort edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, ushort edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, ushort edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, ushort edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, short edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, short edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, short edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, short edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, short edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, byte edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, byte edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, byte edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, byte edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, byte edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, sbyte edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, sbyte edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, sbyte edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, sbyte edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, sbyte edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, double edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, double edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, double edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, double edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, double edouble2) => edouble1.Value % edouble2;

        public static double operator +(EncDouble_0_8_0 edouble1, float edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_8_0 edouble1, float edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_8_0 edouble1, float edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_8_0 edouble1, float edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_8_0 edouble1, float edouble2) => edouble1.Value % edouble2;

        /// == != < >

        public static bool operator ==(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncDouble_0_8_0 eint1, EncDouble_0_8_0 eint2) => eint1.Value > eint2.Value;

        public static bool operator ==(EncDouble_0_8_0 eint1, ulong eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, ulong eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, ulong eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, ulong eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, long eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, long eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, long eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, long eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, uint eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, uint eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, uint eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, uint eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, int eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, int eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, int eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, int eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, ushort eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, ushort eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, ushort eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, ushort eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, short eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, short eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, short eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, short eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, byte eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, byte eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, byte eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, byte eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, sbyte eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, sbyte eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, sbyte eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, sbyte eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, decimal eint2) => (decimal)eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, double eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, double eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, double eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, double eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_8_0 eint1, float eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_8_0 eint1, float eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_8_0 eint1, float eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_8_0 eint1, float eint2) => eint1.Value < eint2;

        /// assign
        public static implicit operator EncDouble_0_8_0(double value) => new EncDouble_0_8_0(value);
        public static explicit operator decimal(EncDouble_0_8_0 eint1) => (decimal)eint1.Value;
        public static implicit operator double(EncDouble_0_8_0 eint1) => eint1.Value;
        public static explicit operator float(EncDouble_0_8_0 eint1) => (float)eint1.Value;
        public static explicit operator ulong(EncDouble_0_8_0 eint1) => (ulong)eint1.Value;
        public static explicit operator long(EncDouble_0_8_0 eint1) => (long)eint1.Value;
        public static explicit operator uint(EncDouble_0_8_0 eint1) => (uint)eint1.Value;
        public static explicit operator int(EncDouble_0_8_0 eint1) => (int)eint1.Value;
        public static explicit operator ushort(EncDouble_0_8_0 eint1) => (ushort)eint1.Value;
        public static explicit operator short(EncDouble_0_8_0 eint1) => (short)eint1.Value;
        public static explicit operator byte(EncDouble_0_8_0 eint1) => (byte)eint1.Value;
        public static explicit operator sbyte(EncDouble_0_8_0 eint1) => (sbyte)eint1.Value;

        #endregion
    }
}
