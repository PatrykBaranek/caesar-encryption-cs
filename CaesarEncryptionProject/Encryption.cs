using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncryptionProject
{
    public class Encryption
    {
        private string _inputValue;
        private string _encryptedValue;

        public Encryption(string inputValue)
        {
            _inputValue = inputValue;
        }






        public string GetEncryptedValue()
        {
            return _encryptedValue;
        }
    }
}
