﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPregunta2.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage ="You must enter the field{0}")]
        public string LastName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "You must enter the field{0}")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}