using System;

namespace Benchmark.OldTypes
{
    public struct EncFloat_0_5_0
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
        private float Value
        {
            set
            {
                encryptedValue = encrypt(value);
            }
            get
            {
                return (float)(decrypt(encryptedValue));
            }
        }

        #endregion

        #region Constructors

        public static EncFloat_0_5_0 NewEncFloat(float value)
        {
            EncFloat_0_5_0 theEncFloat = new EncFloat_0_5_0
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
            return obj is EncFloat_0_5_0 ecnFloat &&
                   Value == ecnFloat.Value;
        }
        public override int GetHashCode()
        {
            return (int)Value;
        }

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncFloat_0_5_0 operator +(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => EncFloat_0_5_0.NewEncFloat(eint1.Value + eint2.Value);
        public static EncFloat_0_5_0 operator -(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => EncFloat_0_5_0.NewEncFloat(eint1.Value - eint2.Value);
        public static EncFloat_0_5_0 operator *(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => EncFloat_0_5_0.NewEncFloat(eint1.Value * eint2.Value);
        public static EncFloat_0_5_0 operator /(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => EncFloat_0_5_0.NewEncFloat(eint1.Value / eint2.Value);
        public static EncFloat_0_5_0 operator %(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => EncFloat_0_5_0.NewEncFloat(eint1.Value % eint2.Value);

        public static float operator +(EncFloat_0_5_0 efloat1, float efloat2) => efloat1.Value + efloat2;
        public static float operator -(EncFloat_0_5_0 efloat1, float efloat2) => efloat1.Value - efloat2;
        public static float operator *(EncFloat_0_5_0 efloat1, float efloat2) => efloat1.Value * efloat2;
        public static float operator /(EncFloat_0_5_0 efloat1, float efloat2) => efloat1.Value / efloat2;
        public static float operator %(EncFloat_0_5_0 efloat1, float efloat2) => efloat1.Value % efloat2;

        /// == != < >
        public static bool operator ==(EncFloat_0_5_0 eint1, float eint2) => eint1.Value == eint2;
        public static bool operator !=(EncFloat_0_5_0 eint1, float eint2) => eint1.Value != eint2;
        public static bool operator >(EncFloat_0_5_0 eint1, float eint2) => eint1.Value > eint2;
        public static bool operator <(EncFloat_0_5_0 eint1, float eint2) => eint1.Value < eint2;

        public static bool operator ==(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => eint1.Value == eint2.Value;
        public static bool operator !=(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => eint1.Value != eint2.Value;
        public static bool operator <(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => eint1.Value < eint2.Value;
        public static bool operator >(EncFloat_0_5_0 eint1, EncFloat_0_5_0 eint2) => eint1.Value > eint2.Value;

        /// assign
        public static implicit operator EncFloat_0_5_0(float value) => EncFloat_0_5_0.NewEncFloat(value);
        public static implicit operator float(EncFloat_0_5_0 eint1) => eint1.Value;

        #endregion

        #endregion
    }
}
