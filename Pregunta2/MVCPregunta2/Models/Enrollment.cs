﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPregunta2.Models
{
    public enum GradeType
    {
        A=1,
        B=2,
        C=3,
        D=4,
        E=5
    };
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public GradeType Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}