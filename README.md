# nguyentuyen-airlines
.NET Winform app to book airplane tickets from Nguyentuyen Airlines

Source code of Lab 04 for .NET Programming course.

NuGet dependencies:
+ Entity Framework (for easiser access to SQLite database)

Also the usage of DbContext in this app is only suitable for single-threaded desktop apps like this one. 
Don't do it like this if you are using it for the web. Don't be stingy and just create a new DbContext for each connection string.
