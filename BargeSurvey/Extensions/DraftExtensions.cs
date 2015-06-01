using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BargeSurvey.Models;

namespace BargeSurvey.Extensions
{
    public static class DraftExtensions
    {
        public static float AverageDraft(this Draft draft)
        {
            float sum = draft.ReadingP1 + draft.ReadingP2 + draft.ReadingP3 + 
                draft.ReadingP4 + draft.ReadingS1 + draft.ReadingS2 + 
                draft.ReadingS3 + draft.ReadingS4;

            return sum / 8;
        }
    }
}