# Important #
- From the `StudentContext` if you want to, delete the `Courses` and `Enrolments`, because the `Student` already have navigational properties to those entities. So they are anyway "implicitly" referenced.

- The 'EnsureCreated' method in `DbContext` class makes sure the database is created, if the database does not exist.

- An EF Core Context is **NOT thread safe**

## To Generate Scaffolding ##
- Install below mentioned packages
```Powershell  
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Utils
```
- Open a command prompt in the project folder and run the below commands
```Powershell
dotnet restore
dotnet aspnet-codegenerator razorpage -m Student -dc SchoolContext -udl -outDir Pages\Students --referenceScriptLibraries
```
      
