using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(int id, string name, string surname, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Surname: {Surname}, Birth Date: {BirthDate.ToShortDateString()}";
        }



    }
}
