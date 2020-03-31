using SiliconAward.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiliconAward.DataAccess.Entities
{
    public class Competition:BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartCompetition { get; set; }
        public DateTime? EndCompetition { get; set; }
        public int  AwardId{ get; set; }
    }
}
