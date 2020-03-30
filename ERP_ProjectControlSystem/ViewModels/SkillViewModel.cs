using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_ProjectControlSystem.ViewModels
{
    public class SkillViewModel
    {
        [MaxLength(30)]
        public string Title { get; set; }
    }
}
