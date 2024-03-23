# El1te Spr1nt Athlet1cs Web API

Welcome to the Elite Sprint Athletics Web API! This API is designed to serve as the backend for the Elite Sprint Athletics track club, providing access to information about athletes, events, records, and more.

Technologies Used
.NET 7
C#
Entity Framework Core
SQL Server
Getting Started
To get started with the Elite Sprint Athletics Web API, follow these steps:

Clone this repository to your local machine.
Open the solution in Visual Studio or your preferred IDE.
Update the appsettings.json file with your SQL Server connection string.
Run the database migrations to create the database schema: dotnet ef database update.
Run the API project.
API Endpoints
The Elite Sprint Athletics Web API provides the following endpoints:

GET /api/athletes: Get a list of all athletes.

GET /api/athletes/{id}: Get details for a specific athlete.

POST /api/athletes: Create a new athlete.

PUT /api/athletes/{id}: Update an existing athlete.

DELETE /api/athletes/{id}: Delete an athlete.

GET /api/events: Get a list of all events.

GET /api/events/{id}: Get details for a specific event.

POST /api/events: Create a new event.

PUT /api/events/{id}: Update an existing event.

DELETE /api/events/{id}: Delete an event.

GET /api/records: Get a list of all records.

GET /api/records/{id}: Get details for a specific record.

POST /api/records: Create a new record.

PUT /api/records/{id}: Update an existing record.

DELETE /api/records/{id}: Delete a record.

Authentication
The Elite Sprint Athletics Web API uses JWT authentication. To authenticate, include a valid JWT token in the Authorization header of your requests.

Contributing
We welcome contributions to the Elite Sprint Athletics Web API! If you have any ideas for improvements or new features, please open an issue or submit a pull request.

License
This project is licensed under the MIT License - see the LICENSE file for details.
