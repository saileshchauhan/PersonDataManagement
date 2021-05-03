using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDataManagement
{
    class Person
    {
        public string SSN;
        public string Name;
        public string Adress;
        public int Age;

        public Person(string ssn,string name,string adress,int age)
        {
            this.SSN = ssn;
            this.Name = name;
            this.Adress = adress;
            this.Age = age;
        }
    }
}
