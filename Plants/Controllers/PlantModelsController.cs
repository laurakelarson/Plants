using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Plants.Backend;
using Plants.Models;

namespace Plants.Views.CRUDI
{
    public class PlantModelsController : Controller
    {
        private readonly Datastore _context;

        public PlantModelsController(Datastore context)
        {
            _context = context;
        }

        // GET: PlantModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plants.ToListAsync());
        }

        // GET: PlantModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantModel = await _context.Plants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plantModel == null)
            {
                return NotFound();
            }

            return View(plantModel);
        }

        // GET: PlantModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlantModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ScientificName,CommonName,Family,Category,Duration,ImageURI")] PlantModel plantModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plantModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plantModel);
        }

        // GET: PlantModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantModel = await _context.Plants.FindAsync(id);
            if (plantModel == null)
            {
                return NotFound();
            }
            return View(plantModel);
        }

        // POST: PlantModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ScientificName,CommonName,Family,Category,Duration,ImageURI")] PlantModel plantModel)
        {
            if (id != plantModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plantModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantModelExists(plantModel.Id))
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
            return View(plantModel);
        }

        // GET: PlantModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantModel = await _context.Plants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plantModel == null)
            {
                return NotFound();
            }

            return View(plantModel);
        }

        // POST: PlantModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plantModel = await _context.Plants.FindAsync(id);
            _context.Plants.Remove(plantModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantModelExists(int id)
        {
            return _context.Plants.Any(e => e.Id == id);
        }
    }
}
