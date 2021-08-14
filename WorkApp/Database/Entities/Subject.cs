using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsJournalCore.Database.Base;

namespace StudentsJournalCore.Database.Entities
{
    public class Subject: BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
