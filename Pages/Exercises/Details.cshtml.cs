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
    public class DetailsModel : PageModel
    {
        private readonly WorkoutApp.Data.WorkoutAppContext _context;

        public DetailsModel(WorkoutApp.Data.WorkoutAppContext context)
        {
            _context = context;
        }

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
    }
}
