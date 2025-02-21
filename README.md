# LaunchDarkly ASP.NET WebForms POC

This proof-of-concept (POC) demonstrates how to integrate LaunchDarkly feature flagging into an ASP.NET WebForms application. The application includes a simple login page to enter a user ID, uses LaunchDarkly to evaluate feature flags for that user, and then conditionally displays UI elements (a table and a chart placeholder) on the default page. A logout button is provided to clear the session.

## Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 (or later) WebForms project
- [LaunchDarkly account](https://launchdarkly.com/) with configured feature flags
- LaunchDarkly SDK key (server-side)

## Setup

### 1. Clone or Create the Project

Create a new ASP.NET Web Application (.NET Framework) and choose the WebForms template. Add the following files to your project structure:


### 2. Install NuGet Packages

Open the Package Manager Console and run:

```powershell
Install-Package LaunchDarkly.ServerSdk

Open the file LdClientProvider.cs in your project and add your LaunchDarkly SDK key:  

