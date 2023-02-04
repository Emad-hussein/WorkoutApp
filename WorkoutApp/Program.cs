using System;
using System.Collections.Generic;

namespace WorkoutApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a list of workouts
            List<Workout> workouts = new List<Workout>
            {
                new Workout { Name = "Chest & Triceps", Exercises = new List<string> { "Barbell Bench Press", "Dumbbell Flys", "Tricep Dips" } },
                new Workout { Name = "Back & Biceps", Exercises = new List<string> { "Barbell Deadlifts", "Bent Over Rows", "Barbell Bicep Curls" } },
                new Workout { Name = "Legs & Shoulders", Exercises = new List<string> { "Squats", "Lunges", "Shoulder Press" } }
            };

            // Display the workouts to the user
            Console.WriteLine("Workouts:");
            for (int i = 0; i < workouts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {workouts[i].Name}");
            }

            // Ask the user to select a workout
            Console.WriteLine("\nSelect a workout by entering its number:");
            int workoutIndex = int.Parse(Console.ReadLine()) - 1;

            // Display the exercises for the selected workout
            Console.WriteLine($"\n{workouts[workoutIndex].Name} Exercises:");
            foreach (string exercise in workouts[workoutIndex].Exercises)
            {
                Console.WriteLine(exercise);
            }
        }
    }

    class Workout
    {
        public string Name { get; set; }
        public List<string> Exercises { get; set; }
    }
}
