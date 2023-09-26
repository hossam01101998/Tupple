// See https://aka.ms/new-console-template for more information
using ConsoleApp6;
using Diversen;

Console.WriteLine("Hello, World!");

Student student = new Student { Voornaam = "Jamil", ID = 1 , Familienaam = "NARO", Inschrijving = DateTime.Now};


string voornaam, achternaam;

Tuple<string, string> NaamVanStudent = Student.Naam(1);

voornaam = NaamVanStudent.Item1;
achternaam = NaamVanStudent.Item2;




