# CQRSWebApi

This project demonstrates the implementation of the **CQRS Pattern** (Command Query Responsibility Segregation) in a Web API using **C#**, **.NET**, and **MediatR**. It separates Command (write operations) and Query (read operations) logic for better scalability and maintainability.

---

## **Features**
- Clear separation of Commands and Queries.
- Uses **MediatR** to handle Commands and Queries.
- Includes **Swagger** for API documentation.
- Supports Create and Read operations.

---

## **Prerequisites**
- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://code.visualstudio.com/) or any IDE that supports .NET development
- [Git](https://git-scm.com/) (optional, for version control)

---

## **Getting Started**

### **1. Clone the Repository**
If you have Git installed, you can clone the repository using the following command:
```bash
git clone https://github.com/tofu639/CQRSWebApi.git
cd CQRSWebApi
```

### **2. Install Dependencies**
Make sure you have the .NET SDK installed. Then, restore the project dependencies:

```bash
dotnet restore
```

### **3. Run the Application**
To run the application, use the following command:

```bash
dotnet run
```