using System;

namespace Benchmark.OldTypes
{
    public struct EncInt_0_9_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Variables And Properties

        // The encryption values
        private readonly double encryptionKey1;
        private readonly double encryptionKey2;

        // The encrypted value stored in memory
        private readonly double encryptedValue;

        // The decrypted value
        private double Value
        {
            get => Math.Round(Decrypt());
        }

        public int MaxValue { get => Int32.MaxValue; }
        public int MinValue { get => Int32.MinValue; }

        #endregion

        #region Methods

        private EncInt_0_9_0(double value)
        {
            encryptionKey1 = random.NextDouble();
            encryptionKey2 = random.NextDouble();
            encryptedValue = Encrypt(value, encryptionKey1, encryptionKey2);
        }

        // Encryption Key Generator
        static private Random random = new Random();

        // Takes a given value and returns it encrypted
        private static double Encrypt(double value, double k1, double k2) => (value + k1) * k2;

        // Takes an encrypted value and returns it decrypted
        private double Decrypt() => (encryptedValue / encryptionKey2) - encryptionKey1;

        // Int32 methods
        public Int32 CompareTo(object value) => ((int)Value).CompareTo(value);
        public Int32 CompareTo(Int32 value) => ((int)Value).CompareTo(value);
        public bool Equals(Int32 obj) => ((int)Value).Equals(obj);
        public override bool Equals(object obj) => ((int)Value).Equals(obj);
        public override Int32 GetHashCode() => ((int)Value).GetHashCode();
        public TypeCode GetTypeCode() => ((int)Value).GetTypeCode();
        public override string ToString() => ((int)Value).ToString();
        public string ToString(IFormatProvider provider) => ((int)Value).ToString(provider);
        public string ToString(string format) => ((int)Value).ToString(format);
        public string ToString(string format, IFormatProvider provider) => ((int)Value).ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncInt_0_9_0 operator +(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => new EncInt_0_9_0((int)Math.Round(eint1.Decrypt() + eint2.Decrypt()));
        public static EncInt_0_9_0 operator -(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => new EncInt_0_9_0((int)Math.Round(eint1.Decrypt() - eint2.Decrypt()));
        public static EncInt_0_9_0 operator *(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => new EncInt_0_9_0((int)Math.Round(eint1.Decrypt() * eint2.Decrypt()));
        public static EncInt_0_9_0 operator /(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => new EncInt_0_9_0((int)Math.Round(eint1.Decrypt() / eint2.Decrypt()));
        public static EncInt_0_9_0 operator %(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => new EncInt_0_9_0((int)Math.Round(eint1.Decrypt() % eint2.Decrypt()));

        public static int operator +(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value + eint2;
        public static int operator -(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value - eint2;
        public static int operator *(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value * eint2;
        public static int operator /(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value / eint2;
        public static int operator %(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value % eint2;

        public static int operator +(EncInt_0_9_0 eint1, ushort eint2) => (int)eint1.Value + eint2;
        public static int operator -(EncInt_0_9_0 eint1, ushort eint2) => (int)eint1.Value - eint2;
        public static int operator *(EncInt_0_9_0 eint1, ushort eint2) => (int)eint1.Value * eint2;
        public static int operator /(EncInt_0_9_0 eint1, ushort eint2) => (int)eint1.Value / eint2;
        public static int operator %(EncInt_0_9_0 eint1, ushort eint2) => (int)eint1.Value % eint2;

        public static int operator +(EncInt_0_9_0 eint1, short eint2) => (int)eint1.Value + eint2;
        public static int operator -(EncInt_0_9_0 eint1, short eint2) => (int)eint1.Value - eint2;
        public static int operator *(EncInt_0_9_0 eint1, short eint2) => (int)eint1.Value * eint2;
        public static int operator /(EncInt_0_9_0 eint1, short eint2) => (int)eint1.Value / eint2;
        public static int operator %(EncInt_0_9_0 eint1, short eint2) => (int)eint1.Value % eint2;

        public static int operator +(EncInt_0_9_0 eint1, byte eint2) => (int)eint1.Value + eint2;
        public static int operator -(EncInt_0_9_0 eint1, byte eint2) => (int)eint1.Value - eint2;
        public static int operator *(EncInt_0_9_0 eint1, byte eint2) => (int)eint1.Value * eint2;
        public static int operator /(EncInt_0_9_0 eint1, byte eint2) => (int)eint1.Value / eint2;
        public static int operator %(EncInt_0_9_0 eint1, byte eint2) => (int)eint1.Value % eint2;

        public static int operator +(EncInt_0_9_0 eint1, sbyte eint2) => (int)eint1.Value + eint2;
        public static int operator -(EncInt_0_9_0 eint1, sbyte eint2) => (int)eint1.Value - eint2;
        public static int operator *(EncInt_0_9_0 eint1, sbyte eint2) => (int)eint1.Value * eint2;
        public static int operator /(EncInt_0_9_0 eint1, sbyte eint2) => (int)eint1.Value / eint2;
        public static int operator %(EncInt_0_9_0 eint1, sbyte eint2) => (int)eint1.Value % eint2;

        /// == != < >

        public static bool operator ==(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncInt_0_9_0 eint1, EncInt_0_9_0 eint2) => eint1.Value > eint2.Value;

        public static bool operator ==(EncInt_0_9_0 eint1, ulong eint2) => (ulong)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, ulong eint2) => (ulong)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, ulong eint2) => (ulong)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, ulong eint2) => (ulong)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, long eint2) => (long)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, long eint2) => (long)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, long eint2) => (long)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, long eint2) => (long)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, uint eint2) => (uint)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, uint eint2) => (uint)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, uint eint2) => (uint)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, uint eint2) => (uint)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, int eint2) => (int)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, ushort eint2) => (ushort)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, ushort eint2) => (ushort)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, ushort eint2) => (ushort)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, ushort eint2) => (ushort)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, short eint2) => (short)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, short eint2) => (short)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, short eint2) => (short)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, short eint2) => (short)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, byte eint2) => (byte)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, byte eint2) => (byte)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, byte eint2) => (byte)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, byte eint2) => (byte)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, sbyte eint2) => (sbyte)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, sbyte eint2) => (sbyte)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, sbyte eint2) => (sbyte)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, sbyte eint2) => (sbyte)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, decimal eint2) => (decimal)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, decimal eint2) => (decimal)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, decimal eint2) => (decimal)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, decimal eint2) => (decimal)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, double eint2) => (double)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, double eint2) => (double)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, double eint2) => (double)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, double eint2) => (double)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_9_0 eint1, float eint2) => (float)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_9_0 eint1, float eint2) => (float)eint1.Value != eint2;
        public static bool operator >(EncInt_0_9_0 eint1, float eint2) => (float)eint1.Value > eint2;
        public static bool operator <(EncInt_0_9_0 eint1, float eint2) => (float)eint1.Value < eint2;

        /// assign
        public static implicit operator EncInt_0_9_0(int value) => new EncInt_0_9_0(value);
        public static explicit operator ulong(EncInt_0_9_0 eint1) => (ulong)eint1.Value;
        public static implicit operator long(EncInt_0_9_0 eint1) => (long)eint1.Value;
        public static explicit operator uint(EncInt_0_9_0 eint1) => (uint)eint1.Value;
        public static implicit operator int(EncInt_0_9_0 eint1) => (int)eint1.Value;
        public static explicit operator ushort(EncInt_0_9_0 eint1) => (ushort)eint1.Value;
        public static explicit operator short(EncInt_0_9_0 eint1) => (short)eint1.Value;
        public static explicit operator byte(EncInt_0_9_0 eint1) => (byte)eint1.Value;
        public static explicit operator sbyte(EncInt_0_9_0 eint1) => (sbyte)eint1.Value;
        public static explicit operator decimal(EncInt_0_9_0 eint1) => (decimal)eint1.Value;
        public static explicit operator double(EncInt_0_9_0 eint1) => eint1.Value;
        public static explicit operator float(EncInt_0_9_0 eint1) => (float)eint1.Value;

        #endregion
    }
}
