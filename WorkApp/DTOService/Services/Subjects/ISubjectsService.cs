using StudentsJournalCore.DTOService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsJournalCore.DTOService.Services.Subjects
{
    public interface ISubjectsService
    {
        Task CreateNewSubject(SubjectDTO subject);
        Task<List<SubjectDTO>> GetAllSubjects();
        Task<SubjectDTO> GetSubjectById(int id);
    }
}
