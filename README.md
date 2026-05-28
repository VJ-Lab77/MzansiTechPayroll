# Mzansi Tech Contractors Payroll System

## Project Overview
This is a Windows Forms payroll application developed for **Mzansi Tech Contractors**

## Author
- **Name:** VJ
- **Module:** PM-04 (Testing and Debugging Software Systems)
- **Date:** 28 May 2026

---

## Project Structure
Solution 'MzansiTechPayroll'

### Project Descriptions

| Project | Status | Description |
|---------|--------|-------------|
| `MzansiTechPayroll` |  WORKING | Main Windows Forms application |
| `MzansiTechPayroll.Tests` |  FAILED | Initial test project (.NET 8.0) - Framework mismatch |
| `MzansiTechsPayroll.Tests` |  PASSING | Correct test project (.NET 4.7.2) - All tests pass |



## Application Features

### Input Fields
| Field | Description | Validation Rules |
|-------|-------------|------------------|
| Contractor Name | Name of the contractor | Cannot be empty |
| Hours Worked | Number of hours worked | Must be positive number |
| Dependents | Number of dependents (0-10) | Must be between 0 and 10 |

### Calculations Performed

| Calculation | Formula | Rate |
|-------------|---------|------|
| Hourly Rate | Fixed rate | R950.00 per hour |
| Gross Pay | Hours × Hourly Rate | - |
| UIF | Gross Pay × 1% | 1% |
| Membership Fee | Gross Pay × 13% | 13% |
| PAYE | (Gross - (Gross × 0.0575 × Dependents)) × 25% | 25% |
| Net Pay | Gross - (UIF + PAYE + Membership) | - |

---

## How to Run the Application

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2

