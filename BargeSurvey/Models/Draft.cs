using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BargeSurvey.Models
{
    public class Draft
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [Display(Name="Draft Type")]
        public DraftType DraftType { get; set; }

        [Required]
        [Display(Name = "Reading 1")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingP1 { get; set; }

        [Required]
        [Display(Name = "Reading 2")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingP2 { get; set; }

        [Required]
        [Display(Name = "Reading 3")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingP3 { get; set; }

        [Required]
        [Display(Name = "Reading 4")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingP4 { get; set; }

        [Required]
        [Display(Name = "Reading 1")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingS1 { get; set; }

        [Required]
        [Display(Name = "Reading 2")]
        [Range(0d, 216d)]
        public Single ReadingS2 { get; set; }

        [Required]
        [Display(Name = "Reading 3")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingS3 { get; set; }

        [Required]
        [Display(Name = "Reading 4")]
        [RegularExpression(@"\d+(\.\d{1,2})?")]
        [Range(0d, 216d)]
        public Single ReadingS4 { get; set; }


        [Required]
        public long BargeSampleId { get; set; }
    }
}