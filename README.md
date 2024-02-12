# CrashTester Application

## Overview

CrashTester is a testing tool designed to simulate a variety of failure scenarios in applications, making it an invaluable asset for developers aiming to build robust software that can gracefully handle errors. The application offers an extensive range of features for artificially inflating resources, as well as numerous methods for triggering unexpected closures or suspensions. This functionality is crucial for signaling monitoring applications that something is amiss.

## Features

- **Process Monitoring:** Leverages `ProcessMonitoringLogic` to continuously monitor the current process for critical parameters such as CPU usage, memory consumption, and handle count.
- **Simulated Failures:** Provides mechanisms to:
  - Divide by zero to trigger a crash.
  - Artificially increase memory usage and working set memory to test memory handling capabilities.
  - Exceed maximum array size to test boundary checking.
  - Manipulate process handle count to test handle leak detection.
  - Induce a non-responding state to simulate application hangs.
  - Close the main window while keeping the process running to test orphan process detection.
  
## Usage

The main interface of the CrashTester application, implemented in `MainCrasthesterForm.cs`, allows users to interact with the various test mechanisms through a user-friendly GUI. Users can initiate specific tests with just a click, making it straightforward to simulate different scenarios and observe how their application reacts.

## Implementation

CrashTester is implemented in C# and utilizes the .NET Framework for its GUI components and process monitoring. The core functionalities, such as memory inflation and process manipulation, are facilitated through both managed and unmanaged code, with `CrashHelper.cs` providing static methods for executing the failure scenarios.

## Getting Started

To use CrashTester:
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build the project to resolve dependencies.
4. Run the application from Visual Studio or the executable generated in the build process.

## Contributing

Contributions to the CrashTester are welcome! Whether it's adding new features, improving existing ones, or reporting bugs, your input helps make CrashTester a more effective tool.
