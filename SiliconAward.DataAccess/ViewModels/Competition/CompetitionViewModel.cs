using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiliconAward.DataAccess.ViewModels.Competition
{
   public class CompetitionViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50, MinimumLength =5,ErrorMessage ="Title must have between 5 and 50 characters")]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 500, MinimumLength = 5, ErrorMessage = "Title must have between 5 and 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Please select a reward")]
        public int Reward { get; set; }
        [Required(ErrorMessage = "Please select a skill group and skill field")]
        public int SkillField { get; set; }
        public DateTime? StartCompetition { get; set; }
        public DateTime? EndCompetition { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? EditedTime { get; set; }
    }
}
