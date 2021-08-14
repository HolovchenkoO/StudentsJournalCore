using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsJournalCore.Database.Base;

namespace StudentsJournalCore.Database.Entities
{
    public class Mark: BaseEntity<int>
    {
        public int SMark { get; set; }
        public Subject Subject { get; set; }
    }
}
