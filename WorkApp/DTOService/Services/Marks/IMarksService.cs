using StudentsJournalCore.DTOService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsJournalCore.DTOService.Services.Marks
{
    public interface IMarksService
    {
        Task CreateNewMark(MarkDTO mark);
        Task<List<MarkDTO>> GetAllMarks();
        Task<MarkDTO> GetMarkById(int id);
        Task UpdateMark(MarkDTO mark);
        Task DeleteMarkById(int id);
    }
}
