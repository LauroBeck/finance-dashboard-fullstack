# finance-dashboard-fullstack

This repository contains a **full-stack finance application**:

- **JPMorgan API** – A .NET 8 Web API that performs financial analytics:
  - Index calculations
  - Returns calculations
  - Volatility calculations
  - Moving average calculations

- **Finance Dashboard** – A React frontend for visualizing financial data.

---

## Getting Started

### 1. Run the API

```bash
cd JPMorgan
dotnet restore
dotnet run
The API will run on https://localhost:5001 (or http://localhost:5000).
cd finance-dashboard
npm install
npm start
The frontend will run on http://localhost:3000 and communicate with the API.
______________________________________________________________________________
Project Structure
JPMorgan/             # .NET API
  Calculations/       # Financial calculators
  Controllers/        # API controllers
  Services/           # Business logic
finance-dashboard/    # React frontend
