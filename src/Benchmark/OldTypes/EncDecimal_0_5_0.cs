using System;

namespace Benchmark.OldTypes
{
    public struct EncDecimal_0_5_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Content

        #region Encryption Key Generator

        // The Random class for getting the random numbers
        static private Random random = new Random();

        // Returns a random decimal between 1 and 10
        public static decimal GetEncryptionKey()
        {
            return (decimal)(random.NextDouble());
        }

        #endregion

        #region Variables

        // The encryption values
        private decimal encryptionKey1;
        private decimal encryptionKey2;

        // The encrypted value stored in memory
        private decimal encryptedValue;

        // The decrypted value
        private decimal Value
        {
            set
            {
                encryptedValue = encrypt(value);
            }
            get
            {
                return (decimal)decrypt(encryptedValue);
            }
        }

        #endregion

        #region Constructors

        public static EncDecimal_0_5_0 NewEncDecimal(decimal value)
        {
            EncDecimal_0_5_0 theEncdecimal = new EncDecimal_0_5_0
            {
                encryptionKey1 = GetEncryptionKey(),
                encryptionKey2 = GetEncryptionKey(),
                Value = value
            };
            return theEncdecimal;
        }

        #endregion

        #region Methods

        // Takes a given value and returns it encrypted
        private decimal encrypt(decimal value)
        {
            decimal valueToReturn = value;
            valueToReturn += encryptionKey1;
            valueToReturn *= encryptionKey2;
            return valueToReturn;
        }

        // Takes an encrypted value and returns it decrypted
        private decimal decrypt(decimal value)
        {
            decimal valueToReturn = value;
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
            return obj is EncDecimal_0_5_0 ecndecimal &&
                   Value == ecndecimal.Value;
        }
        public override int GetHashCode()
        {
            return (int)Value;
        }

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncDecimal_0_5_0 operator +(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => EncDecimal_0_5_0.NewEncDecimal(eint1.Value + eint2.Value);
        public static EncDecimal_0_5_0 operator -(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => EncDecimal_0_5_0.NewEncDecimal(eint1.Value - eint2.Value);
        public static EncDecimal_0_5_0 operator *(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => EncDecimal_0_5_0.NewEncDecimal(eint1.Value * eint2.Value);
        public static EncDecimal_0_5_0 operator /(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => EncDecimal_0_5_0.NewEncDecimal(eint1.Value / eint2.Value);
        public static EncDecimal_0_5_0 operator %(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => EncDecimal_0_5_0.NewEncDecimal(eint1.Value % eint2.Value);

        public static decimal operator +(EncDecimal_0_5_0 edecimal1, decimal edecimal2) => edecimal1.Value + edecimal2;
        public static decimal operator -(EncDecimal_0_5_0 edecimal1, decimal edecimal2) => edecimal1.Value - edecimal2;
        public static decimal operator *(EncDecimal_0_5_0 edecimal1, decimal edecimal2) => edecimal1.Value * edecimal2;
        public static decimal operator /(EncDecimal_0_5_0 edecimal1, decimal edecimal2) => edecimal1.Value / edecimal2;
        public static decimal operator %(EncDecimal_0_5_0 edecimal1, decimal edecimal2) => edecimal1.Value % edecimal2;

        /// == != < >
        public static bool operator ==(EncDecimal_0_5_0 eint1, decimal eint2) => eint1.Value == eint2;
        public static bool operator !=(EncDecimal_0_5_0 eint1, decimal eint2) => eint1.Value != eint2;
        public static bool operator >(EncDecimal_0_5_0 eint1, decimal eint2) => eint1.Value > eint2;
        public static bool operator <(EncDecimal_0_5_0 eint1, decimal eint2) => eint1.Value < eint2;

        public static bool operator ==(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncDecimal_0_5_0 eint1, EncDecimal_0_5_0 eint2) => eint1.Value > eint2.Value;

        /// assign
        public static implicit operator EncDecimal_0_5_0(decimal value) => EncDecimal_0_5_0.NewEncDecimal(value);
        public static implicit operator decimal(EncDecimal_0_5_0 eint1) => eint1.Value;

        #endregion

        #endregion
    }
}
