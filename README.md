# ASP.NET Core Project

This project follows the ASP.NET Core framework and includes the following key points:

 ## Code First Database Approach: 
    The project adopts the code-first approach for database management.
    
 ## Layered Architecture: 
   The backend is structured into three layers:
   - `BLL` (Business Logic Layer): Responsible for implementing business rules and logic.
   - `DAL (Data Access Layer)`: Handles data access and communication with the database.
   - `Application Layer`: Serves as the entry point and orchestrates the interaction between the presentation layer and the BLL and DAL.
  
 ## SOLID Principles: 
   The SOLID principles are followed to enhance code maintainability and extensibility.

   **Single Responsibility Principle (SRP)**: Each class and module has a single responsibility and should have only one reason to change.
   - **Open-Closed Principle (OCP)**:
     The code is open for extension but closed for modification, allowing new features to be added without modifying existing code.
   - **Liskov Substitution Principle (LSP)**: 
     Objects of a superclass should be able to be replaced by objects of its subclasses without affecting the correctness of the program.
   - **Interface Segregation Principle (ISP)**: 
     Clients should not be forced to depend on interfaces they do not use. It promotes the creation of specific and focused interfaces.
   - **Dependency Inversion Principle (DIP)**:
     High-level modules should not depend on low-level modules; both should depend on abstractions. It promotes loose coupling and easier testing and maintenance.

 ## Postman Integration: Postman is utilized to generate and test API outputs.


 ## Project Structure
  3 layer project structure.

- `BLL`: Contains the business logic layer code.
- `DAL`: Includes the data access layer code, including repositories, entities, and DbContext.
- `Application`: Acts as the application layer, providing the entry poi


## Dependencies


- ASP.NET Core framework
- Entity Framework Core


