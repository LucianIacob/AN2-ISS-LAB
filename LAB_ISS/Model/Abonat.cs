using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ISS.Model
{
    public class Abonat
    {
        private string _name;
        private string _givenName { get; set; }
        private string _personalCode { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string GivenName
        {
            get
            {
                return _givenName;
            }
            set
            {
                _givenName = value;
            }
        }
        public string PersonalCode
        {
            get
            {
                return _personalCode;
            }
            set
            {
                _personalCode = value;
            }
        }

        public Abonat(string name, string givenname, string personalcode)
        {
            _name = name;
            _givenName = givenname;
            _personalCode = personalcode;
        }

        public override string ToString()
        {
            return _name + " " + _givenName;
        }
    }
}
