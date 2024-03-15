# Workout Tracker Web App
## Overview
The Workout Tracker is a web application built using Razor Pages with C#, designed to help users create and manage personalized workout plans. With an easy-to-use interface, users can add exercises to customizable workouts, track their progress, and adjust their routines according to their fitness goals. This app supports multiple users, allowing each user to have a unique set of workouts and exercises.

## Features
- User Authentication: Secure signup and login functionality.
- Exercise Database: A comprehensive list of exercises that users can browse and add to their workouts.
- Custom Workouts: Users can create, edit, and delete personalized workouts.
- Progress Tracking: Tools for users to track their exercise performance and improvements over time.
- Responsive Design: Optimized for both desktop and mobile devices.
## Getting Started
### Prerequisites
Visual Studio 2019 or later
.NET 5.0 SDK or later
SQL Server (for the database)
### Installation
- Clone the repository
```git clone https://github.com/yourusername/workout-tracker.git```

- Open the solution in Visual Studio

- Navigate to the cloned repository folder and open the .sln file in Visual Studio.

- Restore NuGet packages

- Right-click on the solution in Solution Explorer and select "Restore NuGet Packages".

- Set up the database

- In appsettings.json, update the connection string to match your SQL Server instance.

- Use Entity Framework Core to update the database with the latest migration by running the following command in the Package Manager Console:
```Update-Database```

- Run the application

- Press F5 to build and run the application. Visual Studio will open a web browser pointing to the app's home page.

## Usage
- Registering a New User(still in progress): Start by registering as a new user by clicking on the "Register" link.
- Creating Workouts(still in progress): Once logged in, navigate to the "My Workouts" page to start creating your workouts.
- Adding Exercises to Workouts: Within each workout, you can add exercises by searching the exercise database and specifying details such as sets, reps, and weight.
- Tracking Progress(future iterations): Use the app's tracking features to review your performance and progress over time.
