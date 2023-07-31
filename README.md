**CustomerManagement Application** box

This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs). 

Welcome to the CustomerManagement application! 
This ASP.NET Core application, built using .NET 7, provides a simple customer management system. It utilizes various NuGet packages like Dapper, Restsharp, Newtonsoft.JSON, XUnit, and Humanizer to enhance its functionality. 😎

## Getting Started 🚀:

To get started with CustomerManagement, follow the steps below:

### Prerequisites 📋:

1. [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)

### Installation 📦:

1. Clone the repository to your local machine:

```bash
git clone https://github.com/zangassis/customer-management.git
```

2. Change into the project directory:

```bash
cd CustomerManagement
```

### Configuration 🔧:

1. Ensure you have a MySQL Server database available for this application.
2. Configure the database connection string in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING_HERE"
  }
}
```

### Usage 🛠:

To run the CustomerManagement application, use the following command:

```bash
dotnet run
```

### Testing 🧪:

CustomerManagement uses XUnit for unit testing. To run the tests, execute:

```bash
dotnet test
```

## Features 📃:

- **Customer Management:** Add, retrieve, update, and delete customer information.
- **API Integration:** Communicate with external RESTful APIs using Restsharp.
- **Data Access:** Utilize Dapper to interact with the database efficiently.
- **JSON Handling:** Leverage Newtonsoft.JSON for handling JSON data serialization and deserialization.
- **Unit Testing:** Comprehensive unit tests using XUnit to ensure code correctness and stability.
- **Humanizer:** Enhance user experience with Humanizer's human-friendly strings.

## Contributing 🤝:

We welcome contributions to improve the CustomerManagement application. Feel free to create issues, open pull requests, or provide feedback. 🤝

## License ⚖:

This project is licensed under the [MIT License](LICENSE).

Thank you for choosing CustomerManagement! If you have any questions or need assistance, feel free to reach out. Happy coding! 👨‍💻💖