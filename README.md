# Proppy-App-API

This repository contains the API for [Proppy-APP-test](https://github.com/KolojE/proppy-app-test). The API is implemented in ASP.NET and uses Entity Framework Core for interaction with the SQL database.

## Setup

To set up the project locally, follow these steps:

1. Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/Proppy-App-API.git
cd Proppy-App-API
```
2. Use dotnet restore to install necessary packages
```bash
dotnet restore
```

3. Configure the database connection in the appsettings.json file.
```json
{
   "ConnectionStrings": {
    "ProppyAppDb": "Your Database Connection String"
  },
}

```
4. Run dotnet server
```bash
dotnet run
```
