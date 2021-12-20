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
        private string _stringValue;

        private Regex regex = new Regex("/\\[!@#\\$%\\^&\\*\\(\\)_\\+\\\\-=\\\\\\[\\\\]\\{\\};':\"\\\\\\\\|,\\.<>\\\\/\\?0-9]\\+/", RegexOptions.IgnoreCase);


        public StringValidator(string stringValue)
        {
            _stringValue = stringValue;
        }


        public string GetValidatedString()
        {
            StringBuilder result = new StringBuilder();

            //if (!regex.IsMatch(_stringValue))
            //{
            //    throw new Exception("Input value can't include special characters and numbers");
            //}

            for (int i = 0; i < _stringValue.Length; i++)
            {
                if (char.IsWhiteSpace(_stringValue[i]))
                {
                    continue;
                }

                result.Append(_stringValue[i]);

            }

            return result.ToString();
        }



    }
}
