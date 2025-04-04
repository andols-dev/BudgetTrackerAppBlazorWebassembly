# Budget Tracker App

Budget tracking application built with Blazor WebAssembly, allowing users to manage their incomes and expenses with ease. This application supports adding, removing, and viewing incomes and expenses, while also providing real-time budget summary information.

## Features

- **💰 Track Incomes and Expenses**: Easily add your incomes and expenses with their respective names and amounts.
- **📊 Real-time Budget Summary**: View a live budget summary including total income, total expenses, and remaining balance.
- **🔔 Toast Notifications**: Get instant feedback on your actions, such as adding or removing income/expense, with toast notifications.
- **🗄️ Local Storage**: All data (income and expense entries) are saved locally in the browser using Blazored LocalStorage, ensuring persistence across sessions.

## Usage

### 💸 Add Income
- Input the name of your income and the amount.
- Click on the "Add Income" button to add the income to the list.
  
### 💳 Add Expense
- Input the name of your expense and the amount.
- Click on the "Add Expense" button to add the expense to the list.

### 📊 View Budget Summary
- The budget summary section will automatically show the total income, total expenses, and remaining balance.

### ❌ Remove Income/Expense
- Each income and expense entry has a "Remove" button to delete it from the list.

### 🔔 Notifications
- Toast notifications will show up when an income or expense is added, removed, or when fields are left empty.

## Technologies Used

- **Blazor WebAssembly**: A .NET web framework for building interactive web apps with C#.
- **Blazored.Toast**: A library to show toast notifications.
- **Blazored.LocalStorage**: A library for storing data in the browser's local storage.
- **Bootstrap**: For styling the application.

## Code Structure

### Models
- **💼 Income**: Represents an income entry with `Id`, `Name`, `Amount`, and `Date`.
- **💵 Expense**: Represents an expense entry with `Id`, `Name`, `Amount`, and `Date`.

### Services
- **💰 IncomeService**: Handles adding, removing, loading, and saving incomes.
- **📉 ExpenseService**: Handles adding, removing, loading, and saving expenses.

### Pages
- **🏠 Main Page** (`/`): Displays the budget summary, income and expense input forms, and lists of current incomes and expenses.

### Components
- **🔔 Toast Notifications**: Positioned at the top-right, providing user feedback when actions occur.

