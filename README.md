# calculator
**C#.NET Calculator with Database Recording**

**Summary**

This project is a calculator developed with C#.NET that supports four basic operations as well as percentage calculation. The calculator records all operations performed by connecting to a database. This makes it easy to access past calculations.

**Features**

* Four basic operations (addition, subtraction, multiplication, division)
* Percentage calculation
* Database recording
* Docker support for virtual machines

**Usage**

To use the calculator, follow these steps:

1. Open the calculator.
2. Enter the first number.
3. Select the operation.
4. Enter the second number.
5. Click the Calculate button.

The calculator will display the result of the operation. The operation will also be recorded in the database.

**Contact**

If you have any questions or suggestions about the project, please use the following contact information:

* [EMİR]
* [tunaliemir61@gmail.com]


**Installation**

To install the calculator, follow these steps:

1. Download the project from GitHub.
2. Open the project in Visual Studio.
3. Press F5 to run the calculator.

**Running with Docker**

To run the calculator with Docker, follow these steps:

1. Download the project from GitHub.
2. Run the following command to run the project in Docker:

```
docker run -it -p 8080:8080 github.com/[Your name]/calculator
```

This command will bind the calculator to port 8080. You can access the calculator at http://localhost:8080.

**Development**

To develop the calculator, follow these steps:

1. Open the project in Visual Studio.
2. Make your changes.
3. Push your changes to GitHub.

**License**

This project is distributed under the MIT license.

**Additional Information**

The calculator has a multi-layer architecture. This makes the code more organized and easier to read. The project consists of the following layers:

* **Data Layer:** Handles database connections and database operations.
* **Business Layer:** Processes user input and performs calculations.
* **Presentation Layer:** Creates the user interface for the calculator.

The calculator is designed to run on virtual machines with Docker as well. This makes it possible to run the project on any operating system.

**Additional Notes**

The calculator uses the following technologies:

* **C#.NET**
* **Visual Studio**
* **SQL Server**
* **Docker**

The calculator is a useful tool for performing basic calculations and recording results. It is also a good example of how to use a multi-layer architecture to improve the organization and readability of code.
