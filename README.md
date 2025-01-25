# HRMS - Employee Management Console Application

## Project Description
Thia is a console-based application built in C# and .NET that allows users to:
1. **Register Employees** with unique IDs and names.
2. **View the Number of Employees** currently registered.
3. **Assign Tasks** to employees with detailed descriptions.
4. **Display Tasks** assigned to specific employees.

The application demonstrates the use of **object-oriented programming (OOP)** principles by utilizing classes for `Employee` and `EmployeeTask` and includes features such as input validation and task management.

---

## Features
- **Register Employee**: Add new employees with unique IDs and names.
- **View Employee Count**: Display the total number of employees registered.
- **Assign Tasks**: Assign tasks with descriptions to employees by their IDs.
- **Display Employee Tasks**: View all tasks assigned to a specific employee.
- **Menu-Based Navigation**: Intuitive menu for easy operations.

---

## Technologies Used
- **Language**: C#
- **Framework**: .NET 6 or later
- **IDE**: Visual Studio 2022

---

## Installation and Setup
### Prerequisites
- Install [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload.
- Install the latest [.NET SDK](https://dotnet.microsoft.com/).

### Steps to Run
1. Clone or download the repository.
2. Open the project in Visual Studio 2022.
3. Build the solution (`Ctrl+Shift+B`).
4. Run the application (`F5`).

---

## Usage Instructions
### Launch the Program
- Run the application in Visual Studio or using the `dotnet run` command in the terminal.

### Menu Options
- Select options from the menu to perform tasks:
  - **1**: Register a new employee.
  - **2**: View the total number of employees.
  - **3**: Assign a task to an employee.
  - **4**: Display tasks for an employee.
  - **5**: Exit the program.

### Input Validation
- Ensure valid input is provided when prompted (e.g., numeric IDs and non-empty names/descriptions).

---

## Code Structure
- **Classes**:
  - `Employee`: Stores employee details and tasks.
  - `EmployeeTask`: Represents an individual task with a description and timestamp.

- **Main Program**:
  - Handles user interaction, menu navigation, and calls class methods to perform operations.

---

## Future Enhancements
- Add persistence using file storage or a database.
- Include editing and deletion of employees or tasks.
- Add task priority levels and deadlines.
- Enhance the UI with a graphical interface.

---

## Contributors
- **Nakitto Catherine**
