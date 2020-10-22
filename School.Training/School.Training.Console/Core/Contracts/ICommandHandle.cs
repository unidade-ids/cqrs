﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Command
{
    public interface ICommandHandle<TCommand> where TCommand : ICommand 
    {
        void Handle(TCommand command);
    }
}
