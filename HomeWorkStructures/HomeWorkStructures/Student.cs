using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructures
{
    struct Student
    {
            private string _name;
            private byte _age;
            public Student(string name, byte age)
            {
                _name = name;
                _age = age;
            }

        public string Name { get => _name; set => _name = value; }
        public byte Age { get => _age; set => _age = value; }

        public void GetInfoAboutStudent()
        {
            String result;
            result = "NAME = " + Name + ", AGE = " + Age.ToString();
            Console.WriteLine(result);
        }

    }
}
