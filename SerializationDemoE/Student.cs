using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializationDemoE
{
    [Serializable]
    internal class Student
    {
        private string _name;
        private double _gpa;
        [NonSerialized]
        private string _password;
        private string _email;

        public string Name { get { return _name; } }
        public double GPA { get { return _gpa; } }
        public string Password { get { return _password; } }

        public Student()
        {

        }

        public Student(string name, double gpa, string password)
        {
            _name = name;
            _gpa = gpa;
            _password = password;
        }
    }
}
