﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsJournalCore.Database.Base;
using StudentsJournalCore.Database.Common;
using StudentsJournalCore.Database.Entities;

namespace StudentsJournalCore.Database.Repositories
{
    public class SubjectsRepository: BaseRepository<int, Subject>
    {
        public SubjectsRepository(DatabaseContext ctx) : base(ctx) { }

        public async override Task<Subject> GetAsync(int id)
        {
            return await table.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async override Task UpdateAsync(Subject value)
        {
            var subject = await GetAsync(value.Id);
            subject.Name = value.Name;

            ctx.Entry(subject).State = EntityState.Modified;
            await ctx.SaveChangesAsync();
        }
    }
}
