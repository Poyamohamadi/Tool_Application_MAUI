# Tool Application .net MAUI

The **Tool Application .net MAUI** is a mobile application built using **.NET MAUI** that provides a collection of useful tools including **BMI calculator**, **color picker**, and **payment calculator** functionalities.

---

## Table of Contents

1. [Features](#features)  
2. [Installation](#installation)  
3. [Usage](#usage)  
4. [Structure](#structure)  
5. [Dependencies](#dependencies)  

---

## Features

- **BMI Calculator**:
  - Calculate Body Mass Index based on height and weight inputs    
  - Categorization of results (underweight, normal, overweight, etc.)

- **Color Picker**:
  - Interactive color selection interface
  - Multiple color representation format HEX
  - Real-time color preview

- **PerfectPay**:
  - Bill splitting and tip calculation functionality
  - Support for multiple payment scenarios
  - Customizable tip percentages

---

## Installation

### Prerequisites

- .NET 7.0 or higher
- Visual Studio 2022 with .NET MAUI workload
- Android SDK (for Android deployment)

### Clone the Repository

To get started, clone this repository to your local machine:

```bash
git clone https://github.com/Poyamohamadi/Tool_Application_MAUI.git
cd Tool_Application_MAUI
```

### Build and Run

1. Open the solution in Visual Studio 2022  
2. Select the target platform (Android, iOS, Windows)  
3. Build the solution  
4. Run the application on an emulator or physical device  

---

## Usage

### BMI Calculator

1. Launch the application and navigate to the **BMI** section  
2. Select your preferred measurement system  
3. Enter your height and weight  
4. View your BMI result and corresponding health category  
5. Save calculations for future reference  

### Color Picker

1. Access the **Color Picker** tool from the main menu  
2. Use the color wheel, sliders, or input fields to select colors  
3. Copy color values in your preferred format  
4. Save colors to your custom palette  

### PerfectPay

1. Open the **PerfectPay** feature  
2. Enter the total bill amount  
3. Specify the number of people and tip percentage  
4. View the calculated amount per person  
5. Adjust parameters as needed for different scenarios  

---

## Structure

The application is organized into the following main components:

1. **Main Application** (`App.xaml` and `App.xaml.cs`):
   - Application entry point and global resources  
   - Navigation structure initialization  

2. **Views**:
   - `BMI.xaml` – BMI calculation interface  
   - `ColorPicker.xaml` – Color selection interface  
   - `PerfectPay.xaml` – Payment calculation interface  

3. **ViewModels**:
   - `BMI.xaml.cs` – BMI calculation logic and state management  
   - `ColorPicker.xaml.cs` – Color manipulation logic  
   - `PerfectPay.xaml.cs` – Payment calculation logic  

4. **Models**:
   - Data models for BMI records, color data, and payment information  
   - Validation and business logic  

---

## Dependencies

- **.NET MAUI**: Cross-platform framework for building native mobile and desktop apps  

---

## Acknowledgments

- **.NET MAUI Team**: Thanks to the developers of .NET MAUI for providing a robust cross-platform framework  
- **Microsoft**: For continuous support and development of the .NET ecosystem  

---

## Contact

For questions or feedback, feel free to reach out:

- **GitHub**: [Poyamohamadi](https://github.com/Poyamohamadi)

---

Thank you for using the **Tool Application .net MAUI**! 🙂 
