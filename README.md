# Book Store Management System

## Introduction

Welcome to the Book Store Management System, a .NET Core MVC project using Entity Framework. This system allows users to manage a book store by performing various tasks such as user authentication, adding genres, authors, publishers, and books.

## Features

- **User Authentication:** Users can register and login to the system, allowing for personalized interactions.

- **Genre Management:** Easily add, edit, and delete genres to categorize books effectively.

- **Author Management:** Manage information about authors, including their name, biography, and other relevant details.

- **Publisher Management:** Keep track of publishers and their details for better organization.

- **Book Management:** Add new books, associate them with genres, authors, and publishers, and manage their information.

## Getting Started

1. **Prerequisites:**
   - Install [.NET Core](https://dotnet.microsoft.com/download).
   - Set up a database for Entity Framework.

2. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/book-store-management.git
   cd book-store-management
3. **Database Setup:**
  - Update the connection string in appsettings.json to point to your database.
    ```bash
    "ConnectionStrings": {
     "DefaultConnection": "your-connection-string"
    }
  - Run Entity Framework Migrations:
    ```bash
    Update-Database
4. **Run the Application:**
