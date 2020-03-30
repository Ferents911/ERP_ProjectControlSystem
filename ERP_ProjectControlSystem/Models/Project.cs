using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_ProjectControlSystem.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Organization { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Role { get; set; }

        public string Link { get; set; }

        public string Type { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }


        public List<SkillProject> SkillProjects { get; set; }

        public Project()
        {
            SkillProjects = new List<SkillProject>();
        }

    }
}
