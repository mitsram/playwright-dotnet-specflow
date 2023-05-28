# playwright-dotnet-specflow

This is an example project that demonstrates how to use Playwright with SpecFlow for browser automation testing. Playwright is a powerful open-source library for automating web browsers, and SpecFlow is a behavior-driven development (BDD) framework that allows you to write tests in a human-readable format.

## Prerequisites
Before running the tests in this project, make sure you have the following prerequisites installed on your system:

* .NET Core SDK (version 6.0 or higher)
* SpecFlow (version 3 or higher)
* Playwright for .NET (version 1.3x or higher)

## Getting Started
To get started with this project, follow these steps:

1. Clone this repository to your local machine:
```
git clone git@github.com:mitsram/playwright-dotnet-specflow.git
```
2. Navigate to the project directory:
```
cd playwright-dotnet-specflow
```
3. Install the project dependencies:
```
dotnet restore
```
4. Set your `.env` file at the root of the solution folder. Example values:
```
USERNAME=<your registered UiBank username>
PASSWORD=<your registered UiBank password>
```

5. Run the tests:
```
dotnet test
```

> If you're running this template for the first time, it might give you and error and suggest to run the `pwsh bin/Debug/net<version>/playwright.ps1 install` command. If you're using Mac, you can install powershell using brew: `brew install powershell`


## Project Structure
The project structure is organized as follows:

* `Hooks/` directory: Contains hooks or event handlers that allow you to run code at specific points during the test execution lifecycle. These hooks provide a way to perform actions such as setting up preconditions before the tests start, performing cleanup after each test, or executing code before and after the entire test suite.
* `Features/` directory: Contains SpecFlow feature files written in the Gherkin language. Each feature file describes a test scenario or a set of related scenarios.
* `Steps/` directory: Contains SpecFlow step definition files. Each step definition maps to a step in the feature files and contains the automation logic using Playwright.


## Writing Tests
To write tests using Playwright and SpecFlow, follow these guidelines:

1. Create a new feature file in the `Features/` directory or add your scenarios to an existing feature file. Write your scenarios in the Gherkin language, describing the expected behavior of the application.
2. Define step definitions for your scenarios in the `Steps/` directory. Each step definition maps to a step in the feature file. Use Playwright's API to interact with the browser and perform actions like navigating to pages, filling forms, clicking buttons, etc.
3. Implement the automation logic in the step definition methods. You can utilize Playwright's selectors and methods to locate elements on the page and interact with them.
4. Run the tests using the `dotnet test` command. The tests will be executed, and the results will be displayed in the console.

## Contributing
If you find any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request. Contributions are welcome!