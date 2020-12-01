cd C:\Users\Admin\source\repos\PhD_AUT_Project\PhD_AUT_Project

dotnet test PhD_AUT_Project.csproj /p:CollectCoverage=true /p:IncludeTestAssembly=true /p:CoverletOutputFormat=cobertura

reportgenerator "-reports:C:\Users\Admin\source\repos\PhD_AUT_Project\PhD_AUT_Project\coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html