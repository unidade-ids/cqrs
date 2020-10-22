using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Command
{
    public class UpdateStudentInfoCommand : ICommand
    {
        public int StudentId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public int Grade { get; private set; }

        public UpdateStudentInfoCommand(int id, string first, string last, string email, int grade)
        {
            StudentId = id;
            FirstName = first;
            LastName  = last;
            Email     = email;
            Grade     = grade;
        }
    }
}
