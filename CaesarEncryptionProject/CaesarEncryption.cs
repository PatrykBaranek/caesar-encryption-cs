using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncryptionProject
{
    public class CaesarEncryption
    {
        private string _inputValue;
        private int _keyValue;
        private string _encryptedValue;
        private string _decryptedValue;

        public static char[] PolishLettersArray = new char[]
        {
            'A','Ą','B','C','Ć','D','E','Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W','X','Z','Ź','Ż'
        };

        public CaesarEncryption(string inputValue, string keyValue)
        {
            _inputValue = inputValue.Trim().ToLower();
            _keyValue = int.Parse(keyValue);
            _encryptedValue = String.Empty;
        }

        public string GetEncryptedValue()
        {
            StringBuilder result = new StringBuilder();

            StringValidator stringValidator = new StringValidator(_inputValue);

            var validatedInputValue = stringValidator.GetValidatedString();


            result.Append(validatedInputValue);

            _encryptedValue = result.ToString();

            return _encryptedValue;
        }


        public string GetDecryptedValue()
        {
            return _decryptedValue;
        }
    }
}
