using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_ProjectControlSystem.Models;
using ERP_ProjectControlSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ERP_ProjectControlSystem.Controllers
{
    public class SkillController : Controller
    {
        ProjectContext _context = new ProjectContext();
        public IActionResult AddSkill()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> AddSkill(SkillViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Add(new Skill { Title = model.Title });
                await _context.SaveChangesAsync();
            }
            return View(model);
        }
    }
}