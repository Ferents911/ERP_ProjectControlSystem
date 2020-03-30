using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_ProjectControlSystem.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<SkillProject> SkillProjects { get; set; }

        public Skill()
        {
            SkillProjects = new List<SkillProject>();
        }
    }
}
