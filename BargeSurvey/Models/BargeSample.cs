using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BargeSurvey.Models
{
    public class BargeSample
    {
        public BargeSample()
        {
            LoadedPrior = false;
            PumpedAfterLight = false;
            BargeType = BargeSurvey.Models.BargeType.Box;
        }
        [Key]
        [Required]
        public long Id { get; set; }

        [Display(Name="Barge ID")]
        public string BargeID { get; set; }

        [Required]
        [Display(Name="Condition:")]
        public RiverConditions? RiverCondition { get; set; }

        [Required]
        [Display(Name="Config")]
        public BargeType? BargeType { get; set; }

        [Required]
        [Display(Name="Loaded Prior")]
        [UIHint("IsTrue")]
        public bool LoadedPrior { get; set; }

        [Required]
        [Display(Name="Pumped Prior")]
        [UIHint("IsTrue")]
        public bool PumpedAfterLight { get; set; }

        [Required]
        [Display(Name="Reading 1:")]
        public Single ReadingP1 { get; set; }

        [Required]
        [Display(Name = "Reading 2:")]
        public Single ReadingP2 { get; set; }

        [Required]
        [Display(Name = "Reading 3:")]
        public Single ReadingP3 { get; set; }

        [Required]
        [Display(Name = "Reading 4:")]
        public Single ReadingP4 { get; set; }

        [Required]
        [Display(Name = ":Reading 1")]
        public Single ReadingS1 { get; set; }

        [Required]
        [Display(Name = ":Reading 2")]
        public Single ReadingS2 { get; set; }

        [Required]
        [Display(Name = ":Reading 3")]
        public Single ReadingS3 { get; set; }

        [Required]
        [Display(Name = ":Reading 4")]
        public Single ReadingS4 { get; set; }
        
        [Required]
        public long SurveyId { get; set; }
    }
}