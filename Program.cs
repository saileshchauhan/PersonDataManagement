using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            addPersonData_In_personList(personList);
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(personList);
            Retrieving_All_Record_ForAgeIs_GreaterThan_Equal_ToSixty(personList);
            Searching_For_Name_Of_Person(personList,"Samuel");

        }
        public static void addPersonData_In_personList(List<Person> personList)
        {
            personList.Add(new Person("4578913", "Barack", "Washington", 65));
            personList.Add(new Person("4561333","Donald","NewYork",62));
            personList.Add(new Person("4567895","Sammy","Albama",17));
            personList.Add(new Person("4598962", "Samuel", "NewJersey", 45));
            personList.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            personList.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            personList.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            personList.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
        }
        public static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> personList)
        {
            foreach(Person person in personList.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: "+person.Name+"\t\tAge: "+person.Age);
            }
        }
        //UC5-Find Name of A Person
        public static void Searching_For_Name_Of_Person(List<Person> personList,string name)
        {
            foreach (Person person in personList.FindAll(person => person.Name == name).ToList())
            {
                Console.WriteLine("Person Found " + person.Name + "\t\t Person SSN : " + person.SSN) ;
            }
        }
        //UC6-All Records Above 60
        public static void Retrieving_All_Record_ForAgeIs_GreaterThan_Equal_ToSixty(List<Person> personList)
        {
            foreach (Person person in personList.FindAll(e => (e.Age >= 60)).ToList())
            {
                Console.WriteLine(" Details of person greater than 60 ");
                Console.WriteLine("Name: " + person.Name + "\t\tAge: " + person.Age);
            }
        }


    }
}
