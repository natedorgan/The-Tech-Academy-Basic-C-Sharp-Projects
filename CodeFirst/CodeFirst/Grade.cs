﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
