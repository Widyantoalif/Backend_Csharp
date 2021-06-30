using System;
using System.Collections.Generic;

#nullable disable

namespace TUTORIALJWT.Model
{
    public partial class SkillLevel
    {
        public SkillLevel()
        {
            UserSkills = new HashSet<UserSkill>();
        }

        public int SkillLevelId { get; set; }
        public string SkillLevellName { get; set; }

        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
