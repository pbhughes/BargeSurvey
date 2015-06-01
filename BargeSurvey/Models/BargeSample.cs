using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BargeSurvey.Models
{
    public class BargeSample
    {
        public BargeSample()
        {
            LoadedPrior = false;
            PumpedAfterLight = false;
            BargeType = BargeSurvey.Models.BargeType.Box;
            Drafts = new List<Draft>();
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
        [Display(Name = "Drafts")]
        public ICollection<Draft> Drafts { get; set; }

        [Required]
        public long SurveyId { get; set; }
    }
}