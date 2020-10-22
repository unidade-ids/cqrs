using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Command
{
    public class RegisterNewStudentCommand : ICommand
    {
        public string Firstname { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public int Grade { get; private set; }

        public RegisterNewStudentCommand(string firstName, string lastName, string email, int grade)
        {
            Firstname = firstName;
            LastName  = lastName;
            Email     = email;
            Grade     = grade;
        }
    }
}
