using School.Training.Console.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Core.Contracts
{
    public interface IRemoveStudentCommandHandle : ICommandHandle<RemoveStudentCommand>
    {
    }
}
