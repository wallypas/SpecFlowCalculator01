# SpecFlowCalculator Project README

## Project Overview

The SpecFlowCalculator project is a solution designed to demonstrate the usage of SpecFlow for behavior-driven development (BDD) in .NET. It includes unit tests using xUnit and other dependencies necessary for running and testing the calculator application.

## Project Structure

The project consists of two main parts:
1. **SpecFlowCalculator01** - The main calculator application.
2. **SpecFlowCalculator.Specs** - The SpecFlow tests for the calculator.

### Directory Layout

```
SpecFlowCalculator
│
├── global.json
├── SpecFlowCalculator01
│   ├── bin
│   ├── obj
│   ├── Calculator.cs
│   ├── SpecFlowCalculator01.csproj
│   └── SpecFlowCalculator01.sln
│
└── SpecFlowCalculator.Specs
    ├── bin
    ├── obj
    ├── Drivers
    │   └── Driver.cs
    ├── Features
    │   ├── Calculator.feature
    │   └── Calculator.feature.cs
    ├── Hooks
    │   └── Hook.cs
    ├── Steps
    │   └── CalculatorStepDefinitions.cs
    ├── SpecFlowCalculator.Specs.csproj
    └── SpecFlowCalculator.Specs.sln
```

## Dependencies

The project relies on various DLL files and packages. The key dependencies are:
- SpecFlow
- xUnit
- FluentAssertions
- Newtonsoft.Json
- Microsoft.TestPlatform.* (various assemblies for test platform utilities)
- Gherkin
- Google.Protobuf

## Getting Started

### Prerequisites

- .NET 6.0 SDK
- Visual Studio or any compatible IDE that supports .NET development

### Installation

1. Clone the repository to your local machine:
    ```sh
    git clone https://github.com/your-repo/SpecFlowCalculator.git
    cd SpecFlowCalculator
    ```

2. Restore the NuGet packages:
    ```sh
    dotnet restore
    ```

### Running the Application

1. Navigate to the `SpecFlowCalculator01` directory:
    ```sh
    cd SpecFlowCalculator01
    ```

2. Build the project:
    ```sh
    dotnet build
    ```

3. Run the application:
    ```sh
    dotnet run
    ```

### Running the Tests

1. Navigate to the `SpecFlowCalculator.Specs` directory:
    ```sh
    cd SpecFlowCalculator.Specs
    ```

2. Build the test project:
    ```sh
    dotnet build
    ```

3. Run the tests:
    ```sh
    dotnet test
    ```

## Project Files

### Main Application (SpecFlowCalculator01)

- **Calculator.cs**: The main calculator logic implementation.
- **SpecFlowCalculator01.csproj**: The project file containing the configuration for the calculator application.

### SpecFlow Tests (SpecFlowCalculator.Specs)

- **Features**: Contains the feature files written in Gherkin syntax.
  - **Calculator.feature**: Feature file defining the scenarios for calculator operations.
- **Steps**: Contains the step definitions for the SpecFlow scenarios.
  - **CalculatorStepDefinitions.cs**: Step definitions for the calculator feature.
- **Hooks**: Contains hooks to set up and tear down test environments.
  - **Hook.cs**: Hook definitions for SpecFlow tests.
- **Drivers**: Contains additional driver classes for the tests.
  - **Driver.cs**: Driver implementation for SpecFlow tests.

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request. Ensure that all tests pass and adhere to the coding standards used in the project.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

---

Feel free to reach out if you have any questions or need further assistance. Happy coding!
