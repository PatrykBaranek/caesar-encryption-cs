using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncryptionProject
{
    public class StringValidator
    {
        public string StringValue { get; set; }

        private char[] _polishLettersArray = new char[]
        {
            'A','Ą','B','C','Ć','D','E','Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W','X','Z','Ź','Ż'
        };

        public StringValidator(string stringValue)
        {
            StringValue = stringValue;
        }

        


    }
}
