﻿using System.ComponentModel.DataAnnotations;

namespace onlineStore.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Cover Type")]
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
