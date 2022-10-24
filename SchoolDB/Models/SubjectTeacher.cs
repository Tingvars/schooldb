using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Models
{
    public class SubjectTeacher
    {
        public int SubjectTeacherId { get; set; }
        public int TeacherId { get; set; }

    }
    

}
