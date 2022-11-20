using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Practice_Linear_Search
{
    public class Student
    {
        string _name;
        int _grade;
        string _program;

        public Student(string name, int grade, string program)
        {
            _name = name;
            _grade = grade;
            _program = program;
        }

        public string Name { get => _name; set => _name = value; }
        public int Grade { get => _grade; set => _grade = value; }
        public string Program { get => _program; set => _program = value; }

        public override string ToString()
        {
            return $"{Name} - {Grade} - {Program}";
        }
    }
}
