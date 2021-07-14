using System;

namespace Benchmark.OldTypes
{
    public struct EncDouble_0_5_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Content

        #region Encryption Key Generator

        // The Random class for getting the random numbers
        static private Random random = new Random();

        // Returns a random double between 1 and 10
        public static double GetEncryptionKey()
        {
            return random.NextDouble();
        }

        #endregion

        #region Variables

        // The encryption values
        private double encryptionKey1;
        private double encryptionKey2;

        // The encrypted value stored in memory
        private double encryptedValue;

        // The decrypted value
        private double Value
        {
            set
            {
                encryptedValue = encrypt(value);
            }
            get
            {
                return decrypt(encryptedValue);
            }
        }

        #endregion

        #region Constructors

        public static EncDouble_0_5_0 NewEncDouble(double value)
        {
            EncDouble_0_5_0 theEncFloat = new EncDouble_0_5_0
            {
                encryptionKey1 = GetEncryptionKey(),
                encryptionKey2 = GetEncryptionKey(),
                Value = value
            };
            return theEncFloat;
        }

        #endregion

        #region Methods

        // Takes a given value and returns it encrypted
        private double encrypt(double value)
        {
            double valueToReturn = value;
            valueToReturn += encryptionKey1;
            valueToReturn *= encryptionKey2;
            return valueToReturn;
        }

        // Takes an encrypted value and returns it decrypted
        private double decrypt(double value)
        {
            double valueToReturn = value;
            valueToReturn /= encryptionKey2;
            valueToReturn -= encryptionKey1;
            return valueToReturn;
        }

        // Returns the stored value as a string
        public override string ToString()
        {
            return (Value).ToString();
        }

        // Not recommended to use
        public override bool Equals(object obj)
        {
            return obj is EncDouble_0_5_0 ecnFloat &&
                   Value == ecnFloat.Value;
        }
        public override int GetHashCode()
        {
            return (int)Value;
        }

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncDouble_0_5_0 operator +(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => EncDouble_0_5_0.NewEncDouble(eint1.Value + eint2.Value);
        public static EncDouble_0_5_0 operator -(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => EncDouble_0_5_0.NewEncDouble(eint1.Value - eint2.Value);
        public static EncDouble_0_5_0 operator *(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => EncDouble_0_5_0.NewEncDouble(eint1.Value * eint2.Value);
        public static EncDouble_0_5_0 operator /(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => EncDouble_0_5_0.NewEncDouble(eint1.Value / eint2.Value);
        public static EncDouble_0_5_0 operator %(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => EncDouble_0_5_0.NewEncDouble(eint1.Value % eint2.Value);

        public static double operator +(EncDouble_0_5_0 edouble1, double edouble2) => edouble1.Value + edouble2;
        public static double operator -(EncDouble_0_5_0 edouble1, double edouble2) => edouble1.Value - edouble2;
        public static double operator *(EncDouble_0_5_0 edouble1, double edouble2) => edouble1.Value * edouble2;
        public static double operator /(EncDouble_0_5_0 edouble1, double edouble2) => edouble1.Value / edouble2;
        public static double operator %(EncDouble_0_5_0 edouble1, double edouble2) => edouble1.Value % edouble2;

        /// == != < >
        public static bool operator ==(EncDouble_0_5_0 eint1, double eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDouble_0_5_0 eint1, double eint2) => eint1.Value != eint2;
        public static bool operator >(EncDouble_0_5_0 eint1, double eint2) => eint1.Value > eint2;
        public static bool operator <(EncDouble_0_5_0 eint1, double eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncDouble_0_5_0 eint1, EncDouble_0_5_0 eint2) => eint1.Value > eint2.Value;

        /// assign
        public static implicit operator EncDouble_0_5_0(double value) => EncDouble_0_5_0.NewEncDouble(value);
        public static implicit operator double(EncDouble_0_5_0 eint1) => eint1.Value;

        #endregion

        #endregion
    }
}
