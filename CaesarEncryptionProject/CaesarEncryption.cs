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

        public static List<char> PolishLettersList = new List<char>()
        {
            'A','Ą','B','C','Ć','D','E','Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W','X','Z','Ź','Ż'
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
                        var cipherShiftValue = (letterIndexInList + _keyValue) % 34;

                        if (cipherShiftValue > (PolishLettersList.Count - 1))
                        {
                            cipherShiftValue = cipherShiftValue - 34;
                            result.Append(PolishLettersList[cipherShiftValue]);
                        }
                        
                        result.Append(PolishLettersList[cipherShiftValue]);
                    }
                    break;

                case Method.Decryption:


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
