using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsJournalCore.Database.Common;
using StudentsJournalCore.Database.Repositories;

namespace StudentsJournalCore.Database.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private static UnitOfWork instance;
        public static UnitOfWork Instance => instance ?? (instance = new UnitOfWork());
        DatabaseContext ctx;

        SubjectsRepository _subjectsRepository;
        MarksRepository _marksRepository;
        UsersRepository _usersRepository;

        public SubjectsRepository SubjectsRepository => _subjectsRepository
            ?? (_subjectsRepository = new SubjectsRepository(ctx));

        public MarksRepository MarksRepository => _marksRepository
            ?? (_marksRepository = new MarksRepository(ctx));

        public UsersRepository UsersRepository => _usersRepository
            ?? (_usersRepository = new UsersRepository(ctx));


        public UnitOfWork(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }

        public UnitOfWork()
        {
            ctx = new DatabaseContext();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    ctx.Dispose();

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
