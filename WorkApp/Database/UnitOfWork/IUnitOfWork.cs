using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsJournalCore.Database.Repositories;

namespace StudentsJournalCore.Database.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        SubjectsRepository SubjectsRepository { get; }
        MarksRepository MarksRepository { get; }
        UsersRepository UsersRepository { get; }
    }
}
