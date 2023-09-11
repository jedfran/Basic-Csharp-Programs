using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BasicStudentDatabase1.Data;
using BasicStudentDatabase1.Models;

namespace BasicStudentDatabase1.Controllers
{
    public class StudentsController : Controller
    {
        private readonly BasicStudentDatabase1Context _context;

        public StudentsController(BasicStudentDatabase1Context context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
              return _context.StudentApp != null ? 
                          View(await _context.StudentApp.ToListAsync()) :
                          Problem("Entity set 'BasicStudentDatabase1Context.StudentApp'  is null.");
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StudentApp == null)
            {
                return NotFound();
            }

            var studentApp = await _context.StudentApp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentApp == null)
            {
                return NotFound();
            }

            return View(studentApp);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress")] StudentApp studentApp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentApp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentApp);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StudentApp == null)
            {
                return NotFound();
            }

            var studentApp = await _context.StudentApp.FindAsync(id);
            if (studentApp == null)
            {
                return NotFound();
            }
            return View(studentApp);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress")] StudentApp studentApp)
        {
            if (id != studentApp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentApp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentAppExists(studentApp.Id))
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
            return View(studentApp);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StudentApp == null)
            {
                return NotFound();
            }

            var studentApp = await _context.StudentApp
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentApp == null)
            {
                return NotFound();
            }

            return View(studentApp);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StudentApp == null)
            {
                return Problem("Entity set 'BasicStudentDatabase1Context.StudentApp'  is null.");
            }
            var studentApp = await _context.StudentApp.FindAsync(id);
            if (studentApp != null)
            {
                _context.StudentApp.Remove(studentApp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentAppExists(int id)
        {
          return (_context.StudentApp?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
