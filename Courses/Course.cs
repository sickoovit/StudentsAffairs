﻿namespace StudentsAffairs.Server.Entities;

public class Course
{
    public Guid Id { get; set; } // Unique identifier for the course.
    public string? Title { get; set; } // The title or name of the course (e.g., "Introduction to Programming").
    public string? Description { get; set; } // A brief description providing an overview of the course content.
    public string? Category { get; set; } // Category or type of course (e.g., "Programming", "Design", "Marketing").
    public TimeSpan? Duration { get; set; } // The duration or length of the course, represented in hours or minutes.
    public string? Level { get; set; } // Difficulty level of the course (e.g., Beginner, Intermediate, Advanced).
    public decimal? Price { get; set; }  // The price of the course. Nullable in case the course is free or price is not set.

    // Relationships
    public List<Material>? Materials { get; set; } // Materials associated with the course, such as videos, PDFs, or other resources.
    public List<Assignment>? Assignments { get; set; } // List of assignments associated with the course.
    public List<Lecture>? Lectures { get; set; }  // List of course lectures
}
