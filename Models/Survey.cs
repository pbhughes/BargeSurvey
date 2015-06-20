using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BargeSurvey.Models
{
    public class Survey
    {
        [Required]
        [Display(Name = "Customer")]
        public string Customer { get; set; }

        [Required]
        [Display(Name = "Surveyor Name")]
        public string Surveyor { get; set; }

        [Required]
        [Display(Name="Survey Date")]
        public DateTime SurveyDate { get; set; }

        [Required]
        [Display(Name="Surveyor Phone Number")]
        public string SurveyorPhone { get; set; }

        [Required]
        [Display(Name="Terminal")]
        public string Terminal { get; set; }

        [Required]
        [Display(Name="City")]
        public string City { get; set; }

        [Required]
        [Display(Name="State")]
        public string State { get; set; }
    }
}