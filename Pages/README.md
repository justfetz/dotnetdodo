# dotnetdodo
## Introduction
DotNetDodo is an ASP.NET Core web application that helps manage a paper manufacturing business. The application provides tools for solving common manufacturing problems, including the cutting stock problem, bin packing problem, and transportation problem.

## Requirements
.NET 5 SDK or later
Microsoft SQL Server Express or later
Git
Installation
Clone the repository:
```
bash
Copy code
git clone https://github.com/justfetz/dotnetdodo.git
Install the required packages:
```

Copy code
```dotnet restore
Create the database using Entity Framework Core migrations:
```
```
sql
Copy code
dotnet ef database update
```
Start the application:

Copy code
dotnet run
The application should now be running at http://localhost:5000.

Usage
The application provides a web interface for managing manufacturing orders. Users can enter their demands for paper products and the application will generate a cutting plan to minimize waste.

Contributing
Contributions to this project are welcome! If you find a bug or want to suggest an improvement, please create a new issue on the GitHub repository.

License
This project is licensed under the MIT License. See the LICENSE file for more information.

Acknowledgements
This project was developed with the help of the Google OR-Tools library, which provides a powerful suite of optimization algorithms.
