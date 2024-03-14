using Microsoft.EntityFrameworkCore;
using WorkoutApp.Data;

namespace WorkoutApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new WorkoutAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<WorkoutAppContext>>()))
        {
            if (context == null || context.Exercise == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Exercise.Any())
            {
                return;   // DB has been seeded
            }

            context.Exercise.AddRange(
                new Exercise
                {
                    Name = "Bench Press",
                    MuscleGroup = "Chest",
                    Difficulty = 4,
                    Description = "To bench press, lie on a flat bench, grip the barbell slightly wider than shoulder-width apart, lower it to your chest while keeping your elbows at a 45-degree angle, and push it back up while exhaling.",
                    Equipment = "Bench"
                },

                new Exercise
                {
                    Name = "Lat Pulldown",
                    MuscleGroup = "Back",
                    Difficulty = 4,
                    Description = "To perform a lat pulldown, sit facing the machine, grip the bar wider than shoulder-width, pull it down to your upper chest while keeping your back straight, and then slowly release it back to the starting position.",
                    Equipment = "Machine"
                },

                new Exercise
                {
                    Name = "BB Squat",
                    MuscleGroup = "Legs",
                    Difficulty = 6,
                    Description = "To perform a barbell squat, stand with your feet shoulder-width apart, position the barbell across your upper back, then bend your hips and knees to lower your body until your thighs are parallel to the ground, before pushing back up to the starting position.",
                    Equipment = "Squat Rack"
                },

                new Exercise
                {
                    Name = "Pushups",
                    MuscleGroup = "Chest",
                    Difficulty = 2,
                    Description = "To do a pushup, start in a plank position with hands shoulder-width apart, lower your body until your chest almost touches the ground, then push back up to the starting position while keeping your body in a straight line.",
                    Equipment = "None"
                }
            );
            context.SaveChanges();
        }
    }
}