﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace workshop.wwwapi.Models
{
    [Table("patients")]
    public class Patient
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")] 
        public string FullName { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

    }
}
