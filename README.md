1. Ensure Sqlite is installed and create database `leads.db`
2. `dotnet ef database update`
3. `dotnet run`
4. Expect to see error `Invalid cast from 'System.Int32' to 'EfCoreBitflagBug.LeadType'`