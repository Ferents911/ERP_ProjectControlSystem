using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ERP_ProjectControlSystem.Models;
using ERP_ProjectControlSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERP_ProjectControlSystem.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private ProjectContext _context = new ProjectContext();
        private readonly UserManager<IdentityUser> _userManager;

        public ProjectController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult AddProject()
        {
            ViewBag.Skills = new SelectList(_context.Skills.ToList(), "Id", "Title");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddProject(ProjectViewModel model)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            var role = await _userManager.GetRolesAsync(user).ContinueWith(roles => roles.Result.FirstOrDefault());

           

            if (ModelState.IsValid)
            {
                _context.Projects.Add(new Project
                {
                    Created = DateTime.Now.Date,
                    Updated = DateTime.Now.Date,
                    Description = model.Description,
                    Link = model.Link,
                    Role = role,
                    Title = model.Title,
                    Organization = model.Organization,
                    Start = DateTime.Parse(model.Start),
                    End = DateTime.Parse( model.End),
                    Type = model.Type
                });
                await _context.SaveChangesAsync();
            }
            return View(model);
        }
     
    }
}