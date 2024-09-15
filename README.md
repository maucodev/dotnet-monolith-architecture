# Evently

## Overview

Evently is a Modular Monolithic Architecture project aimed at demonstrating the use of **Clean Architecture** principles for each module. The solution contains multiple layers, ensuring separation of concerns and maintainability.

## Architecture

The project follows the Clean Architecture principles. Each module in the project (such as `Events`) is divided into different layers:

1. **Domain**: Contains the core business logic.
2. **Application**: Handles the application logic, such as use cases.
3. **Infrastructure**: Deals with external systems like databases, external APIs, etc.
4. **Presentation**: Manages how data is presented to the outside world, usually through APIs.

### Project Structure

- **API**: The entry point of the application, responsible for exposing HTTP APIs.
  - `Evently.Api`: Handles all incoming HTTP requests and sends responses.
  
- **Common**: Contains shared logic used across different modules.
  - `Evently.Common.Application`: Common application services and helpers.
  - `Evently.Common.Domain`: Shared domain logic.
  - `Evently.Common.Infrastructure`: Shared infrastructure services like logging, authentication, etc.
  
- **Modules**: Represents individual business features, with each feature broken down into layers.
  - **Events**:
    - `Evently.Modules.Events.Application`: Application logic for the events module.
    - `Evently.Modules.Events.Domain`: Core business logic for events.
    - `Evently.Modules.Events.Infrastructure`: Infrastructure dependencies specific to the events module.
    - `Evently.Modules.Events.Presentation`: Presentation logic specific to events, such as API controllers.

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
