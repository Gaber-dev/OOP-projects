# DryClean

DryClean is a **C# project** built with Object-Oriented Programming principles. It simulates a dry-cleaning delivery system, focusing on clean design, order lifecycle, and core interactions (pickup, cleaning, delivery).
This project is part of the **OOP-projects** collection by [Gaber-dev](https://github.com/Gaber-dev).

---

## 📑 Table of Contents

* [Features](#features)
* [Architecture & Design](#architecture--design)
* [Requirements](#requirements)
* [Getting Started](#getting-started)

  * [Clone & Build](#clone--build)
  * [Running the Application](#running-the-application)
* [Usage](#usage)
* [Project Structure](#project-structure)
* [Future Improvements](#future-improvements)
* [Contributing](#contributing)
* [License](#license)
* [Author](#author)
* [GUI Screenshots](#gui-screenshots)

---

## ✨ Features

* Create and manage **orders** with multiple clothing items
* Support for different garment types/classes with relevant attributes (shirts, coats, trousers, etc.)
* Order state transitions (*Requested → In Cleaning → Ready → Delivered*)
* Delivery or pickup options
* Basic input validation and error handling

---

## 🏗️ Architecture & Design

* Written in **C#**, following OOP best practices: classes, properties, methods, encapsulation, interfaces/abstraction where needed
* Clear separation of responsibilities:

  * **Models/Entities**: garments, orders, customers
  * **Services/Handlers**: cleaning, delivery, order state transitions
  * **Utilities**: shared logic & validation
* State management enforces valid transitions (e.g. cannot deliver before cleaning)

---

## 🛠 Requirements

* [.NET SDK](https://dotnet.microsoft.com/download) (version used: .NET 6 / .NET 7 / .NET Core)
* C# compiler (included in .NET SDK)
* Optional: IDE (Visual Studio / VSCode)

---

## 🚀 Getting Started

### Clone & Build

```bash
git clone https://github.com/Gaber-dev/OOP-projects.git
cd OOP-projects/DryClean
dotnet build
```

### Running the Application

From the project root:

```bash
dotnet run
```

---

## 💡 Usage

Typical flow when running the application:

1. Create a new order
2. Add one or more clothing items (type, quantity)
3. Select delivery or pickup method
4. Track order status as it moves through states
5. (Optional) Loop to handle multiple orders or exit the program

---

## 📂 Project Structure

```
DryClean/
├── Models/
│   ├── Order.cs
│   ├── Garment.cs
│   ├── Customer.cs
│   └── ...
├── Services/
│   ├── CleaningService.cs
│   ├── DeliveryService.cs
│   ├── OrderManager.cs
│   └── ...
├── Utilities/
│   ├── ValidationHelper.cs
│   └── ...
├── Program.cs          # Main entry point
├── DryClean.csproj
└── README.md
```

---

## 🔮 Future Improvements

* Persist orders/data to storage (file, database) so state survives restarts
* Smart locker pickup/drop-off functionality
* More nuanced garment handling (different cleaning requirements/pricing)
* User accounts and multiple customers
* Unit tests for services and state transitions
* Optional UI (desktop or web)

---

## 🤝 Contributing

Contributions are welcome!

1. Fork the repository
2. Create a feature or bugfix branch (`feature/add-locker`, `fix/order-state`, etc.)
3. Follow existing OOP patterns and write clean code
4. Add tests if you add new behavior
5. Submit a pull request with a clear description

---

## 📜 License

Specify your license here (e.g. MIT License).

---

## 👤 Authors

- **Gaber-dev** — part of the [OOP-projects](https://github.com/Gaber-dev) collection.

 - **ahmedhasanain97** [OOP-projects](https://github.com/ahmedhasanain97)

 - **KHALED MOHAMED** [OOP-projects](https://github.com/THEKINGSTAR)

---


## 🖼 GUI Screenshots

<div align="center">
  <img src="./src/screens/Screenshot (5).png" alt="Screenshot 5" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (6).png" alt="Screenshot 6" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (7).png" alt="Screenshot 7" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (8).png" alt="Screenshot 8" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (9).png" alt="Screenshot 9" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (10).png" alt="Screenshot 10" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (11).png" alt="Screenshot 11" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (12).png" alt="Screenshot 12" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (13).png" alt="Screenshot 13" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (14).png" alt="Screenshot 14" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (15).png" alt="Screenshot 15" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (16).png" alt="Screenshot 16" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (17).png" alt="Screenshot 17" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (18).png" alt="Screenshot 18" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (19).png" alt="Screenshot 19" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (20).png" alt="Screenshot 20" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (21).png" alt="Screenshot 21" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (22).png" alt="Screenshot 22" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (23).png" alt="Screenshot 23" width="600">
</div>

<div align="center">
  <img src="./src/screens/Screenshot (24).png" alt="Screenshot 24" width="600">
</div>




---
