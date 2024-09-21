# Evently

## Overview

Evently is a Modular Monolithic Architecture project aimed at demonstrating the use of **Clean Architecture** principles for each module. The solution contains multiple layers, ensuring separation of concerns and maintainability.

## Architecture

The project follows the Clean Architecture principles. Each module in the project (such as `Events`) is divided into different layers:

1. **Domain**: Contains the core business logic.
2. **Application**: Handles the application logic, such as use cases.
3. **Infrastructure**: Deals with external systems like databases, external APIs, etc.
4. **Presentation**: Manages how data is presented to the outside world, usually through APIs.

## Prerequisites

To run the project, you'll need:

- .NET 8.0 or later
- Docker (for containerized services)

## Running the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/maucodev/dotnet-monolith-architecture.git

2. Navigate to the project directory:
   ```bash
   cd dotnet-monolith-architecture

3. Run the application using Docker Compose:
   ```bash
   docker-compose up
