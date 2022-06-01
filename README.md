# playwright-dotnet-tests

## How to run Tests
```
dotnet build
dotnet test
```

## VSCODE Dotnet FAQ

## How to add class library project to the Solution
```
dotnet add ./TestLayer/\*\*/Playwright.Tests.csproj reference ./PageLayer/Playwright.Page.Objects/Playwright.Page.Objects.csproj
```

## How to add reference to other project

```
dotnet add ./TestLayer/\*\*/Playwright.Tests.csproj reference ./PageLayer/Playwright.Page.Objects/Playwright.Page.Objects.csproj
```
