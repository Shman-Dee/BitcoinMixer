# Bitcoin Mixer Simulation

This is a simple Bitcoin Mixer simulation project built for educational purposes.  
It demonstrates the use of **Entity Framework Core**, **Repository Pattern**, and **ASP.NET Core 8 Web API** with a **SQLite** database.

---

## Project Structure

- **EF Core Code-First Database Schema**: Models and database generated through migrations.
- **Repository Pattern**: Separates data access logic from controllers.
- **Controllers**: CRUD operations using DTOs and proper RESTful routing.
- **Validation**: Models have data annotations like `[Required]`, `[Range]`.
- **Swagger**: API endpoints are available for testing via Swagger UI.

---

## Technologies Used

- ASP.NET Core 8
- Entity Framework Core 8
- SQLite
- Swagger (OpenAPI)
- C#

---

## How to Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/YOUR_GITHUB_USERNAME/YOUR_REPO_NAME.git
   cd YOUR_REPO_NAME
   ```

---

## Author

Built by Andrew McInally and GPT

---

## Notes

    •	This project simulates Bitcoin deposits and transaction mixing without using real cryptocurrency.
    •	Focus is on clean architecture, proper use of repositories, and EF Core best practices.
    •	SQLite is used as the database for simplicity and easy setup.
