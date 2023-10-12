using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GurpreetFrameAgency.Data;
using GurpreetFrameAgency.Models;

namespace GurpreetFrameAgency.Controllers
{
    public class FramesController : Controller
    {
        private readonly GurpreetFrameAgencyContext _context;

        public FramesController(GurpreetFrameAgencyContext context)
        {
            _context = context;
        }

        // GET: Frames
        public async Task<IActionResult> Index()
        {
            return View(await _context.Frame.ToListAsync());
        }

        // GET: Frames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frame = await _context.Frame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (frame == null)
            {
                return NotFound();
            }

            return View(frame);
        }

        // GET: Frames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Frames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,ManufacturingDate,Color,Rating,Price")] Frame frame)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frame);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(frame);
        }

        // GET: Frames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frame = await _context.Frame.FindAsync(id);
            if (frame == null)
            {
                return NotFound();
            }
            return View(frame);
        }

        // POST: Frames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,ManufacturingDate,Color,Rating,Price")] Frame frame)
        {
            if (id != frame.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrameExists(frame.Id))
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
            return View(frame);
        }

        // GET: Frames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frame = await _context.Frame
                .FirstOrDefaultAsync(m => m.Id == id);
            if (frame == null)
            {
                return NotFound();
            }

            return View(frame);
        }

        // POST: Frames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frame = await _context.Frame.FindAsync(id);
            _context.Frame.Remove(frame);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrameExists(int id)
        {
            return _context.Frame.Any(e => e.Id == id);
        }
    }
}
