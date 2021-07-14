using System;

namespace Benchmark.OldTypes
{
    public struct EncLong_0_9_0
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
            get => Math.Round(Decrypt());
        }

        public long MaxValue { get => Int64.MaxValue; }
        public long MinValue { get => Int64.MinValue; }

        #endregion

        #region Methods & Constructors

        private EncLong_0_9_0(decimal value)
        {
            encryptionKey1 = (decimal)random.NextDouble();
            encryptionKey2 = (decimal)random.NextDouble();
            encryptedValue = Encrypt(value, encryptionKey1, encryptionKey2);
        }

        // Encryption Key Generator
        static private Random random = new Random();

        // Takes a given value and returns it encrypted
        private static decimal Encrypt(decimal value, decimal k1, decimal k2) => (value + k1) * k2;

        // Takes an encrypted value and returns it decrypted
        private decimal Decrypt() => (encryptedValue / encryptionKey2) - encryptionKey1;

        // Int64 methods
        public int CompareTo(object value) => ((long)Value).CompareTo(value);
        public int CompareTo(long value) => ((long)Value).CompareTo(value);
        public bool Equals(long obj) => ((long)Value).Equals(obj);
        public override bool Equals(object obj) => ((long)Value).Equals(obj);
        public override int GetHashCode() => ((long)Value).GetHashCode();
        public TypeCode GetTypeCode() => ((long)Value).GetTypeCode();
        public override string ToString() => ((long)Value).ToString();
        public string ToString(IFormatProvider provider) => ((long)Value).ToString(provider);
        public string ToString(string format) => ((long)Value).ToString(format);
        public string ToString(string format, IFormatProvider provider) => ((long)Value).ToString(format, provider);

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncLong_0_9_0 operator +(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => new EncLong_0_9_0(Math.Round(elong1.Decrypt() + elong2.Decrypt()));
        public static EncLong_0_9_0 operator -(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => new EncLong_0_9_0(Math.Round(elong1.Decrypt() - elong2.Decrypt()));
        public static EncLong_0_9_0 operator *(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => new EncLong_0_9_0(Math.Round(elong1.Decrypt() * elong2.Decrypt()));
        public static EncLong_0_9_0 operator /(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => new EncLong_0_9_0(Math.Round(elong1.Decrypt() / elong2.Decrypt()));
        public static EncLong_0_9_0 operator %(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => new EncLong_0_9_0(Math.Round(elong1.Decrypt() % elong2.Decrypt()));

        public static long operator +(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value % elong2;

        public static long operator +(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value % elong2;

        public static long operator +(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value % elong2;

        public static long operator +(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value % elong2;

        public static long operator +(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value % elong2;

        public static long operator +(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value % elong2;

        public static long operator +(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value + elong2;
        public static long operator -(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value - elong2;
        public static long operator *(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value * elong2;
        public static long operator /(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value / elong2;
        public static long operator %(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value % elong2;

        /// == != < >
        /// 

        public static bool operator ==(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, byte elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, sbyte elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, short elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, ushort elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, uint elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, int elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value == elong2;
        public static bool operator !=(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value != elong2;
        public static bool operator >(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value > elong2;
        public static bool operator <(EncLong_0_9_0 elong1, long elong2) => (long)elong1.Value < elong2;

        public static bool operator ==(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => (long)elong1.Value == (long)elong2.Value;
        public static bool operator !=(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => (long)elong1.Value != (long)elong2.Value;
        public static bool operator <(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => (long)elong1.Value < (long)elong2.Value;
        public static bool operator >(EncLong_0_9_0 elong1, EncLong_0_9_0 elong2) => (long)elong1.Value > (long)elong2.Value;

        /// assign
        public static implicit operator EncLong_0_9_0(long value) => new EncLong_0_9_0(value);
        public static explicit operator ulong(EncLong_0_9_0 elong1) => (ulong)elong1.Value;
        public static implicit operator long(EncLong_0_9_0 elong1) => (long)elong1.Value;
        public static explicit operator uint(EncLong_0_9_0 elong1) => (uint)elong1.Value;
        public static explicit operator int(EncLong_0_9_0 elong1) => (int)elong1.Value;
        public static explicit operator ushort(EncLong_0_9_0 elong1) => (ushort)elong1.Value;
        public static explicit operator short(EncLong_0_9_0 elong1) => (short)elong1.Value;
        public static explicit operator byte(EncLong_0_9_0 elong1) => (byte)elong1.Value;
        public static explicit operator sbyte(EncLong_0_9_0 elong1) => (sbyte)elong1.Value;
        public static explicit operator decimal(EncLong_0_9_0 elong1) => elong1.Value;
        public static explicit operator double(EncLong_0_9_0 elong1) => (double)elong1.Value;
        public static explicit operator float(EncLong_0_9_0 elong1) => (float)elong1.Value;

        #endregion
    }
}
