# Background

This is proof-of-concept project for creating nested validation within a Blazor application.

# Open Issues

Currently, when the application is run, per-field messages are not rendered for the `Contact` components, even though they fail validation.

# Technologies

* [ASP.NET Core](https://dotnet.microsoft.com/en-us/download) + Blazor Server-Side
* [FluentValidation](https://docs.fluentvalidation.net/en/latest/)
* (_Experiental_) [Microsoft.AspNetCore.Commponents.DataAnnotations.Validation](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.DataAnnotations.Validation#readme-body-tab)