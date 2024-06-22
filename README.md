# CampusPro
Mangage internal data for an university X
## Description
Brief description of your WinForms application.

## Installation
### System requirements:
- NuGet.Framework 6.10.0
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) version 4.8.
- [Oracle Database XE 21c](https://www.oracle.com/database/technologies/appdev/xe.html) (Oracle SQL Developer for optional).
### Installation steps:
Follow these steps to install and run the application:

1. **Download**
   - Clone the repository from GitHub:
     ```bash
     git clone https://github.com/yourusername/your-repository.git
     ```
   - Alternatively, download the ZIP file and extract it to your desired location.

2. **Build the Solution**
   - Open the solution file (`YourSolution.sln`) in Visual Studio.

3. **Restore Packages**
   - Restore NuGet packages if necessary:
     ```bash
     nuget restore YourSolution.sln
     ```

4. **Build and Run**
   - Build the solution (`Ctrl + Shift + B`).
   - Set the startup project to `YourProject.GUI` (or your WinForms project).
   - Press `F5` or click on the "Start" button in Visual Studio to run the application.

5. **Configuration (if applicable)**
   - If the application requires additional configuration (e.g., database connection strings, API keys), update the configuration file (`app.config` or `web.config`) located in the `YourProject.GUI` project.

6. **Usage**
   - Once the application is launched, follow the on-screen instructions to navigate and use the features.

### Notes
- Ensure you have proper permissions and access rights to install and run applications on your system.
- If you encounter any issues during installation or startup, refer to the "Known Issues" section in this README or contact [support email or link].


## Getting Started
- How to launch the application
- Basic usage instructions

## Configuration
- How to configure settings (if applicable)

## Folder Structure
### Description of Folders

- **GUI**: This folder contains the graphical user interface (WinForms) project. It typically includes forms, controls, and other UI-related components.
  
- **BUS**: Business logic layer where the application's business rules and logic are implemented. This layer acts as an intermediary between the GUI and DAO layers.

- **DTO**: Data Transfer Objects (DTOs) are used for transferring data between different layers of the application. They represent the data that is exchanged between the GUI, BUS, and DAO layers.

- **DAO**: Data Access Objects (DAOs) encapsulate the logic required to access and manipulate data from the database. They provide methods for CRUD (Create, Read, Update, Delete) operations.

### sql Folder

- **sql**: This folder contains SQL scripts used for setting up and maintaining the database. It includes schema creation scripts, table definitions, stored procedures, and other database-related scripts.

### Notes

- Ensure to maintain the separation of concerns between the GUI, BUS, DTO, and DAO layers to adhere to the principles of layered architecture.
- Modify the folder structure description according to your specific project's organization and naming conventions.


## Known Issues
- List of known bugs or issues

## Contributing
- Guidelines for contributing (if applicable)

## Credits
- Credits to external libraries or contributors

## License
This project is licensed under the [License Name] - see the LICENSE file for details.

## Contact
For support, please contact [email address or link to issue tracker].
