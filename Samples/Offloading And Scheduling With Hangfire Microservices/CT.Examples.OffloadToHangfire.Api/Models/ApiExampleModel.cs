﻿using System.ComponentModel.DataAnnotations;

namespace CT.Examples.OffloadToHangfire.Api.Models
{
    public class ApiExampleModel
    {
        [Required]
        public string SomeImportantData { get; set; }
    }
}
