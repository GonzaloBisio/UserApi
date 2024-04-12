# User API

## Introduction
User API is a RESTful web service that allows managing user data within an application. It provides endpoints for creating, retrieving, updating, and deleting user information, as well as special functionalities for handling user activity status.

## Prerequisites
Before you begin, ensure you have met the following requirements:
- .NET 8 SDK or later
- SQL Server (LocalDB or any SQL Server instance)
- An IDE like Visual Studio or Visual Studio Code

## Installation
Follow these steps to get your development environment set up:

1. Clone the repository to your local machine:
git clone https://github.com/GonzaloBisio/UserApi.git

 2. Navigate to the cloned repository directory:
cd your-repo

3. Restore the .NET packages:
dotnet restore

4. Update the database to the latest migration:
dotnet ef database update

5. Start the server:
dotnet run

The API will be hosted at `https://localhost:44342/`.

## Using the API

### Swagger UI

This API includes Swagger, an interactive documentation platform for testing endpoints. To access Swagger UI, navigate to `https://localhost:44342/swagger/index.html` in your web browser after starting the application. Here you can see all the available endpoints, their expected parameters, and try out API calls directly through the browser.

### Endpoints

- `GET /api/Usuario`
- Description: Retrieve a list of all users.
- No parameters.

- `GET /api/Usuario/{id}`
- Description: Retrieve a user by their ID.
- Parameters: `id` - The ID of the user.

- `POST /api/Usuario`
- Description: Create a new user.
- Payload: `{"name": "string", "birthdate": "yyyy-MM-dd", "active": true}`

- `PUT /api/Usuario/{id}`
- Description: Update an existing user's information.
- Parameters: `id` - The ID of the user.
- Payload: `{"id": 1, "name": "string", "birthdate": "yyyy-MM-dd", "active": true}`

- `DELETE /api/Usuario/{id}`
- Description: Delete a user by their ID.
- Parameters: `id` - The ID of the user.

- `GET /api/Usuario/Active`
- Description: Retrieve a list of all active users.
- No parameters.

- `PUT /api/Usuario/Deactivate/{id}`
- Description: Deactivate a user, setting them as inactive.
- Parameters: `id` - The ID of the user.
