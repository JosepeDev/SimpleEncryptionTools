using System;

namespace Benchmark.OldTypes
{
    public struct EncInt_0_3_0
    {
        /// An old structure, just used for comparing the older versions of the EncTypes

        #region Content

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
                return Math.Round(decrypt(encryptedValue));
            }
        }

        #endregion

        #region Constructors

        private EncInt_0_3_0(int value)
        {
            // set default values
            encryptionKey1 = 0;
            encryptionKey2 = 0;
            encryptedValue = 0;

            // initialize
            SetEncryptionKeys();
            encryptedValue = encrypt(value);
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

        // Setting the encryption keys to a new random values
        private void SetEncryptionKeys()
        {
            encryptionKey1 = EncryptionTools_0_3_0.RandomNumberDouble();
            encryptionKey2 = EncryptionTools_0_3_0.RandomNumberDouble();
        }

        // Returns the stored value as a string
        public override string ToString()
        {
            return ((int)Value).ToString();
        }

        // Not recommended to use
        public override bool Equals(object obj)
        {
            return obj is EncInt_0_3_0 eint &&
                   (int)Value == (int)eint.Value;
        }
        public override int GetHashCode()
        {
            return (int)Value;
        }

        #endregion

        #region Operators Overloading

        /// + - * / %
        public static EncInt_0_3_0 operator +(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => new EncInt_0_3_0((int)(eint1.Value + eint2.Value));
        public static EncInt_0_3_0 operator -(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => new EncInt_0_3_0((int)(eint1.Value - eint2.Value));
        public static EncInt_0_3_0 operator *(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => new EncInt_0_3_0((int)(eint1.Value * eint2.Value));
        public static EncInt_0_3_0 operator /(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => new EncInt_0_3_0((int)(eint1.Value / eint2.Value));
        public static EncInt_0_3_0 operator %(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => new EncInt_0_3_0((int)(eint1.Value % eint2.Value));

        public static int operator +(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value + eint2;
        public static int operator -(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value - eint2;
        public static int operator *(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value * eint2;
        public static int operator /(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value / eint2;
        public static int operator %(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value % eint2;

        /// == != < >
        public static bool operator ==(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value == eint2;
        public static bool operator !=(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value != eint2;
        public static bool operator >(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value > eint2;
        public static bool operator <(EncInt_0_3_0 eint1, int eint2) => (int)eint1.Value < eint2;

        public static bool operator ==(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => (int)eint1.Value == (int)eint2.Value;
        public static bool operator !=(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => (int)eint1.Value != (int)eint2.Value;
        public static bool operator <(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => (int)eint1.Value < (int)eint2.Value;
        public static bool operator >(EncInt_0_3_0 eint1, EncInt_0_3_0 eint2) => (int)eint1.Value > (int)eint2.Value;

        /// assign
        public static implicit operator EncInt_0_3_0(int value) => new EncInt_0_3_0(value);
        public static implicit operator int(EncInt_0_3_0 eint1) => (int)eint1.Value;

        #endregion

        #endregion
    }
}
