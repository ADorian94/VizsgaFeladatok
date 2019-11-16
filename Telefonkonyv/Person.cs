using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonkonyv
{
    public class Person
    {
        private string _name;
        private string _phoneNumber;

        //public string GetName()
        //{
        //    return _name;
        //}

        public string GetName() => _name;
        public string GetPhoneNumber() => _phoneNumber;
        public override string ToString() => _name;

        public Person(string name, string phoneNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
        }
    }
}
