# What the Heck's for Dinner?
A light weight web app originally for the purpose of keeping track of personal recipes after a favorite book marked recipe was taken off the internet. Additionally implements a social framework for cooking meals for other people by generating redemable coupon codes.

### Requirements ###
* .Net Core 6
* .Net Entity Framework
* .Net AspNet CodeGenerator

### Adding Models: ###
* Create cs model in root/Models
* Run Dot net entity framework commands to generate migration.

```
# create the migration by running entity framework migrations command
dotnet ef migrations add <Migration Name>

# run the migration
dotnet ef database update
```

### Generate Basic Crud Scaffolding ###
Generate a basic set of crud pages for models by running below.

```
dotnet-aspnet-codegenerator razorpage -m Movie -dc <DbContext Class Name> -udl -outDir Pages/<Model Name Plural> --referenceScriptLibraries -sqlite
```

### Resouces: ###
**Razor Pages Tutorial:** 
https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-6.0

**.Net Aspnet Code Generator:**
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-6.0