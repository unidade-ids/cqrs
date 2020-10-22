using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Command
{
    public class RemoveStudentCommand : ICommand
    {
        public int IdStudent { get; private set; }

        public RemoveStudentCommand(int id)
        {
            IdStudent = id;
        }
    }
}
