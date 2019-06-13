using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bogota_Robotics_Company.Data;
using Bogota_Robotics_Company.Data.Repositories;
using Bogota_Robotics_Company.Data.Entities;
using Bogota_Robotics_Company.Helpers;

namespace Bogota_Robotics_Company.Controllers
{
    public class ExperiencesController : Controller
    {
        private readonly IExperienceRepository repository;
        private readonly IUserHelper userHelper;

        //TODO: Change datacontext by an interface
        public ExperiencesController(IExperienceRepository repository, IUserHelper userHelper)
        {
            this.repository = repository;
            this.userHelper = userHelper;
        }

        // GET: Experiences
        public IActionResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: Experiences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experience = await repository.GetByIdAsync(id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // GET: Experiences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Experiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Experience experience)
        {
            if (ModelState.IsValid)
            {
                await repository.CreateAsync(experience);
                return RedirectToAction(nameof(Index));
            }
            return View(experience);
        }

        // GET: Experiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experience = await repository.GetByIdAsync(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }

        // POST: Experiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CompanyName,StartDate,EndDate,Ocupation")] Experience experience)
        {
            if (id != experience.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await repository.UpdateAsync(experience);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await repository.ExistAsync(id)) 
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(experience);
        }

        // GET: Experiences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var experience = await repository.GetAll()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // POST: Experiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var experience = await repository.GetByIdAsync(id);
            await repository.DeleteAysnc(experience);
            return RedirectToAction(nameof(Index));
        }
    }
}
