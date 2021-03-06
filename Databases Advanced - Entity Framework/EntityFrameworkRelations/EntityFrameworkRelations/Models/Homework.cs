﻿// 1. Code First Student System
namespace EntityFrameworkRelations.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum ContentType
    {
        Application, Pdf, Zip
    }
    public class Homework
    {   
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public ContentType Type { get; set; }

        [Required]
        public DateTime SubmissionDate { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

    }
}
