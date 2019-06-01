using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bogota_Robotics_Company.Services;
using Bogota_Robotics_Company.Models;

namespace Bogota_Robotics_Company.Controllers
{
    public class StaffController : Controller
    {
        private readonly IProfileService _profileService;
        public StaffController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        // GET: Staff
        public async Task<ActionResult> Index()
        {
            var items =await _profileService.GetAsyncProfiles();
            var model = new StaffViewModel()
            {
                Profiles = items
            };
            return View(model);
        }

        // GET: Staff/Details/5
        public async Task<ActionResult> Profile(string name)
        {
            var p = await _profileService.GetProfile(name);
            var model = new ProfileViewModel() { Profile = p };
            return View(model);
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Staff/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}