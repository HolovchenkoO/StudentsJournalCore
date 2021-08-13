using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsJournalCore.DTOService.DTO
{
    public class MarkDTO
    {
        public int Id { get; set; }
        public int SMark { get; set; }
        public SubjectDTO Subject { get; set; }
    }
}
