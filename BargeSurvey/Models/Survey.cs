using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BargeSurvey.Models
{
    public class Survey
    {
        public Survey()
        {
            SurveyDate = DateTime.Now;
            ClosedOut = false;
        }

        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        [Display(Name="Customer")]
        public string Customer { get; set; }

        [Required]
        [Display(Name="Sampler Name")]
        public string SamplerName { get; set; }

        [Required]
        [Display(Name="Terminal")]
        public string Terminal { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [EnumDataType(typeof(States))]
        public States? State { get; set; }

        [Required]
        [Display(Name="Purpose Of Trip")]
        public string Purpose { get; set; }

        [Required]
        [Display(Name="Survey Date")]
        [DataType(DataType.Date)]
        [UIHint("Date")]
        public DateTime? SurveyDate { get; set; }

        [Display(Name="Barge Samples")]
        public virtual ICollection<BargeSample> BargeSamples { get; set; }

        [Display(Name = "ClosedOut")]
        [UIHint("Bool")]
        public bool ClosedOut { get; set; }
    }
}