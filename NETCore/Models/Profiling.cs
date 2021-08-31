﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCore.Models
{
    [Table("tb_m_profilings")]
    public class Profiling
    {
        [Key]
        public string NIK { get; set; }
        [Required]
        public int EducationId { get; set; }
        public virtual Education Educations { get; set; }
        public virtual Account Account { get; set; }

        public Profiling(string nIK, int educationId)
        {
            NIK = nIK;
            EducationId = educationId;
        }
    }
}
