# Blazor.MyWebsites

## Project creation

The project was created using powershell and the command to create it was:

>dotnet new blazorwasm -f net5.0 -ho true -p true -o Blazor.MyWebSites

## Nuget Package Additional

- MudBlazor
- BlazorKit.Spinners

## Scaffolding Database

To perform the scaffolding it is necessary to open the package management console and use the command

>Add-Migration NOME-MIGRATION

Subsequently, to apply the newly created migration to the database it is necessary to use the command

>Update-Database

The scaffolding of the database must be performed from the Package Management Console, making sure that the default project (drop-down menu) is Blazor.MyWebSites.Server

## License

[![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/tterb/atomic-design-ui/blob/master/LICENSEs)
