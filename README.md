# El1te Spr1nt Athlet1cs Web API

This is the backend system for El1te Spr1nt Athlet1cs — a nonprofit track club. Built with modern clean architecture principles using .NET 8 and Angular, this project is designed to be secure, scalable, and maintainable.

---

## 🔧 Technologies

- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- Serilog Logging
- CORS Support
- Swagger/OpenAPI
- Clean Architecture

## 🗂 Project Structure

- El1teSpr1ntTrack.Api/         → Web API (controllers, middleware, DI, auth)
- El1teSpr1ntTrack.Core/        → Domain models, DTOs, interfaces
- El1teSpr1ntTrack.Infrastructure/ → EF DbContext, migrations, repository implementations
- El1teSpr1ntTrack.Application/ → Business logic & services

## Getting Started

To get started with the Elite Sprint Athletics Web API, follow these steps:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Set El1teSpr1ntTrack.Api as the startup project
4. Update the `appsettings.json` file with your SQL Server connection string and valid JWT key.
5. Run EF Core migrations: Update-Database
6. Run the API project to launch SwaggerUI.

## API Endpoints

The Elite Sprint Athletics Web API provides the following endpoints:

# Track Club API Endpoints

## 👤 User & Authentication Endpoints
- `POST /api/users/register` - Register a parent user (who can add athletes).
- `POST /api/users/login` - Authenticate user & return JWT token.
- `GET /api/users/{id}` - Get user details (including linked athletes if a parent).
- `PUT /api/users/{id}` - Update user details.
- `DELETE /api/users/{id}` - Delete a user (soft delete for safety).
- `GET /api/users/{id}/athletes` - Get all athletes linked to a parent.

## 🏃 Athlete Endpoints
- `GET /api/athletes` - Get a list of all athletes.
- `GET /api/athletes/{id}` - Get details for a specific athlete.
- `POST /api/athletes` - Create a new athlete (only parents or admins can do this).
- `PUT /api/athletes/{id}` - Update an existing athlete.
- `DELETE /api/athletes/{id}` - Delete an athlete.
- `POST /api/athletes/{id}/activate` - Athlete activates their own account (links them to a `User`).

## 🏆 Event & Competition Endpoints
- `GET /api/events` - Get all events.
- `GET /api/events/{id}` - Get event details.
- `POST /api/events` - Create an event.
- `PUT /api/events/{id}` - Update an event.
- `DELETE /api/events/{id}` - Delete an event.

## 📊 Record Endpoints
- `GET /api/records` - Get all performance records.
- `GET /api/records/{id}` - Get record details.
- `POST /api/records` - Add a new record.
- `PUT /api/records/{id}` - Update a record.
- `DELETE /api/records/{id}` - Delete a record.

## 🛒 Storefront & Inventory Endpoints
- `GET /api/products` - Get all products.
- `GET /api/products/{id}` - Get product details.
- `POST /api/products` - Create a new product (Admin only).
- `PUT /api/products/{id}` - Update a product (Admin only).
- `DELETE /api/products/{id}` - Delete a product.
- `GET /api/orders` - Get all orders (Admin only).
- `GET /api/orders/{id}` - Get order details.
- `POST /api/orders` - Create an order (user adds products & checks out).
- `POST /api/orders/checkout` - Process payment (Stripe/PayPal) & complete order.
- `PUT /api/orders/{id}` - Update order status.
- `DELETE /api/orders/{id}` - Cancel an order.

## 💰 Donations Endpoints
- `POST /api/donations` - Submit a one-time donation (Stripe/PayPal).
- `GET /api/donations` - Get all donations (Admin only).
- `GET /api/donations/{id}` - Get donation details.

## ⭐ Testimonials Endpoints
- `POST /api/testimonials` - Submit a testimonial (only parents, athletes, or track meet visitors).
- `GET /api/testimonials` - Get all testimonials (only approved ones are public).
- `GET /api/testimonials/{id}` - Get testimonial details.
- `PUT /api/testimonials/{id}/approve` - Approve a testimonial (Admin only).
- `DELETE /api/testimonials/{id}` - Delete a testimonial.


## Authentication

The Elite Sprint Athletics Web API uses JWT authentication. To authenticate, include a valid JWT token in the `Authorization` header of your requests.

## Contributing

We welcome contributions to the Elite Sprint Athletics Web API! If you have any ideas for improvements or new features, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
