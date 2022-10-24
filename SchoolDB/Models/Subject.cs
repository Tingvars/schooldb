﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Mark> Marks { get; set; }

    }
}
