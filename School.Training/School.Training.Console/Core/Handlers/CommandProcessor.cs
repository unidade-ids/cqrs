using School.Training.Console.Command;
using School.Training.Console.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Core.Handlers
{
    public class CommandProcessor : ICommandProcessor
    {
        public void Process<TCommand>(TCommand command) where TCommand : ICommand
        {
            var commandHandlerType     = typeof(ICommandHandle<TCommand>);
            var targetHandlerInterface = AppDomain.CurrentDomain
                                                  .GetAssemblies()
                                                  .SelectMany(s => s.GetTypes())
                                                  .FirstOrDefault(t => commandHandlerType.IsAssignableFrom(t) && t.IsInterface);

            if (targetHandlerInterface == null) return;

            //dynamic targetHandler = _context.Resolve(targetHandlerInterface);
            //targetHandler.Handle(command);
        }
    }
}
