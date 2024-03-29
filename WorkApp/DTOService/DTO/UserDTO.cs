﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static StudentsJournalCore.Database.Entities.User;

namespace StudentsJournalCore.DTOService.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthRole Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
        public ICollection<MarkDTO> Marks { get; set; }
    }
}
