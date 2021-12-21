using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncryptionProject
{
    public class CaesarEncryption
    {
        private readonly string _inputValue;
        private readonly int _keyValue;
        private string _encryptedValue;
        private string _decryptedValue;

        public static List<char> PolishLettersList = new List<char>()
        {
            'A','Ą','B','C','Ć','D','E','Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W','X','Y','Z','Ź','Ż'
        };

        public CaesarEncryption(string inputValue, string keyValue)
        {
            _inputValue = inputValue.Trim().ToUpper();
            _keyValue = int.Parse(keyValue);
            _encryptedValue = string.Empty;
            _decryptedValue = string.Empty;
        }

        private string EncryptionOrDecryption(Method method)
        {
            StringBuilder result = new StringBuilder();

            StringValidator stringValidator = new StringValidator(_inputValue);

            var validatedInputValue = stringValidator.GetValidatedString();


            switch (method)
            {
                case Method.Encryption:

                    for (int i = 0; i < validatedInputValue.Length; i++)
                    {
                        var letterIndexInList = PolishLettersList.IndexOf(validatedInputValue[i]);
                        var cipherShiftValue = (letterIndexInList + _keyValue) % 35;

                        if (cipherShiftValue > (PolishLettersList.Count - 1))
                        {
                            cipherShiftValue -= 35;
                            result.Append(PolishLettersList[cipherShiftValue]);

                            continue;
                        }

                        result.Append(PolishLettersList[cipherShiftValue]);
                    }

                    break;

                case Method.Decryption:

                    for (int i = 0; i < validatedInputValue.Length; i++)
                    {
                        var letterIndexInList = PolishLettersList.IndexOf(validatedInputValue[i]);
                        var cipherShiftValue = (letterIndexInList - _keyValue) % 35;

                        if (cipherShiftValue < 0)
                        {
                            cipherShiftValue += 35;
                            result.Append(PolishLettersList[cipherShiftValue]);

                            continue;
                        }
                        

                        result.Append(PolishLettersList[cipherShiftValue]);
                    }

                    break;

            }

            return result.ToString();
        }


        public string GetEncryptedValue()
        {

            _encryptedValue = EncryptionOrDecryption(Method.Encryption);

            return _encryptedValue;
        }


        public string GetDecryptedValue()
        {
            _decryptedValue = EncryptionOrDecryption(Method.Decryption);

            return _decryptedValue;
        }
    }
}
