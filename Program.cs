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
            Retrieving_AllRecords_Btw_Age13_To_18(personList);

        }
        public static void addPersonData_In_personList(List<Person> personList)
        {
            personList.Add(new Person("4578913", "Barack", "Washington", 65));
            personList.Add(new Person("4561333","Donald","NewYork",62));
            personList.Add(new Person("4567895","Sammy","Albama",17));
            personList.Add(new Person("4598962", "Samuel", "NewJersey", 14));
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
        public static void Retrieving_AllRecords_Btw_Age13_To_18(List<Person> personList)
        {
            Console.WriteLine("Details of Person Between age of 13 to 18");
            foreach (Person person in personList.FindAll(e=>(e.Age>=13 && e.Age <= 18)).ToList())
            {
                Console.WriteLine("Name: "+person.Name+"\t\tAge:"+person.Age);
            }
        }
    }
}
