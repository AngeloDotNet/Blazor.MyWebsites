# Blazor.MyWebsites

## Project creation

The project was created using powershell and the command to create it was: **dotnet new blazorwasm -f net5.0 -ho true -p true -o Blazor.MyWebSites**

## Nuget Package Additional

- MudBlazor
- BlazorKit.Spinners

## Scaffolding Database

To perform the scaffolding it is necessary to open the package management console and use the command: **Add-Migration Initial-Migration**

Subsequently, to apply the newly created migration to the database it is necessary to use the command: **Update-Database**

The scaffolding of the database must be performed from the Package Management Console, making sure that the default project (drop-down menu) is **Blazor.MyWebSites.Server**

## Deploy via docker

After launching the publish command **dotnet publish -c Release**

Before publishing via docker, it is necessary to check the presence of the **_framework** folder and the javascript files **service-worker.js** and **service-worker-assets.js** in the **wwwroot** folder.

If these are not present, it is possible to integrate them with a simple copy and paste from the Blazor project directory: **MyWebsites\Client\bin\Release\net5.0\wwwroot**

If these files are omitted for some reason, the application will not be visible / available while browsing from the browser and the fixed message **loading...** will remain.

## Components

### MudBlazor

Since the project is in .NET 5 version, it was necessary to install a lower MudBlazor Nuget package than the one indicated (as of 10/02/2022 the latest version is 6.0.6).
Version 5.2.4 was installed for this demo project using the following command: **dotnet add package MudBlazor --version 5.2.4**

## License

[![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/tterb/atomic-design-ui/blob/master/LICENSEs)
