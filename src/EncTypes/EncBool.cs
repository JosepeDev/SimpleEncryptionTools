using System;

namespace EncTypes
{
    public struct EncBool
    {
        /// Of all the encrypted values you could've picked.
        /// You thought you would need an encrypted bool.
        /// You're a failure as a human being and a waste of life.

        #region Variables

        // The encrypted bool
        readonly bool _encryptedValue;

        #endregion

        #region Properties

        // The decrypted value of the bool
        private bool Decrypt { get => !_encryptedValue; }

        // Boolean properties
        public static string FalseString { get => Boolean.FalseString; }
        public static string TrueString { get => Boolean.TrueString; }

        #endregion

        #region Constructors

        // A private constructor, used by implicit and explicit operators
        private EncBool(bool value) => _encryptedValue = Encrypt(value);

        #endregion

        #region Methods

        // A method that takes a boolean and returns it encrypted
        static bool Encrypt(bool boolVar) => !boolVar;

        // Boolean methods
        public int CompareTo(Boolean value) => Decrypt.CompareTo(value);
        public int CompareTo(object obj) => Decrypt.CompareTo(obj);
        public Boolean Equals(Boolean obj) => Decrypt.Equals(obj);
        public override Boolean Equals(object obj) => Decrypt.Equals(obj);
        public override int GetHashCode() => Decrypt.GetHashCode();
        public TypeCode GetTypeCode() => Decrypt.GetTypeCode();
        public override string ToString() => Decrypt.ToString();
        public string ToString(IFormatProvider provider) => Decrypt.ToString(provider);

        #endregion

        #region Operators Overloading

        public static bool operator ==(EncBool eint1, bool eint2) => eint1.Decrypt == eint2;
        public static bool operator !=(EncBool eint1, bool eint2) => eint1.Decrypt != eint2;

        public static bool operator ==(EncBool eint1, EncBool eint2) => eint1.Decrypt == eint2.Decrypt;
        public static bool operator !=(EncBool eint1, EncBool eint2) => eint1.Decrypt != eint2.Decrypt;

        public static implicit operator EncBool(bool value) => new EncBool(value);
        public static implicit operator bool(EncBool eint1) => eint1._encryptedValue;

        #endregion
    }
}
