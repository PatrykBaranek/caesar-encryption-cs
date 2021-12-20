using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CaesarEncryptionProject
{
    public class StringValidator
    {
        private readonly string _stringValue;

        public StringValidator(string stringValue)
        {
            _stringValue = stringValue;
        }

        private string CheckValue(string stringValue)
        {
            StringBuilder stringBuilder = new StringBuilder();


            for(int i = 0; i < stringValue.Length; i++)
            {
                if (CaesarEncryption.PolishLettersList.Contains(stringValue[i]))
                {
                    stringBuilder.Append(stringValue[i]);
                }
                else
                {
                    throw new Exception("Input value can't include special characters and numbers");
                }
            }

            return stringBuilder.ToString();
        }


        public string GetValidatedString()
        {
            StringBuilder result = new StringBuilder();


            for (int i = 0; i < _stringValue.Length; i++)
            {
                if (char.IsWhiteSpace(_stringValue[i]))
                {
                    continue;
                }

                result.Append(_stringValue[i]);

            }

            var checkedValue = CheckValue(result.ToString());

            return checkedValue;
        }



    }
}
