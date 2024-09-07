# Student Affairs Management System

A web application for managing students, courses, assignments, and materials, built using .NET 8 and Entity Framework Core.

## Features

- **User Management**: Support for multiple user roles (Admin, Tutor, Student).
- **Course Management**: Create and manage courses, including assignments and materials.
- **Assignment Tracking**: Manage and track student assignments and grades.
- **Note-taking**: Maintain personal and course-related notes.
- **ToDo List**: Manage tasks and deadlines.

## Prerequisites

- .NET 8 SDK
- SQL Server (or another compatible database)
- Visual Studio 2022 (or later) with the .NET workload

## Setup

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/StudentAffairsManagementSystem.git
   cd StudentAffairsManagementSystem
   ```
## Create and Configure the Database

Update the `appsettings.json` file with your database connection string:
```json
{
  "ConnectionStrings": {
    "UserDbConnection": "Server=localhost;Database=UserDatabase;User Id=yourId;Password=yourPassword;TrustServerCertificate=True;",
    "AssignmentDbConnection": "Server=localhost;Database=AssignmentDatabase;User Id=yourId;Password=yourPassword;TrustServerCertificate=True;"
  }
}
```

## Initialize User Secrets (Optional)

If you are using user secrets for sensitive information, initialize them as follows:
  ```bash
  dotnet user-secrets init
  dotnet user-secrets set "UserDbConnectionString" "Server=localhost;Database=UserDatabase;User Id=yourId;Password=yourPassword;TrustServerCertificate=True;",
  dotnet user-secrets set "AssignmentDbConnectionString" "Server=localhost;Database=AssignmentDatabase;User Id=yourId;Password=yourPassword;TrustServerCertificate=True;"
  ```

## Apply Migrations

Create and apply the initial database migration:
  ```powershell
  Add-Migration InitialCreate -Context UserDbContext
  Update-Database -Context UserDbContext
  Add-Migration InitialCreate -Context AssignmentDbContext
  Update-Database -Context AssignmentDbContext
  ```

## Run the Application

Launch the application using Visual Studio or the .NET CLI:
  ```bash
  dotnet run
  ```
Navigate to http://localhost:5000 in your browser to access the application.

## Usage
- Admin: Manage users, courses, and assignments.
- Tutor: Create and manage courses and assignments.
- Student: View and submit assignments, and manage personal notes.

## Contributing
Feel free to fork the repository and submit pull requests. Please follow the contribution guidelines and ensure that your code is well-tested and documented.

## License
This project is licensed under the MIT License - see the [LICENSE](https://github.com/sickoovit/StudentsAffaires/blob/master/LICENSE.txt) file for details.

## Contact
For any inquiries or issues, please contact [Omar Osman](https://www.linkedin.com/in/omarosmanenter/).
