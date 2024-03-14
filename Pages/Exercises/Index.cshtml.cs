using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkoutApp.Data;
using WorkoutApp.Models;

namespace WorkoutApp.Pages.Exercises
{
    public class IndexModel : PageModel
    {
        private readonly WorkoutApp.Data.WorkoutAppContext _context;

        public IndexModel(WorkoutApp.Data.WorkoutAppContext context)
        {
            _context = context;
        }

        public IList<Exercise> Exercise { get;set; } = default!;

        public async Task OnGetAsync()
        {
            IQueryable<string> equipmentQuery = from e in _context.Exercise
                                                orderby e.Equipment
                                                select e.Equipment;
            IQueryable<string> muscleGroupQuery = from e in _context.Exercise
                                                orderby e.MuscleGroup
                                                select e.MuscleGroup;
            var exercises = from e in _context.Exercise
                         select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                exercises = exercises.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ExerciseMuscle))
            {
                exercises = exercises.Where(x => x.MuscleGroup == ExerciseMuscle);
            }
            if (!string.IsNullOrEmpty(ExerciseEquipment))
            {
                exercises = exercises.Where(y => y.Equipment == ExerciseEquipment);
            }

            MuscleGroups = new SelectList(await muscleGroupQuery.Distinct().ToListAsync());
            Equipments = new SelectList(await equipmentQuery.Distinct().ToListAsync());
            Exercise = await exercises.ToListAsync();
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? MuscleGroups { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ExerciseMuscle { get; set; }

        public SelectList? Equipments { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? ExerciseEquipment { get; set; }
    }
}
