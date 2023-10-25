# ECommerceStore

This readme provides instructions for setting up and running the "ECommerceStore" ASP.NET Core 6 web application. Ensure you have the necessary tools and dependencies installed on your system.

## Prerequisites

Before you begin, make sure you have the following tools and SDKs installed:

1. **.NET 6 SDK:** The application is built using ASP.NET Core 6, so you'll need to have .NET 6 SDK installed. You can download it from the official .NET website: [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet/6.0).

2. **Entity Framework Core Tools:** To work with the database, you will need Entity Framework Core tools. Install it globally using the following command:

   ```
   dotnet tool install --global dotnet-ef
   ```

3. **xUnit Testing Framework:** The application includes unit tests written using xUnit. To run the tests, you should have xUnit installed. You can install it globally using the following command:

   ```
   dotnet tool install -g dotnet-xunit
   ```

## Getting Started

To set up and run the "ECommerceStore" ASP.NET Core 6 web application, follow these steps:

1. **Clone the Repository:**

   ```bash
   git clone git@github.com:M7amd7amada/ECommerceStore.git
   ```

2. **Navigate to the Project Directory:**

   ```bash
   cd ECommerceStore
   ```

3. **Database Setup:**

   - Configure your database connection string in the `appsettings.json` file under the "ConnectionStrings" section. You may choose to use SQL Server, SQLite, or any other database provider supported by Entity Framework Core.

   - After configuring the connection string, apply the initial database migrations using Entity Framework Core. Run the following commands:

     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

4. **Build and Run the Application:**

   ```bash
   dotnet build
   dotnet run
   ```

   The application should start, and you will see output indicating that it's listening on a specific address (e.g., `https://localhost:5000`).

5. **Access the Application:**
   Open your web browser and navigate to the URL where the application is running, typically `https://localhost:5000`.

6. **Running Tests:**
   To run the unit tests using xUnit, use the following command from the project directory:

   ```bash
   dotnet test
   ```

   This will execute all the unit tests in the application.

## Contributing

If you'd like to contribute to the "ECommerceStore" application, please fork the repository, make your changes, and submit a pull request.

## Issues and Bug Reports

If you encounter any issues or want to report a bug, please create a new issue on the GitHub repository.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

Enjoy using the "ECommerceStore" ASP.NET Core 6 web application! If you have any questions or need further assistance, feel free to reach out to the project contributors.
