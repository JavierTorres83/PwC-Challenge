# --- ChallengeAPI API Testing ---

## Overview
ChallengeAPI API Testing is a suite of automated tests for Restful Booker. The tests are written in C# using the NUnit framework and RestSharp for API Testing.

## Prerequisites
- .NET Framework 4.8.1
- Any IDE (Visual Studio for example)
- RestSharp

## Setup
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio 2022.
3. Ensure the following packages are installed via NuGet:
   - NUnit
   - NUnitConsoleRunner
   - NUnit3TestAdapter
   - RestSharp

## Running Tests
1. Build the solution in Visual Studio.
2. For Visual Studio 2022. Open the Test Explorer (`__Test > Windows > Test Explorer__`).
3. Run all tests or select specific tests to run.

## Test Structure
- **Core**: Contains the base classes and the APIClient for the tests.
- **Models**: Contains the Models for the solution.
- **Tests**: Contains the test classes.
- **Utils**: Contains main Utilities for the solution.

# --- ChallengeGUI Test Automation ---

## Overview
ChallengeGUI Test Automation is a suite of automated tests for the ChallengeGUI application. The tests are written in C# using the NUnit framework and Selenium WebDriver for browser automation.

## Prerequisites
- .NET Framework 4.8.1
- Visual Studio 2022
- Chrome, Firefox, or Edge browser installed
- Selenium WebDriver

## Setup
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio 2022.
3. Ensure the following packages are installed via NuGet:
   - NUnit
   - NUnit3TestAdapter
   - Selenium.WebDriver
   - Selenium.Support
4. Configure the `App.config` file with the necessary settings.

## Running Tests
1. Build the solution in Visual Studio.
2. For Visaul Studio 2022. Open the Test Explorer (`__Test > Windows > Test Explorer__`).
3. Run all tests or select specific tests to run.
   
## Test Structure
- **Core**: Contains the base classes and utilities for the tests.
- **Pages**: Contains the page object models for the application.
- **Tests**: Contains the test classes.

  
  
  
  
