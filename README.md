# Library App

## Description

Library App is a console-based library management system built with .NET 8.0. It allows users to manage patrons, loans, and memberships. The application is structured into three main layers: Application Core, Infrastructure, and Console UI, ensuring a clean separation of concerns.

## Project Structure

The project is organized as follows:

- **AccelerateDevGitHubCopilot.sln**: Solution file for the project.
- **README.md**: Documentation for the project.
- **src**: Contains the source code.
  - **Library.ApplicationCore**: Core business logic and domain entities.
    - `Entities/`: Domain models like `Patron` and `Loan`.
    - `Enums/`: Enumerations used across the application.
    - `Interfaces/`: Abstractions for repositories and services.
    - `Services/`: Business logic implementations.
    - `Library.ApplicationCore.csproj`: Project file for the core library.
  - **Library.Console**: Console-based user interface.
    - `appSettings.json`: Configuration file.
    - `CommonActions.cs`: Defines common user actions.
    - `ConsoleApp.cs`: Main application logic for the console UI.
    - `ConsoleState.cs`: Enum for managing application states.
    - `Program.cs`: Entry point of the application.
    - `Json/`: JSON files for data storage (e.g., `Patrons.json`, `Loans.json`).
    - `Library.Console.csproj`: Project file for the console application.
  - **Library.Infrastructure**: Data access and storage layer.
    - `Data/`: Repository implementations for JSON-based storage.
    - `Library.Infrastructure.csproj`: Project file for the infrastructure library.
- **tests**: Contains unit tests.
  - **UnitTests**: Test project for validating business logic.
    - `LoanFactory.cs`: Helper for creating test data.
    - `...`: Additional test files.
    - `UnitTests.csproj`: Project file for the test project.

## Key Classes and Interfaces

- **Core Layer**:
  - `Patron`: Represents a library patron.
  - `Loan`: Represents a book loan.
  - `IPatronRepository`: Interface for patron data access.
  - `ILoanRepository`: Interface for loan data access.
  - `IPatronService`: Interface for patron-related business logic.
  - `ILoanService`: Interface for loan-related business logic.
- **Console Layer**:
  - `ConsoleApp`: Main class managing the console UI and application states.
  - `ConsoleState`: Enum defining application states (e.g., `PatronSearch`, `LoanDetails`).
  - `CommonActions`: Enum for user actions (e.g., `SearchPatrons`, `Quit`).
- **Infrastructure Layer**:
  - `JsonPatronRepository`: JSON-based implementation of `IPatronRepository`.
  - `JsonLoanRepository`: JSON-based implementation of `ILoanRepository`.

## Usage

1. Clone the repository:

   ```sh
   git clone <repository-url>
