using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkoutApp.Data;
using WorkoutApp.Models;

namespace WorkoutApp.Pages.Exercises
{
    public class DeleteModel : PageModel
    {
        private readonly WorkoutApp.Data.WorkoutAppContext _context;

        public DeleteModel(WorkoutApp.Data.WorkoutAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Exercise Exercise { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercise.FirstOrDefaultAsync(m => m.Id == id);

            if (exercise == null)
            {
                return NotFound();
            }
            else
            {
                Exercise = exercise;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercise.FindAsync(id);
            if (exercise != null)
            {
                Exercise = exercise;
                _context.Exercise.Remove(Exercise);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
