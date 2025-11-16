# ✈️ Airline Reservation System

This is a full-stack Airline Reservation System built using ASP.NET MVC and Entity Framework. It allows users to search for flights, book tickets, and manage reservations with secure role-based access for admins and customers.

## 🚀 Features

- Flight search and booking
- Passenger registration and login
- Admin dashboard for managing flights and bookings
- Role-based access control (Admin, Customer)
- Real-time seat availability
- SQL Server integration for data persistence
- Clean MVC architecture with layered controllers and views

## 🛠️ Technologies Used

- ASP.NET MVC 5
- Entity Framework
- SQL Server
- HTML, CSS, Bootstrap
- JavaScript, jQuery, AJAX

## 📦 Project Structure

- `/Models` – Entity classes and database schema
- `/Controllers` – Business logic and routing
- `/Views` – Razor pages for UI
- `/Scripts` – Frontend interactivity
- `/App_Start` – Configuration files
- `/SQLScripts` – Contains the SQL Server schema file (`VistaraDb.sql`)

## 🧱 Database Setup

### Option 1: Using SQL Server Management Studio

1. Open SQL Server Management Studio
2. Navigate to the `/SQLScripts` folder in the project
3. Run `VistaraDb.sql` to create the database schema
4. Update the connection string in `Web.config` to match your local SQL Server

### Option 2: Using Entity Framework Code First (if applicable)

1. Open Package Manager Console in Visual Studio
2. Run:
   ```bash
   Update-Database
