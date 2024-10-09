namespace Courses.Repositories;

public class CourseRepository : Repository<Course>, ICourseRepository
{
    public CourseRepository(AppDbContext context) : base(context)
    {
    }

    // Add additional methods specific to Course entity
    public async Task<IEnumerable<Course>> GetCoursesWithLecturesAsync()
    {
        return await _dbSet
                        .ToListAsync();
    }

    public async Task<IEnumerable<Course>> GetCoursesByCategoryAsync(string category)
    {
        // Using LINQ to filter courses by category
        return await _dbSet
            .Where(c => c.Category != null && c.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();
    }

    // Get a single course by title asynchronously
    public async Task<Course?> GetCourseByTitleAsync(string title)
    {
        // Using LINQ to find the course by title
        return await _dbSet
            .FirstOrDefaultAsync(c => c.Title != null && c.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
}

