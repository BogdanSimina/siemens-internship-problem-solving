# Siemens Internship – Problem Solving 2026

This repository contains the solution for the Siemens Internship problem-solving assignment.

---

## 📌 Problem 1 – Coffee Shop System

### UML Class Diagram
File:
- `CoffeeShop_UML.pdf`

Description:
Represents the object-oriented design of the coffee shop system, including:
- Customer
- Order
- OrderItem
- Beverage
- Extra
- Barista
- Relationships between classes

### ER (Database) Diagram
File:
- `CoffeeShop_ER.pdf`

Description:
Represents the database structure, including:
- Tables
- Primary Keys (PK)
- Foreign Keys (FK)
- Many-to-many relationship resolved through `OrderItemExtras` table

---

## 📌 Problem 2 – SieMarket (C# Implementation)

Source code files:

- `Program.cs` → Entry point of the application (demo and execution)
- `Order.cs` → Represents an order and contains the discount logic
- `OrderItem.cs` → Represents a product inside an order
- `Analytics.cs` → Contains:
  - Method to find the customer who spent the most
  - Method to calculate popular products and total quantity sold

### Implemented Requirements:

✔ 2.1 Order and OrderItem classes  
✔ 2.2 Discount rule (10% if order total > 500 EUR)  
✔ 2.3 Customer who spent the most  
✔ 2.4 Bonus – Popular products calculation  

## ▶ How to Run

1. Navigate to the project folder:
  cd SiemensInternship
2. Run:
  dotnet run
Requirements:
- .NET 8 SDK (or compatible version)
