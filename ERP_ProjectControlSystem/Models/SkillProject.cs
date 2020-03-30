using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_ProjectControlSystem.Models
{
    public class SkillProject
    {
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
