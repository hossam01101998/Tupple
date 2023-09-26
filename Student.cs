using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Student
    {
        public int ID { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public DateTime Inschrijving { get; set; }
        static List<Student> studenten = new List<Student>();

        public Student() {
            studenten.Add(this);

        }

        public Tuple<string, string> Naam(int ID)
        {
            Student student = null;
            foreach (Student s in studenten)
                if (s.ID == ID)
                    student = s;
            return Tuple.Create (student.Voornaam, student.Familienaam);
        }

        public override string ToString()
        {
            return "Id = " + ID + base.ToString;
        }
        

        public static StudentenNaam StructNaam (int id)
        {
            Student student = null;
            foreach (Student s in studenten)
                if (s.ID == id)
                    student = s;
            StudentenNaam sn = new StudentenNaam();
            return new StudentenNaam { Voornaam = student.Voornaam, Familienaam = student.Familienaam };
        }
        public struct StudentenNaam
        {
            public string Voornaam { get; set; }
            public string Familienaam { get; set; }
            public override string ToString()
            {
                return "Naam = " + Voornaam + " " + Familienaam;

            }
        }

        

    }
}
