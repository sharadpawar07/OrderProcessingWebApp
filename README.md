# Order Processing System

## Description
This is a simple ASP.NET MVC application that processes customer orders. It calculates discounts for loyal customers and displays the final order amount.

## Features
- Order form where customers can enter their order amount and customer type.
- Discounts are applied based on order amount and customer type.
- Displays the final order total.

## Requirements
- Visual Studio 2022
- SQL Server
- .NET Framework 4.8

## Setup Instructions
1. Clone the repository to your local machine.
2. Open the solution file (`OrderProcessingSystem.sln`) in Visual Studio.
3. Set up the SQL Server database (`OrderProcessingDB`) with the provided `Orders` table.
4. Run the application.

## Running Tests
1. Tests are automated using GitHub Actions.
2. On every push or pull request to the `main` branch, tests will run automatically.

## CI/CD
The project uses GitHub Actions to automatically build, test, and deploy on each commit.
