## ⚡️ Trip Keeper | ASP.NET Core 3.1 MVC Fullstack Application ⚡️

## This app is used for storing a driver’s trip information and how much it pays! 

<h2 align="center">
  <img src="https://github.com/CodingMikey/TripKeeper/blob/master/sample.gif" alt="Tripkeeper" width="600px" />
  <br>
</h2>

## Features

⚡️ Modern UI Design\
⚡️ ASP.NET Core 3.1 W/ MVC\
⚡️ Automatically calculates how much a trip pays\
⚡️ Fully Responsive + DateTime Picker\
⚡️ Table with full pagination, search and more\
⚡️ Authorization W/ Custom ApplicationUser properties

To view a demo example, **[click here](https://github.com/CodingMikey/TripKeeper/blob/master/sample.gif)**

## Getting Started 🚀

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites 📋

You'll need [Git](https://git-scm.com) | [.NET Core 3.1](https://dotnet.microsoft.com/download) | [SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15) | [MS SQL](https://docs.microsoft.com/en-us/ef/)


## How To Use 🔧

From your command line, first clone Trip Keeper:

```bash
# Clone this repository
$ git clone https://github.com/CodingMikey/TripKeeper.git

# Go into the repository
$ cd tripkeeper

# Remove current origin repository
$ git remote remove origin

# In the dictory of tripkeeper you must add migrations
$ Add-Migrations [migration name]

# In the directory of tripkeeper you must update after migrations
$ Update-Database
```

## Technologies used 🛠️

- [.NET Core 3.1](https://dotnet.microsoft.com/download) - .NET Core is a cross-platform version of .NET
- [Microsoft SQL Server](https://docs.microsoft.com/en-us/ef/) - Relational Database Management System (RDBMS)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/) - Modern Object-Database Mapper
- [SQL Server Management Studio](https://www.microsoft.com/en-us/sql-server) -  Used for managing any SQL infrastructure, from SQL Server to Azure SQL Database.
- [Microsoft Azure](https://azure.microsoft.com/en-us/) - Cloud computing service
- [DataTables](https://datatables.net/) - DataTables is a plug-in for the jQuery Javascript library
- [Bootstrap 4](https://getbootstrap.com/docs/4.3/getting-started/introduction/) - Front-end component library


## Authors

- **Michael Galas** - [https://github.com/CodingMikey](https://github.com/CodingMikey)

## Acknowledgments 🎁

I was motivated to create this web application because I wanted to give drivers a better way to keep track of their trip information that also automatically calculates how much a trip paid. Using this web application is 40% faster than filing out a physical trip sheet paper.
