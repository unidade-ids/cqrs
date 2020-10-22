﻿using School.Training.Console.Core.Queries;
using School.Training.Console.Core.Queries.Contracts;
using School.Training.Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Training.Console.Core.Handlers.Queries
{
    public class GetAllStudentQueryHandle : IQueryHandle<Student, GetAllStudentsQuery>
    {
        public GetAllStudentsQuery Handle(Student query)
        {
            throw new NotImplementedException();
        }
    }
}
